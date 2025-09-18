using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Negocio;

namespace appkodak
{
    public partial class FrmEjecutarSentenciaSql : Form
    {
        private ConexionGeneral conexion;
        //private SQLExecutorLogic sqlExecutor;

        public FrmEjecutarSentenciaSql()
        {
            InicializarConexion();
            InitializeComponent();
        }

        private void InicializarConexion()
        {
            try
            {
                conexion = new ConexionGeneral();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al inicializar conexión: {ex.Message}", ex);
            }
        }

        public async Task<string> VerificarEstadoConexion()
        {
            try
            {
                var (conn, error) = await conexion.Estado();
                if (conn != null)
                {
                    string nombreDB = conn.Database;
                    conn.Close();
                    return $"Conectado a la base de datos: {nombreDB}";
                }
                else
                {
                    return $"Error de conexión: {error}";
                }
            }
            catch (Exception ex)
            {
                return $"Error al verificar conexión: {ex.Message}";
            }
        }

        public async Task EjecutarConsulta(string consultaSQL, DataGridView dgvResultados)
        {
            if (string.IsNullOrWhiteSpace(consultaSQL))
            {
                throw new ArgumentException("La consulta SQL no puede estar vacía.");
            }

            try
            {
                // Determinar si es una consulta SELECT o un comando
                string consultaTrimmed = consultaSQL.Trim().ToUpper();

                if (consultaTrimmed.StartsWith("SELECT") ||
                    consultaTrimmed.StartsWith("WITH") ||
                    consultaTrimmed.StartsWith("SHOW") ||
                    consultaTrimmed.StartsWith("EXPLAIN"))
                {
                    await EjecutarConsultaSelect(consultaSQL, dgvResultados);
                }
                else
                {
                    await EjecutarComando(consultaSQL, dgvResultados);
                }
            }
            catch (Exception ex)
            {
                // Limpiar el DataGridView en caso de error
                LimpiarResultados(dgvResultados);
                throw new Exception($"Error al ejecutar consulta: {ex.Message}", ex);
            }
        }

        private async Task EjecutarConsultaSelect(string consultaSQL, DataGridView dgvResultados)
        {
            try
            {
                var dataTable = new DataTable();

                // Usar la conexión para ejecutar la consulta
                using (var conn = new NpgsqlConnection(conexion.ObtenerCadenaConexion()))
                {
                    await conn.OpenAsync();
                    using (var cmd = new NpgsqlCommand(consultaSQL, conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            // Crear las columnas basadas en el esquema del reader
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                dataTable.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                            }

                            // Llenar el DataTable con los datos
                            while (await reader.ReadAsync())
                            {
                                var row = dataTable.NewRow();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.IsDBNull(i) ? DBNull.Value : reader.GetValue(i);
                                }
                                dataTable.Rows.Add(row);
                            }
                        }
                    }
                }

                // Actualizar el DataGridView en el hilo principal
                if (dgvResultados.InvokeRequired)
                {
                    dgvResultados.Invoke(new Action(() => dgvResultados.DataSource = dataTable));
                }
                else
                {
                    dgvResultados.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en consulta SELECT: {ex.Message}", ex);
            }
        }

        private async Task EjecutarComando(string consultaSQL, DataGridView dgvResultados)
        {
            try
            {
                int filasAfectadas = await conexion.EjecutarComandoAsync(consultaSQL);

                // Limpiar resultados ya que los comandos no devuelven datos
                LimpiarResultados(dgvResultados);

                MessageBox.Show($"Comando ejecutado exitosamente.\nFilas afectadas: {filasAfectadas}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en comando: {ex.Message}", ex);
            }
        }

        public void LimpiarResultados(DataGridView dgvResultados)
        {
            if (dgvResultados.InvokeRequired)
            {
                dgvResultados.Invoke(new Action(() => dgvResultados.DataSource = null));
            }
            else
            {
                dgvResultados.DataSource = null;
            }
        }

        // Método para ejecutar consultas escalares (COUNT, MAX, etc.)
        public async Task<object> EjecutarConsultaEscalar(string consultaSQL)
        {
            try
            {
                return await conexion.EjecutarEscalarAsync<object>(consultaSQL);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en consulta escalar: {ex.Message}", ex);
            }
        }

        // Método para ejecutar consultas predefinidas
        public async Task EjecutarConsultaPredefinida(TipoConsultaPredefinida tipo, DataGridView dgvResultados, string nombreTabla = "")
        {
            string consulta = tipo switch
            {
                TipoConsultaPredefinida.ListarTablas =>
                    "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' ORDER BY table_name;",

                TipoConsultaPredefinida.ListarColumnas when !string.IsNullOrEmpty(nombreTabla) =>
                    $"SELECT column_name, data_type, is_nullable FROM information_schema.columns WHERE table_name = '{nombreTabla}' ORDER BY ordinal_position;",

                TipoConsultaPredefinida.VersionPostgreSQL =>
                    "SELECT version();",

                TipoConsultaPredefinida.TamañoBaseDatos =>
                    "SELECT pg_database.datname, pg_size_pretty(pg_database_size(pg_database.datname)) AS size FROM pg_database ORDER BY pg_database_size(pg_database.datname) DESC;",

                _ => throw new ArgumentException("Tipo de consulta no válido o falta información adicional")
            };

            await EjecutarConsulta(consulta, dgvResultados);
        }

        public void Dispose()
        {
            conexion?.Dispose();
        }

        // Reemplaza la instancia de SQLExecutorLogic por la propia clase FrmEjecutarSentenciaSql
        // ya que los métodos como VerificarEstadoConexion y EjecutarConsulta están definidos en esta clase.
        // Cambia las siguientes líneas:

        // Antes:
        // sqlExecutor = new SQLExecutorLogic();
        // string estadoConexion = await sqlExecutor.VerificarEstadoConexion();
        // await sqlExecutor.EjecutarConsulta(txtConsulta.Text, dgvResultados);
        // sqlExecutor.LimpiarResultados(dgvResultados);

        // Después:
        private async void FrmEjecutarSentenciaSql_Load(object sender, EventArgs e)
        {
            // Actualizar el label de conexión al abrir el form
            try
            {
                string estadoConexion = await VerificarEstadoConexion();
                lblEstado.Text = estadoConexion;
                lblEstado.ForeColor = estadoConexion.Contains("Conectado") ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                lblEstado.Text = $"Error: {ex.Message}";
                lblEstado.ForeColor = Color.Red;
            }
        }

        private async void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                await EjecutarConsulta(txtConsulta.Text, dgvResultados);
                MessageBox.Show("Consulta ejecutada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConsulta.Clear();
            LimpiarResultados(dgvResultados);
        }
    }

    public enum TipoConsultaPredefinida
    {
        ListarTablas,
        ListarColumnas,
        VersionPostgreSQL,
        TamañoBaseDatos
    }

    // Ejemplo de cómo usar en tu form:
    
    
        
        
        // Tus controles existentes:
        // private TextBox txtConsulta;
        // private DataGridView dgvResultados;  
        // private Label lblEstado;
        // private Button btnEjecutar;
        // private Button btnLimpiar;

      
     
    
}