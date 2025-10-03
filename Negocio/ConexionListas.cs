using Dominio;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConexionListas

    {

        private ConexionGeneral conexion;

        public ConexionListas()
        {
            conexion = new ConexionGeneral();
        }

        public ConexionListas(string cadenaConexion)
        {
            conexion = new ConexionGeneral(cadenaConexion);
        }


        // LEER - Obtener todas las listas
        public async Task<List<TlistaPrecio>> ObtenerListasAsync()
        {
            string sql = "SELECT id, tipo, porcentajedescuento FROM listasprecios";
            return await conexion.EjecutarConsultaAsync(sql, lector => new TlistaPrecio
            {
                Id = lector.GetInt32(0),
                Tipo = lector.GetString(1),
                PorcentajeDescuento = lector.IsDBNull(2) ? 0 : lector.GetDecimal(2)
            });
        }
        // AGREGAR - Insertar nueva lista
        public async Task<int> AgregarListaAsync(TlistaPrecio lista)
        {
            string sql = "INSERT INTO listasprecios (tipo, porcentajedescuento) VALUES (@nombre, @porcentajedescuento)";
            var parametros = new[]
            {

                new NpgsqlParameter("@cod", (object)lista.Tipo ?? DBNull.Value),
                new NpgsqlParameter("@nombre", (object)lista.PorcentajeDescuento ?? DBNull.Value),
            };

            return await conexion.EjecutarComandoAsync(sql, parametros);
        }
        // ACTUALIZAR - Modificar lista existente
        public async Task<int> ActualizarListaAsync(TlistaPrecio lista)
        {
            string sql = "UPDATE listasprecios SET tipo = @tipo, porcentajedescuento = @porcentajedescuento WHERE id = @id";
            var parametros = new[]
            {
                new NpgsqlParameter("@id", lista.Id),
                new NpgsqlParameter("@tipo", (object)lista.Tipo ?? DBNull.Value),
                new NpgsqlParameter("@porcentajedescuento", (object)lista.PorcentajeDescuento ?? DBNull.Value),
            };
            return await conexion.EjecutarComandoAsync(sql, parametros);
        }
    }
}
