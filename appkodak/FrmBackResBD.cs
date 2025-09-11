using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appkodak
{
    public partial class FrmBackResBD : Form
    {
        public FrmBackResBD()
        {
            InitializeComponent();
        }
        public string PrutaPostgresBin = @"C:\Program Files\PostgreSQL\17\bin";


        private void btnBackup_Click(object sender, EventArgs e)
        {
            ConexionDatos datos = new ConexionDatos();
            HacerBackupAsync(datos);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            ConexionDatos datos = new ConexionDatos();

            // Podés abrir un cuadro de diálogo para elegir el archivo de backup
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de Backup (*.backup;*.sql)|*.backup;*.sql|Todos los archivos (*.*)|*.*";
            ofd.Title = "Seleccionar archivo de backup";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RestaurarBackupAsync(datos, ofd.FileName);
            }

        }
        public async Task HacerBackupConOpcionesAsync(ConexionDatos datos, bool backupCompleto, bool soloDatos, bool soloEsquema)
        {
            try
            {
                string rutaPostgresBin = PrutaPostgresBin;

                string rutaBackup = @"C:\backup";
                if (!Directory.Exists(rutaBackup))
                    Directory.CreateDirectory(rutaBackup);

                string tipoBackup = backupCompleto ? "completo" :
                                    soloDatos ? "datos" :
                                    soloEsquema ? "esquema" : "completo";

                string archivoBackup = Path.Combine(rutaBackup,
                    $"{datos.database}_{tipoBackup}_{DateTime.Now:yyyyMMdd_HHmmss}.backup");

                // Construir argumentos según opción
                string argumentos = $"-h {datos.host} -U {datos.username} -d {datos.database} -F c -b -v -f \"{archivoBackup}\"";

                if (soloDatos)
                    argumentos = $"-h {datos.host} -U {datos.username} -d {datos.database} -a -F c -b -v -f \"{archivoBackup}\""; // data-only
                else if (soloEsquema)
                    argumentos = $"-h {datos.host} -U {datos.username} -d {datos.database} -s -F c -b -v -f \"{archivoBackup}\""; // schema-only

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = Path.Combine(rutaPostgresBin, "pg_dump.exe"),
                    Arguments = argumentos,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // PATH y password
                string path = psi.EnvironmentVariables["PATH"];
                psi.EnvironmentVariables["PATH"] = rutaPostgresBin + ";" + path;
                psi.EnvironmentVariables["PGPASSWORD"] = datos.password;

                using (Process proceso = new Process())
                {
                    proceso.StartInfo = psi;
                    proceso.Start();

                    string salida = await proceso.StandardOutput.ReadToEndAsync();
                    string error = await proceso.StandardError.ReadToEndAsync();

                    proceso.WaitForExit();

                    if (proceso.ExitCode == 0)
                    {
                        MessageBox.Show($"Backup creado correctamente en:\n{archivoBackup}",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error en el backup:\n{error}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Preguntar si quiere restaurar en una base nueva
                DialogResult dr = MessageBox.Show("¿Desea restaurar este backup en una base nueva para empezar desde cero?",
                    "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string nuevaBase = datos.database + "_nuevo_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                    // Crear base vacía
                    await CrearBaseVacíaAsync(datos, nuevaBase);

                    // Restaurar backup
                    await RestaurarBackupAsync(datos, archivoBackup, nuevaBase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Crear base vacía
        private async Task CrearBaseVacíaAsync(ConexionDatos datos, string nombreBase)
        {
            string connString = $"Host={datos.host};Username={datos.username};Password={datos.password};Database=postgres"; // DB postgres para crear otra
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $"CREATE DATABASE \"{nombreBase}\";";
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        private async Task RestaurarBackupAsync(ConexionDatos datos, string archivoBackup, string databaseDestino)
        {
            string rutaPostgresBin = PrutaPostgresBin;

            string argumentos = $"-h {datos.host} -U {datos.username} -d {databaseDestino} -v \"{archivoBackup}\"";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Path.Combine(rutaPostgresBin, "pg_restore.exe"),
                Arguments = argumentos,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            string path = psi.EnvironmentVariables["PATH"];
            psi.EnvironmentVariables["PATH"] = rutaPostgresBin + ";" + path;
            psi.EnvironmentVariables["PGPASSWORD"] = datos.password;

            using (Process proceso = new Process())
            {
                proceso.StartInfo = psi;
                proceso.Start();

                string salida = await proceso.StandardOutput.ReadToEndAsync();
                string error = await proceso.StandardError.ReadToEndAsync();

                proceso.WaitForExit();

                if (proceso.ExitCode == 0)
                {
                    MessageBox.Show($"Base de datos restaurada correctamente en: {databaseDestino}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error en la restauración:\n{error}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public async Task HacerBackupAsync(ConexionDatos datos)
        {
            try
            {
                // Ruta del bin de PostgreSQL (ajustala según tu instalación)
                string rutaPostgresBin = PrutaPostgresBin;

                // Carpeta donde se guardará el backup
                string rutaBackup = @"C:\backup";
                if (!Directory.Exists(rutaBackup))
                    Directory.CreateDirectory(rutaBackup);

                // Nombre del archivo
                string archivoBackup = Path.Combine(rutaBackup,
                    $"{datos.database}_{DateTime.Now:yyyyMMdd_HHmmss}.backup");

                // Argumentos para pg_dump
                string argumentos = $"-h {datos.host} -U {datos.username} -d {datos.database} -F c -b -v -f \"{archivoBackup}\"";

                // Configurar proceso
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = Path.Combine(rutaPostgresBin, "pg_dump.exe"),
                    Arguments = argumentos,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // 🔹 Agregar el binario de PostgreSQL al PATH del proceso
                string path = psi.EnvironmentVariables["PATH"];
                psi.EnvironmentVariables["PATH"] = rutaPostgresBin + ";" + path;

                // Pasar password de forma segura
                psi.EnvironmentVariables["PGPASSWORD"] = datos.password;

                using (Process proceso = new Process())
                {
                    proceso.StartInfo = psi;
                    proceso.Start();

                    // Lectura asincrónica de salida y error
                    Task<string> salidaTask = proceso.StandardOutput.ReadToEndAsync();
                    Task<string> errorTask = proceso.StandardError.ReadToEndAsync();

                    await Task.WhenAll(salidaTask, errorTask);

                    proceso.WaitForExit();

                    string salida = salidaTask.Result;
                    string error = errorTask.Result;

                    if (proceso.ExitCode == 0)
                    {
                        MessageBox.Show($"Backup creado correctamente en:\n{archivoBackup}",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error en el backup:\n{error}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task RestaurarBackupAsync(ConexionDatos datos, string archivoBackup)
        {
            try
            {
                if (!File.Exists(archivoBackup))
                {
                    MessageBox.Show("El archivo de backup no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ruta del bin de PostgreSQL
                string rutaPostgresBin = PrutaPostgresBin;

                // Argumentos para pg_restore
                string argumentos = $"-h {datos.host} -U {datos.username} -d {datos.database} -v \"{archivoBackup}\"";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = Path.Combine(rutaPostgresBin, "pg_restore.exe"),
                    Arguments = argumentos,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Agregar PostgreSQL al PATH solo para este proceso
                string path = psi.EnvironmentVariables["PATH"];
                psi.EnvironmentVariables["PATH"] = rutaPostgresBin + ";" + path;

                // Pasar password de forma segura
                psi.EnvironmentVariables["PGPASSWORD"] = datos.password;

                using (Process proceso = new Process())
                {
                    proceso.StartInfo = psi;
                    proceso.Start();

                    // Leer salida y error de forma asincrónica
                    Task<string> salidaTask = proceso.StandardOutput.ReadToEndAsync();
                    Task<string> errorTask = proceso.StandardError.ReadToEndAsync();

                    await Task.WhenAll(salidaTask, errorTask);

                    proceso.WaitForExit();

                    string salida = salidaTask.Result;
                    string error = errorTask.Result;

                    if (proceso.ExitCode == 0)
                    {
                        MessageBox.Show("Base de datos restaurada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error en la restauración:\n{error}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
