using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Npgsql;

namespace Negocio
{
    // Clase para manejar configuración (sin cambios en la lógica, solo mejoras menores)
    public class ConexionDatos
    {
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string database { get; set; }
        public int port { get; set; } = 5432;

        string Ruta = "config.txt";

        public ConexionDatos()
        {
            if (!File.Exists(Ruta))
            {
                File.Create("config.txt").Close();
                File.WriteAllText(Ruta, Herramientas.GuardarSeguro("host=localhost;username=postgres;password=admin;database=prueba;port=5432Pooling=true;Maximum Pool Size=20"));

                host = "localhost";
                username = "postgres";
                password = "admin";
                database = "prueba";
                port = 5432;
            }
            else
            {
                string datos = Herramientas.LeerSeguro(File.ReadAllText(Ruta));
                var parametros = datos.Split(';');

                foreach (var parametro in parametros)
                {
                    var claveValor = parametro.Split('=', 2); // Límite de 2 por si password tiene =
                    if (claveValor.Length == 2)
                    {
                        var clave = claveValor[0].Trim().ToLower();
                        var valor = claveValor[1].Trim();

                        switch (clave)
                        {
                            case "host":
                                host = valor;
                                break;
                            case "username":
                                username = valor;
                                break;
                            case "password":
                                password = valor;
                                break;
                            case "database":
                                database = valor;
                                break;
                            case "port":
                                if (int.TryParse(valor, out int p))
                                    port = p;
                                break;
                        }
                    }
                }
            }
        }

        public void guardarDatos(string host, string username, string password, string database, int port = 5432)
        {
            File.WriteAllText(Ruta, Herramientas.GuardarSeguro($"host={host};username={username};password={password};database={database};port={port};Pooling=true;Maximum Pool Size=20"));
        }
    }

    // Clase ConexionGeneral mejorada - SOLO maneja conexiones base
    public class ConexionGeneral : IDisposable
    {
        private ConexionDatos Datos;
        private string cadenaConexion;
        private bool disposed = false;

        public ConexionGeneral()
        {
            Datos = new ConexionDatos();
            cadenaConexion = $"Host={Datos.host};Port={Datos.port};Username={Datos.username};Password={Datos.password};Database={Datos.database};Pooling=true;Maximum Pool Size=20";
        }

        public ConexionGeneral(string cadenaConexionPersonalizada)
        {
            cadenaConexion = cadenaConexionPersonalizada+";Pooling = true; Maximum Pool Size = 20";
        }

        // Método para ejecutar consultas que devuelven datos (SELECT) - ASYNC
        public async Task<List<T>> EjecutarConsultaAsync<T>(string sql, Func<NpgsqlDataReader, T> mapearFila, params NpgsqlParameter[] parametros)
        {
            var resultados = new List<T>();

            using var conexion = new NpgsqlConnection(cadenaConexion);
            using var comando = new NpgsqlCommand(sql, conexion);

            if (parametros != null)
                comando.Parameters.AddRange(parametros);

            try
            {
                await conexion.OpenAsync();
                using var lector = await comando.ExecuteReaderAsync();

                while (await lector.ReadAsync())
                {
                    resultados.Add(mapearFila(lector));
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en consulta: {sql}", ex);
            }

            return resultados;
        }

        // Método para ejecutar comandos (INSERT, UPDATE, DELETE) - ASYNC
        public async Task<int> EjecutarComandoAsync(string sql, params NpgsqlParameter[] parametros)
        {
            using var conexion = new NpgsqlConnection(cadenaConexion);
            using var comando = new NpgsqlCommand(sql, conexion);

            if (parametros != null)
                comando.Parameters.AddRange(parametros);

            try
            {
                await conexion.OpenAsync();
                return await comando.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en comando: {sql}", ex);
            }
        }

        // Método para obtener un solo valor (COUNT, MAX, etc.) - ASYNC
        public async Task<T> EjecutarEscalarAsync<T>(string sql, params NpgsqlParameter[] parametros)
        {
            using var conexion = new NpgsqlConnection(cadenaConexion);
            using var comando = new NpgsqlCommand(sql, conexion);

            if (parametros != null)
                comando.Parameters.AddRange(parametros);

            try
            {
                await conexion.OpenAsync();
                var resultado = await comando.ExecuteScalarAsync();

                if (resultado == null || resultado == DBNull.Value)
                    return default(T);

                return (T)resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en consulta escalar: {sql}", ex);
            }
        }

        // Método para transacciones - ASYNC
        public async Task EjecutarTransaccionAsync(Func<NpgsqlConnection, NpgsqlTransaction, Task> operaciones)
        {
            using var conexion = new NpgsqlConnection(cadenaConexion);
            await conexion.OpenAsync();

            using var transaccion = await conexion.BeginTransactionAsync();
            try
            {
                await operaciones(conexion, transaccion);
                await transaccion.CommitAsync();
            }
            catch (Exception)
            {
                await transaccion.RollbackAsync();
                throw;
            }
        }

        // Métodos síncronos (para compatibilidad si los necesitas)
        public List<T> EjecutarConsulta<T>(string sql, Func<NpgsqlDataReader, T> mapearFila, params NpgsqlParameter[] parametros)
        {
            return EjecutarConsultaAsync(sql, mapearFila, parametros).GetAwaiter().GetResult();
        }

        public int EjecutarComando(string sql, params NpgsqlParameter[] parametros)
        {
            return EjecutarComandoAsync(sql, parametros).GetAwaiter().GetResult();
        }

        public T EjecutarEscalar<T>(string sql, params NpgsqlParameter[] parametros)
        {
            return EjecutarEscalarAsync<T>(sql, parametros).GetAwaiter().GetResult();
        }

        // Método para obtener la cadena de conexión (por si lo necesitas)
        public string ObtenerCadenaConexion()
        {
            return cadenaConexion;
        }

        // Método para probar la conexión
        public async Task<bool> ProbarConexionAsync()
        {
            try
            {
                using var conexion = new NpgsqlConnection(cadenaConexion);
                await conexion.OpenAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<(NpgsqlConnection? conexion, string? errorMensaje)> Estado()
        {
            var conexion = new NpgsqlConnection(cadenaConexion);
            try
            {
                await conexion.OpenAsync();
                return (conexion, null);
            }
            catch (Exception ex)
            {
                return (null, ex.Message); // Solo el mensaje
            }
        }
        // IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Limpiar recursos manejados si los hay
                }
                disposed = true;
            }
        }
    }
}