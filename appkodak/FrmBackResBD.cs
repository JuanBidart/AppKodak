using Negocio;
using Npgsql;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkodak
{
    public partial class FrmBackResBD : Form
    {
        private const string POSTGRES_BIN_PATH = @"C:\Program Files\PostgreSQL\17\bin";
        private const string BACKUP_FOLDER = @"C:\backup";
        private const int TIMEOUT_MINUTES = 5;

        public FrmBackResBD()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            var datos = new ConexionDatos();

            if (!ValidarDatosConexion(datos))
                return;

            await HacerBackupAsync(datos, rbtnBackupCompleto.Checked, rbtnSoloDatos.Checked, rbtnSoloEsquema.Checked);
        }

        private async void btnRestaurar_Click(object sender, EventArgs e)
        {
            var datos = new ConexionDatos();

            if (!ValidarDatosConexion(datos))
                return;

            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de Backup (*.backup;*.sql)|*.backup;*.sql|Todos los archivos (*.*)|*.*";
                ofd.Title = "Seleccionar archivo de backup";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    await RestaurarBackupConOpcionesAsync(datos, ofd.FileName);
                }
            }
        }

        private void rbtnBackupCompleto_CheckedChanged(object sender, EventArgs e)
        {
            CambiarColorRadioButton((RadioButton)sender);
        }

        #endregion

        #region Métodos Principales

        /// <summary>
        /// Crea un backup de la base de datos con las opciones especificadas
        /// </summary>
        public async Task HacerBackupAsync(ConexionDatos datos, bool backupCompleto, bool soloDatos, bool soloEsquema)
        {
            try
            {
                EnsureBackupDirectoryExists();

                var tipoBackup = DeterminarTipoBackup(backupCompleto, soloDatos, soloEsquema);
                var archivoBackup = GenerarNombreArchivo(datos.database, tipoBackup);
                var argumentos = ConstruirArgumentosBackup(datos, archivoBackup, soloDatos, soloEsquema);

                var exitoso = await EjecutarProcesoPostgresAsync("pg_dump.exe", argumentos, datos.password);

                if (exitoso)
                {
                    MostrarMensajeExito($"Backup creado correctamente en:\n{archivoBackup}");
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError($"Error en backup: {ex.Message}");
            }
        }

        /// <summary>
        /// Restaura un backup con opciones avanzadas de restauración
        /// </summary>
        public async Task RestaurarBackupConOpcionesAsync(ConexionDatos datos, string archivoBackup)
        {
            try
            {
                if (!File.Exists(archivoBackup))
                {
                    MostrarMensajeError("El archivo de backup no existe.");
                    return;
                }

                // Mostrar diálogo de opciones de restauración
                using (var dialogoRestauracion = new DialogoRestauracion(datos.database))
                {
                    if (dialogoRestauracion.ShowDialog() != DialogResult.OK)
                        return;

                    var opcionesRestauracion = dialogoRestauracion.OpcionesSeleccionadas;
                    var databaseDestino = opcionesRestauracion.NombreBaseDatos;

                    // Crear base de datos si no existe y se solicita
                    if (opcionesRestauracion.CrearBaseSiNoExiste)
                    {
                        var existeBase = await VerificarExistenciaBaseDatos(datos, databaseDestino);
                        if (!existeBase)
                        {
                            await CrearBaseDatosAsync(datos, databaseDestino);
                        }
                        else if (opcionesRestauracion.LimpiarBaseSiExiste)
                        {
                            await LimpiarBaseDatosAsync(datos, databaseDestino);
                        }
                    }

                    // Construir argumentos de restauración según opciones
                    var argumentos = ConstruirArgumentosRestauracion(datos, archivoBackup, databaseDestino, opcionesRestauracion);

                    var exitoso = await EjecutarProcesoPostgresAsync("pg_restore.exe", argumentos, datos.password);

                    if (exitoso)
                    {
                        MostrarMensajeExito($"Base de datos restaurada correctamente en: {databaseDestino}");
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError($"Error en restauración: {ex.Message}");
            }
        }

        #endregion

        #region Métodos de Base de Datos

        /// <summary>
        /// Verifica si una base de datos existe
        /// </summary>
        private async Task<bool> VerificarExistenciaBaseDatos(ConexionDatos datos, string nombreBase)
        {
            var connString = $"Host={datos.host};Username={datos.username};Password={datos.password};Database=postgres";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    await conn.OpenAsync();
                    using (var cmd = new NpgsqlCommand("SELECT 1 FROM pg_database WHERE datname = @dbname", conn))
                    {
                        cmd.Parameters.AddWithValue("@dbname", nombreBase);
                        var result = await cmd.ExecuteScalarAsync();
                        return result != null;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Crea una nueva base de datos
        /// </summary>
        private async Task CrearBaseDatosAsync(ConexionDatos datos, string nombreBase)
        {
            var connString = $"Host={datos.host};Username={datos.username};Password={datos.password};Database=postgres";

            using (var conn = new NpgsqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new NpgsqlCommand($"CREATE DATABASE \"{nombreBase}\"", conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        /// <summary>
        /// Limpia una base de datos existente
        /// </summary>
        private async Task LimpiarBaseDatosAsync(ConexionDatos datos, string nombreBase)
        {
            var connString = $"Host={datos.host};Username={datos.username};Password={datos.password};Database={nombreBase}";

            using (var conn = new NpgsqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new NpgsqlCommand("DROP SCHEMA public CASCADE; CREATE SCHEMA public;", conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        #endregion

        #region Métodos de Proceso

        /// <summary>
        /// Ejecuta un proceso de PostgreSQL (pg_dump o pg_restore)
        /// </summary>
        private async Task<bool> EjecutarProcesoPostgresAsync(string ejecutable, string argumentos, string password)
        {
            var psi = new ProcessStartInfo
            {
                FileName = Path.Combine(POSTGRES_BIN_PATH, ejecutable),
                Arguments = argumentos,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Configurar entorno
            var path = psi.EnvironmentVariables["PATH"];
            psi.EnvironmentVariables["PATH"] = POSTGRES_BIN_PATH + ";" + path;
            psi.EnvironmentVariables["PGPASSWORD"] = password;

            using (var proceso = new Process { StartInfo = psi })
            {
                proceso.Start();

                var salidaTask = proceso.StandardOutput.ReadToEndAsync();
                var errorTask = proceso.StandardError.ReadToEndAsync();
                var procesoTask = Task.Run(() => proceso.WaitForExit());

                // Timeout de 5 minutos
                var timeoutTask = Task.Delay(TimeSpan.FromMinutes(TIMEOUT_MINUTES));
                var completedTask = await Task.WhenAny(procesoTask, timeoutTask);

                if (completedTask == timeoutTask)
                {
                    proceso.Kill();
                    MostrarMensajeError("El proceso tardó demasiado y fue cancelado.");
                    return false;
                }

                var salida = await salidaTask;
                var error = await errorTask;

                if (proceso.ExitCode == 0)
                {
                    return true;
                }
                else
                {
                    MostrarMensajeError($"Error en el proceso:\n{error}");
                    return false;
                }
            }
        }

        #endregion

        #region Métodos de Utilidad

        /// <summary>
        /// Valida que los datos de conexión sean correctos
        /// </summary>
        private bool ValidarDatosConexion(ConexionDatos datos)
        {
            if (string.IsNullOrWhiteSpace(datos?.database) ||
                string.IsNullOrWhiteSpace(datos?.host) ||
                string.IsNullOrWhiteSpace(datos?.username))
            {
                MostrarMensajeError("Los datos de conexión están incompletos.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Asegura que el directorio de backup existe
        /// </summary>
        private void EnsureBackupDirectoryExists()
        {
            if (!Directory.Exists(BACKUP_FOLDER))
                Directory.CreateDirectory(BACKUP_FOLDER);
        }

        /// <summary>
        /// Determina el tipo de backup basado en las opciones seleccionadas
        /// </summary>
        private string DeterminarTipoBackup(bool backupCompleto, bool soloDatos, bool soloEsquema)
        {
            if (soloDatos) return "datos";
            if (soloEsquema) return "esquema";
            return "completo";
        }

        /// <summary>
        /// Genera el nombre del archivo de backup
        /// </summary>
        private string GenerarNombreArchivo(string database, string tipoBackup)
        {
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            return Path.Combine(BACKUP_FOLDER, $"{database}_{tipoBackup}_{timestamp}.backup");
        }

        /// <summary>
        /// Construye los argumentos para pg_dump
        /// </summary>
        private string ConstruirArgumentosBackup(ConexionDatos datos, string archivoBackup, bool soloDatos, bool soloEsquema)
        {
            var argumentosBase = $"-h {datos.host} -U {datos.username} -d {datos.database} -F c -b -v -f \"{archivoBackup}\"";

            if (soloDatos)
                return $"-h {datos.host} -U {datos.username} -d {datos.database} -a -F c -b -v -f \"{archivoBackup}\"";

            if (soloEsquema)
                return $"-h {datos.host} -U {datos.username} -d {datos.database} -s -F c -b -v -f \"{archivoBackup}\"";

            return argumentosBase;
        }

        /// <summary>
        /// Construye los argumentos para pg_restore
        /// </summary>
        private string ConstruirArgumentosRestauracion(ConexionDatos datos, string archivoBackup, string databaseDestino, OpcionesRestauracion opciones)
        {
            var argumentos = $"-h {datos.host} -U {datos.username} -d {databaseDestino} -v";

            if (opciones.SoloDatos)
                argumentos += " -a";
            else if (opciones.SoloEsquema)
                argumentos += " -s";

            if (opciones.LimpiarAntesDeRestauras)
                argumentos += " -c";

            argumentos += $" \"{archivoBackup}\"";

            return argumentos;
        }

        /// <summary>
        /// Cambia el color del RadioButton seleccionado
        /// </summary>
        private void CambiarColorRadioButton(RadioButton radioButton)
        {
            radioButton.ForeColor = radioButton.Checked ? Color.LightSeaGreen : Color.White;
        }

        /// <summary>
        /// Muestra un mensaje de éxito
        /// </summary>
        private void MostrarMensajeExito(string mensaje)
        {
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Muestra un mensaje de error
        /// </summary>
        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

       
    }

    #region Clases de Apoyo

    /// <summary>
    /// Opciones para la restauración de backup
    /// </summary>
    public class OpcionesRestauracion
    {
        public string NombreBaseDatos { get; set; }
        public bool CrearBaseSiNoExiste { get; set; } = true;
        public bool LimpiarBaseSiExiste { get; set; } = false;
        public bool LimpiarAntesDeRestauras { get; set; } = false;
        public bool SoloDatos { get; set; } = false;
        public bool SoloEsquema { get; set; } = false;
    }

    /// <summary>
    /// Diálogo para seleccionar opciones de restauración
    /// </summary>
    public partial class DialogoRestauracion : Form
    {
        public OpcionesRestauracion OpcionesSeleccionadas { get; private set; }

        private TextBox txtNombreBase;
        private CheckBox chkCrearSiNoExiste;
        private CheckBox chkLimpiarSiExiste;
        private CheckBox chkLimpiarAntes;
        private RadioButton rbTodo;
        private RadioButton rbSoloDatos;
        private RadioButton rbSoloEsquema;

        public DialogoRestauracion(string baseDatosOriginal)
        {
           // InitializeComponent();
            InicializarControles(baseDatosOriginal);
        }

        private void InicializarControles(string baseDatosOriginal)
        {
            // Configuración básica del form
            Text = "Opciones de Restauración";
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterParent;

            // Crear controles
            var lblNombre = new Label { Text = "Nombre de base de datos:", Location = new Point(10, 10), Size = new Size(200, 23) };
            txtNombreBase = new TextBox { Text = baseDatosOriginal + "_restaurada", Location = new Point(10, 35), Size = new Size(350, 23) };

            chkCrearSiNoExiste = new CheckBox { Text = "Crear base si no existe", Checked = true, Location = new Point(10, 70), Size = new Size(200, 23) };
            chkLimpiarSiExiste = new CheckBox { Text = "Limpiar base si existe", Location = new Point(10, 100), Size = new Size(200, 23) };
            chkLimpiarAntes = new CheckBox { Text = "Limpiar antes de restaurar", Location = new Point(10, 130), Size = new Size(200, 23) };

            rbTodo = new RadioButton { Text = "Restaurar todo", Checked = true, Location = new Point(10, 160), Size = new Size(120, 23) };
            rbSoloDatos = new RadioButton { Text = "Solo datos", Location = new Point(140, 160), Size = new Size(100, 23) };
            rbSoloEsquema = new RadioButton { Text = "Solo esquema", Location = new Point(250, 160), Size = new Size(100, 23) };

            var btnOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(200, 220), Size = new Size(75, 23) };
            var btnCancel = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Location = new Point(285, 220), Size = new Size(75, 23) };

            btnOk.Click += (s, e) => {
                OpcionesSeleccionadas = new OpcionesRestauracion
                {
                    NombreBaseDatos = txtNombreBase.Text,
                    CrearBaseSiNoExiste = chkCrearSiNoExiste.Checked,
                    LimpiarBaseSiExiste = chkLimpiarSiExiste.Checked,
                    LimpiarAntesDeRestauras = chkLimpiarAntes.Checked,
                    SoloDatos = rbSoloDatos.Checked,
                    SoloEsquema = rbSoloEsquema.Checked
                };
            };

            // Agregar controles al form
            Controls.AddRange(new Control[] {
                lblNombre, txtNombreBase,
                chkCrearSiNoExiste, chkLimpiarSiExiste, chkLimpiarAntes,
                rbTodo, rbSoloDatos, rbSoloEsquema,
                btnOk, btnCancel
            });
        }
    }

    #endregion
}