using Dominio;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConexionProductoProveedor
    {
        private ConexionGeneral conexion;

        public ConexionProductoProveedor()
        {
            conexion = new ConexionGeneral();
        }

        public ConexionProductoProveedor(string cadenaConexion)
        {
            conexion = new ConexionGeneral(cadenaConexion);
        }
        private static TproductoProveedor MapearProducto(NpgsqlDataReader reader)
        {
            return new TproductoProveedor
            {
                Id = reader.GetInt64("id"),
                IdProducto = reader.IsDBNull("idproducto") ? null : reader.GetInt64("idproducto"),
                IdProveedor = reader.IsDBNull("idproveedor") ? null : reader.GetInt64("idproveedor"),
                PrecioCosto = reader.IsDBNull("preciocosto") ? null : reader.GetDecimal("preciocosto"),
                FechaActualizacion = reader.IsDBNull("fechaactualizacion") ? null : reader.GetDateTime("fechaactualizacion"),
                EsPrincipal = reader.IsDBNull("esprincipal") ? null : reader.GetBoolean("esprincipal"),
                CodigoProveedor = reader.IsDBNull("codigoproveedor") ? null : reader.GetString("codigoproveedor"),
                PlazoEntregaDias = reader.IsDBNull("plazoentregadias") ? null : reader.GetInt32("plazoentregadias"),
                Moq = reader.IsDBNull("moq") ? null : reader.GetInt32("moq"),
                Moneda = reader.IsDBNull("moneda") ? null : reader.GetString("moneda"),
                Activo = reader.GetBoolean("activo")
            };
        }


        // LEER - Obtener todos los productos_provedor
        public async Task<List<TproductoProveedor>> ObtenerTodosAsync()
        {
            string sql = @"SELECT id, idproducto, idproveedor, preciocosto, fechaactualizacion, esprincipal, codigoproveedor, plazoentregadias, moq, moneda, activo
                          FROM productO_proveedor
                          WHERE activo = true";

            return await conexion.EjecutarConsultaAsync(sql, MapearProducto);
        }
        // INSERTAR - Nuevo producto_proveedor
        public async Task<bool> InsertarAsync(TproductoProveedor productoProveedor)
        {
            string sql = @"INSERT INTO productO_proveedor (idproducto, idproveedor, precio_costo, fecha_actualizacion, es_principal, codigo_proveedor, plazo_entrega_dias, moq, moneda, activo)
                        VALUES (@idproducto, @idproveedor, @preciocosto, @fechaactualizacion, @esprincipal, @codigoproveedor, @plazoentregadias, @moq, @moneda, @activo)";
            var parametros = new[]
            {
                new NpgsqlParameter("@idproducto", productoProveedor.IdProducto ?? (object)DBNull.Value),
                new NpgsqlParameter("@idproveedor", productoProveedor.IdProveedor ?? (object)DBNull.Value),
                new NpgsqlParameter("@preciocosto", productoProveedor.PrecioCosto ?? (object)DBNull.Value),
                new NpgsqlParameter("@fechaactualizacion", productoProveedor.FechaActualizacion ?? (object)DBNull.Value),
                new NpgsqlParameter("@esprincipal", productoProveedor.EsPrincipal ?? (object)DBNull.Value),
                new NpgsqlParameter("@codigoproveedor", productoProveedor.CodigoProveedor ?? (object)DBNull.Value),
                new NpgsqlParameter("@plazoentregadias", productoProveedor.PlazoEntregaDias ?? (object)DBNull.Value),
                new NpgsqlParameter("@moq", productoProveedor.Moq ?? (object)DBNull.Value),
                new NpgsqlParameter("@moneda", productoProveedor.Moneda ?? (object)DBNull.Value),
                new NpgsqlParameter("@activo", productoProveedor.Activo)
            };
            int filasAfectadas = await conexion.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }

        //Inserta con transaccion
        public async Task InsertarProductoProveedorConTransaccionAsync(
         TproductoProveedor productoProveedor,
         NpgsqlConnection conexionExterna,
         NpgsqlTransaction transaccionExterna)
        {
            string sql = @"INSERT INTO productO_proveedor (idproducto, idproveedor, precio_costo, fecha_actualizacion, es_principal, codigo_proveedor, plazo_entrega_dias, moq, moneda, activo)
                        VALUES (@idproducto, @idproveedor, @preciocosto, @fechaactualizacion, @esprincipal, @codigoproveedor, @plazoentregadias, @moq, @moneda, @activo)";

            // NOTA CLAVE: Usamos la CONEXIÓN EXTERNA y la TRANSACCIÓN EXTERNA
            using var comando = new NpgsqlCommand(sql, conexionExterna, transaccionExterna);

            // Mapeo de parámetros
            comando.Parameters.AddWithValue("@idproducto", productoProveedor.IdProducto ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@idproveedor", productoProveedor.IdProveedor ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@preciocosto", productoProveedor.PrecioCosto ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@fechaactualizacion", productoProveedor.FechaActualizacion ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@esprincipal", productoProveedor.EsPrincipal ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@codigoproveedor", productoProveedor.CodigoProveedor ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@plazoentregadias", productoProveedor.PlazoEntregaDias ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@moq", productoProveedor.Moq ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@moneda", productoProveedor.Moneda ?? (object)DBNull.Value);
            comando.Parameters.AddWithValue("@activo", productoProveedor.Activo);

            // Ejecutar el comando. No se devuelve un valor ni se hace commit.
            await comando.ExecuteNonQueryAsync();
        }


        // ACTUALIZAR - Modificar producto_proveedor existente
        public async Task<bool> ActualizarAsync(TproductoProveedor productoProveedor)
        {
            string sql = @"UPDATE productO_proveedor
                           SET idproducto = @idproducto,
                               idproveedor = @idproveedor,
                               preciocosto = @preciocosto,
                               fechaactualizacion = @fechaactualizacion,
                               esprincipal = @esprincipal,
                               codigoproveedor = @codigoproveedor,
                               plazoentregadias = @plazoentregadias,
                               moq = @moq,
                               moneda = @moneda,
                               activo = @activo
                           WHERE id = @id";
            var parametros = new[]
            {
                new NpgsqlParameter("@id", productoProveedor.Id),
                new NpgsqlParameter("@idproducto", productoProveedor.IdProducto ?? (object)DBNull.Value),
                new NpgsqlParameter("@idproveedor", productoProveedor.IdProveedor ?? (object)DBNull.Value),
                new NpgsqlParameter("@preciocosto", productoProveedor.PrecioCosto ?? (object)DBNull.Value),
                new NpgsqlParameter("@fechaactualizacion", productoProveedor.FechaActualizacion ?? (object)DBNull.Value),
                new NpgsqlParameter("@esprincipal", productoProveedor.EsPrincipal ?? (object)DBNull.Value),
                new NpgsqlParameter("@codigoproveedor", productoProveedor.CodigoProveedor ?? (object)DBNull.Value),
                new NpgsqlParameter("@plazoentregadias", productoProveedor.PlazoEntregaDias ?? (object)DBNull.Value),
                new NpgsqlParameter("@moq", productoProveedor.Moq ?? (object)DBNull.Value),
                new NpgsqlParameter("@moneda", productoProveedor.Moneda ?? (object)DBNull.Value),
                new NpgsqlParameter("@activo", productoProveedor.Activo)
            };
            int filasAfectadas = await conexion.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }
        // ELIMINAR - Desactivar producto_proveedor (borrado lógico)
        public async Task<bool> EliminarAsync(long id)
        {
            string sql = "UPDATE productO_proveedor SET activo = false WHERE id = @id";
            var parametros = new[] { new NpgsqlParameter("@id", id) };
            int filasAfectadas = await conexion.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }
        public void Dispose()
        {
            conexion = null;
            GC.SuppressFinalize(this);
        }
        // Métodos síncronos (por si los prefieres)
        public List<TproductoProveedor> ObtenerTodos()
        {
            return ObtenerTodosAsync().GetAwaiter().GetResult();
        }
        public bool Insertar(TproductoProveedor productoProveedor)
        {
            return InsertarAsync(productoProveedor).GetAwaiter().GetResult();
        }
        public bool Actualizar(TproductoProveedor productoProveedor)
        {
            return ActualizarAsync(productoProveedor).GetAwaiter().GetResult();
        }
        public bool Eliminar(long id)
        {
            return EliminarAsync(id).GetAwaiter().GetResult();
        }


    }
}
