using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{


    // Clase ProductoNegocio - usa ConexionGeneral para todas las operaciones
    public class ConexionProducto
    {
        private ConexionGeneral conexion;

        public ConexionProducto()
        {
            conexion = new ConexionGeneral();
        }

        public ConexionProducto(string cadenaConexion)
        {
            conexion = new ConexionGeneral(cadenaConexion);
        }

        // LEER - Obtener todos los productos
        public async Task<List<Tproductos>> ObtenerTodosAsync()
        {
            string sql = @"SELECT id, cod, nombre, recargo, fecha, stock, iva, marca, observacion 
                          FROM productos 
                          WHERE activo = true 
                          ORDER BY nombre";

            return await conexion.EjecutarConsultaAsync(sql, MapearProducto);
        }

        // LEER - Obtener producto por ID
        public async Task<Tproductos> ObtenerPorIdAsync(int id)
        {
            string sql = @"SELECT id, cod, nombre, recargo, fecha, stock, iva, marca, observacion  
                          FROM productos 
                          WHERE id = @id AND activo = true";

            var parametros = new[] { new NpgsqlParameter("@id", id) };
            var productos = await conexion.EjecutarConsultaAsync(sql, MapearProducto, parametros);

            return productos.Count > 0 ? productos[0] : null;
        }

        // LEER - Buscar productos por nombre
        public async Task<List<Tproductos>> BuscarPorNombreAsync(string nombre)
        {
            string sql = @"SELECT id, cod, nombre, recargo, fecha, stock, iva, marca, observacion  
                          FROM productos 
                          WHERE nombre ILIKE @nombre AND activo = true 
                          ORDER BY nombre";

            var parametros = new[] { new NpgsqlParameter("@nombre", $"%{nombre}%") };
            return await conexion.EjecutarConsultaAsync(sql, MapearProducto, parametros);
        }

        // CREAR - Insertar nuevo producto
        public async Task<int> InsertarAsync(Tproductos producto)
        {
            string sql = @"INSERT INTO productos (SELECT id, cod, nombre, recargo, fecha, stock, iva, marca, observacion,activo ) 
                          VALUES (@cod @nombre, @recargo, @fecha, @stock, @iva ,@marca ,@observacion, @activo) 
                          RETURNING id";

            var parametros = new[]
            {
                
                new NpgsqlParameter("@cod", (object)producto.Cod ?? DBNull.Value),
                new NpgsqlParameter("@nombre", (object)producto.Nombre ?? DBNull.Value),
                new NpgsqlParameter("@recargo", producto.Recargo),
                new NpgsqlParameter("@fecha", DateTime.Now),
                new NpgsqlParameter("@stock", producto.Stock),
                new NpgsqlParameter("@iva", producto.Iva),
                new NpgsqlParameter("@marca", producto.Marca),
                new NpgsqlParameter("@observacion", producto.Observacion),
                new NpgsqlParameter("@activo", producto.Activo)
            };

            return await conexion.EjecutarEscalarAsync<int>(sql, parametros);
        }

        // ACTUALIZAR - Actualizar producto existente
        public async Task<bool> ActualizarAsync(Tproductos producto)
        {
            string sql = @"UPDATE productos 
                          SET cod = @cod,
                              nombre = @nombre, 
                              recargo = @recargo,
                                fecha = @fecha,
                                stock = @stock,
                                iva = @iva,
                                marca = @marca,
                                observacion = @observacion,
                                activo = @activo
                          WHERE id = @id AND activo = true";

            var parametros = new[]
            {
                 new NpgsqlParameter("@cod", (object)producto.Cod ?? DBNull.Value),
                new NpgsqlParameter("@nombre", (object)producto.Nombre ?? DBNull.Value),
                new NpgsqlParameter("@recargo", producto.Recargo),
                new NpgsqlParameter("@fecha", DateTime.Now),
                new NpgsqlParameter("@stock", producto.Stock),
                new NpgsqlParameter("@iva", producto.Iva),
                new NpgsqlParameter("@marca", producto.Marca),
                new NpgsqlParameter("@observacion", producto.Observacion),
                new NpgsqlParameter("@activo", producto.Activo)
            };

            int filasAfectadas = await conexion.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }

        // ELIMINAR - Eliminación lógica (marca como inactivo)
        public async Task<bool> EliminarAsync(int id)
        {
            string sql = @"UPDATE productos 
                          SET activo = false, fecha_modificacion = @fechaModificacion 
                          WHERE id = @id";

            var parametros = new[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@fechaModificacion", DateTime.Now)
            };

            int filasAfectadas = await conexion.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }

        // ACTUALIZAR - Solo el stock
        public async Task<bool> ActualizarStockAsync(int id, int nuevoStock)
        {
            string sql = @"UPDATE productos 
                          SET stock = @stock, fecha_modificacion = @fechaModificacion 
                          WHERE id = @id AND activo = true";

            var parametros = new[]
            {
                new NpgsqlParameter("@id", id),
                new NpgsqlParameter("@stock", nuevoStock),
                new NpgsqlParameter("@fechaModificacion", DateTime.Now)
            };

            int filasAfectadas = await conexion.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }

        // VALIDAR - Verificar si existe producto por nombre
        public async Task<bool> ExistePorNombreAsync(string nombre, int? excluirId = null)
        {
            string sql = "SELECT COUNT(*) FROM productos WHERE LOWER(nombre) = LOWER(@nombre) AND activo = true";
            var parametros = new List<NpgsqlParameter> { new("@nombre", nombre) };

            if (excluirId.HasValue)
            {
                sql += " AND id != @excluirId";
                parametros.Add(new NpgsqlParameter("@excluirId", excluirId.Value));
            }

            int count = await conexion.EjecutarEscalarAsync<int>(sql, parametros.ToArray());
            return count > 0;
        }

        // LEER - Productos con stock bajo
        public async Task<List<Tproductos>> ObtenerStockBajoAsync(int stockMinimo = 10)
        {
            string sql = @"SELECT id, cod, nombre, recargo, fecha, stock, iva, marca, observacion 
                          FROM productos 
                          WHERE stock <= @stockMinimo AND activo = true 
                          ORDER BY stock ASC, nombre";

            var parametros = new[] { new NpgsqlParameter("@stockMinimo", stockMinimo) };
            return await conexion.EjecutarConsultaAsync(sql, MapearProducto, parametros);
        }

        // ELIMINAR - Eliminación física (solo si realmente lo necesitas)
        public async Task<bool> EliminarFisicoAsync(int id)
        {
            string sql = "DELETE FROM productos WHERE id = @id";
            var parametros = new[] { new NpgsqlParameter("@id", id) };

            int filasAfectadas = await conexion.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }

        // Método privado para mapear DataReader a objeto Producto
        private static Tproductos MapearProducto(NpgsqlDataReader reader)
        {
            return new Tproductos
            {
                Id = reader.GetInt32("id"),
                Cod = reader.IsDBNull("cod") ? null : reader.GetString("cod"),
                Nombre = reader.IsDBNull("nombre") ? null : reader.GetString("nombre"),
                Recargo = reader.GetDecimal("recargo"),
                Fecha = reader.GetDateTime("fecha"),
                Stock = reader.GetInt32("stock"),
                Iva = reader.GetDecimal("precio"),
                Marca = reader.GetString("marca"),
                Observacion = reader.GetString("observacion"),                
                Activo = reader.GetBoolean("activo")
            };
        }

        // Métodos síncronos (por si los prefieres)
        public List<Tproductos> ObtenerTodos()
        {
            return ObtenerTodosAsync().GetAwaiter().GetResult();
        }

        public Tproductos ObtenerPorId(int id)
        {
            return ObtenerPorIdAsync(id).GetAwaiter().GetResult();
        }

        public int Insertar(Tproductos producto)
        {
            return InsertarAsync(producto).GetAwaiter().GetResult();
        }

        public bool Actualizar(Tproductos producto)
        {
            return ActualizarAsync(producto).GetAwaiter().GetResult();
        }

        public bool Eliminar(int id)
        {
            return EliminarAsync(id).GetAwaiter().GetResult();
        }

        // Liberar recursos
        public void Dispose()
        {
            conexion?.Dispose();
        }
    }
}