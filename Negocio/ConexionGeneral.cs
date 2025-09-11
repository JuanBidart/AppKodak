using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;


namespace Negocio
{
    public class ConexionDatos
    {
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string database { get; set; }
        string Ruta = "config.txt";
        public ConexionDatos()
        {
            if (!File.Exists(Ruta))
            {
                File.Create("config.txt").Close();

                File.WriteAllText(Ruta, Herramientas.GuardarSeguro("host=localhost;username=postgres;password=admin;database=prueba"));
                host = "localhost";
                username = "postgres";
                password = "admin";
                database = "prueba";
            }
            else 
            {
                string datos = Herramientas.LeerSeguro(File.ReadAllText(Ruta));
                var parametros = datos.Split(';');
                foreach (var parametro in parametros)
                {
                    var claveValor = parametro.Split('=');
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
                        }
                    }
                }

            }
        }
        public void guardarDatos(string host, string username, string password, string database)
        {
            File.WriteAllText(Ruta, Herramientas.GuardarSeguro($"host={host};username={username};password={password};database={database}"));
        }
    }
    public class ConexionGeneral
    {
        
        public NpgsqlConnection conexion { get; set; }
        public ConexionDatos Datos { get; set; }
        public NpgsqlCommand comando { get; set; }
        public NpgsqlDataReader lector { get; set; }



        public ConexionGeneral()
        {
            Datos = new ConexionDatos();

            string cadenaConexion = $"Host={Datos.host};Username={Datos.username};Password={Datos.password};Database={Datos.database}";
            conexion = new NpgsqlConnection(cadenaConexion);
        }
        public ConexionGeneral(string cadenaConexion)
        {
            conexion = new NpgsqlConnection(cadenaConexion);
        }


        public NpgsqlConnection estado()
        {         
            return conexion;    
        }
        public void abrirConexion()
        {
            conexion.Open();
        }
        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
