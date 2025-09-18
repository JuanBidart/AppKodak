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
    public class ConexionProveedores
    {
        ConexionGeneral conexionGeneral;
        public ConexionProveedores()
        {
            conexionGeneral = new ConexionGeneral(); 

        }

        public ConexionProveedores(string cadenaConexion)
        {
            conexionGeneral = new ConexionGeneral(cadenaConexion);
        }
        // Método privado para mapear DataReader a objeto Producto
        private static Tproveedor MapearProveedor(NpgsqlDataReader reader)
        {
            return new Tproveedor
            {
                Id = reader.GetInt32("id"),
                Nombre = reader.IsDBNull("nombre") ? null : reader.GetString("nombre"),
                Ciudad = reader.GetString("ciudad"),
                Direccion = reader.GetString("direccion"),
                Email = reader.GetString("email"),
                Telefono1 = reader.GetString("telefono1"),
                Telefono2 = reader.GetString("telefono2"),
                PaginaWeb = reader.GetString("paginaweb"),
                Iva = reader.GetDecimal("iva"),
                Activo = reader.GetBoolean("activo")

            };
        }

        public async Task<List<Tproveedor>> ObtenerTodosAsync()
        {
            string sql = @"SELECT id, nombre, ciudad, direccion, email, telefono1, telefono2, paginaweb, iva 
                           FROM proveedores 
                           WHERE activo = true 
                           ORDER BY nombre";
            return await conexionGeneral.EjecutarConsultaAsync(sql, MapearProveedor);
        }

        public async Task<Tproveedor?> ObtenerPorIdAsync(long id)
        {
            string sql = @"SELECT id, nombre, ciudad, direccion, email, telefono1, telefono2, paginaweb, iva 
                           FROM proveedores 
                           WHERE id = @id AND activo = true";
            var parametros = new[] { new NpgsqlParameter("@id", id) };
            var resultados = await conexionGeneral.EjecutarConsultaAsync(sql, MapearProveedor, parametros);
            return resultados.FirstOrDefault();
        }
        // LEER - Buscar productos por nombre
        public async Task<List<Tproveedor>> BuscarPorNombreAsync(string nombre)
        {
            string sql = @"SELECT id, nombre, ciudad, direccion, email, telefono1, telefono2, paginaweb, iva 
                           FROM proveedores 
                           WHERE nombre ILIKE @nombre AND activo = true 
                           ORDER BY nombre";
            var parametros = new[] { new NpgsqlParameter("@nombre", $"%{nombre}%") };
            return await conexionGeneral.EjecutarConsultaAsync(sql, MapearProveedor, parametros);
        }
        // CREAR - Insertar nuevo proveedor
        public async Task<long> InsertarAsync(Tproveedor proveedor)
        {
            string sql = @"INSERT INTO proveedores 
                   (nombre, ciudad, direccion, email, telefono1, telefono2, paginaweb, iva, activo) 
                   VALUES (@nombre, @ciudad, @direccion, @email, @telefono1, @telefono2, @paginaweb, @iva, true) 
                   RETURNING id";

            var parametros = new[]
            {
        new NpgsqlParameter("@nombre", proveedor.Nombre),
        new NpgsqlParameter("@ciudad", (object?)proveedor.Ciudad ?? DBNull.Value),
        new NpgsqlParameter("@direccion", (object?)proveedor.Direccion ?? DBNull.Value),
        new NpgsqlParameter("@email", (object?)proveedor.Email ?? DBNull.Value),
        new NpgsqlParameter("@telefono1", (object?)proveedor.Telefono1 ?? DBNull.Value),
        new NpgsqlParameter("@telefono2", (object?)proveedor.Telefono2 ?? DBNull.Value),
        new NpgsqlParameter("@paginaweb", (object?)proveedor.PaginaWeb ?? DBNull.Value),
        new NpgsqlParameter("@iva", (object?)proveedor.Iva ?? DBNull.Value)
    };

            return await conexionGeneral.EjecutarEscalarAsync<long>(sql, parametros);
        }

        // ACTUALIZAR - Modificar proveedor existente
        public async Task<bool> ActualizarAsync(Tproveedor proveedor)
        {
            string sql = @"UPDATE proveedores 
                           SET nombre = @nombre, ciudad = @ciudad, direccion = @direccion, email = @email, 
                               telefono1 = @telefono1, telefono2 = @telefono2, paginaweb = @paginaweb, iva = @iva 
                           WHERE id = @id AND activo = true";
            var parametros = new[]
            {
                new NpgsqlParameter("@id", proveedor.Id),
                new NpgsqlParameter("@nombre", proveedor.Nombre),
                new NpgsqlParameter("@ciudad", (object?)proveedor.Ciudad ?? DBNull.Value),
                new NpgsqlParameter("@direccion", (object?)proveedor.Direccion ?? DBNull.Value),
                new NpgsqlParameter("@email", (object?)proveedor.Email ?? DBNull.Value),
                new NpgsqlParameter("@telefono1", (object?)proveedor.Telefono1 ?? DBNull.Value),
                new NpgsqlParameter("@telefono2", (object?)proveedor.Telefono2 ?? DBNull.Value),
                new NpgsqlParameter("@paginaweb", (object?)proveedor.PaginaWeb ?? DBNull.Value),
                new NpgsqlParameter("@iva", (object?)proveedor.Iva ?? DBNull.Value)
            };
            int filasAfectadas = await conexionGeneral.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }
        // ELIMINAR - Eliminación lógica (desactivar proveedor)
        public async Task<bool> EliminarLogicoAsync(long id)
        {
            string sql = "UPDATE proveedores SET activo = false WHERE id = @id AND activo = true";
            var parametros = new[] { new NpgsqlParameter("@id", id) };
            int filasAfectadas = await conexionGeneral.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }
        // Validar si el nombre del proveedor ya existe (para evitar duplicados)
        public async Task<bool> NombreExisteAsync(string nombre, long? excluirId = null)
        {
            string sql = "SELECT COUNT(1) FROM proveedores WHERE nombre = @nombre AND activo = true";
            var parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("@nombre", nombre)
            };
            if (excluirId.HasValue)
            {
                sql += " AND id != @excluirId";
                parametros.Add(new NpgsqlParameter("@excluirId", excluirId.Value));
            }
            int count = await conexionGeneral.EjecutarEscalarAsync<int>(sql, parametros.ToArray());
            return count > 0;
        }
        // ELIMINAR - Eliminación física (solo si realmente lo necesitas)
        public async Task<bool> EliminarFisicoAsync(long id)
        {
            string sql = "DELETE FROM proveedores WHERE id = @id";
            var parametros = new[] { new NpgsqlParameter("@id", id) };
            int filasAfectadas = await conexionGeneral.EjecutarComandoAsync(sql, parametros);
            return filasAfectadas > 0;
        }
        // Métodos síncronos (por si los prefieres)
        public List<Tproveedor> ObtenerTodos()
        {
            return ObtenerTodosAsync().GetAwaiter().GetResult();
        }
        public Tproveedor? ObtenerPorId(long id)
        {
            return ObtenerPorIdAsync(id).GetAwaiter().GetResult();
        }
        public List<Tproveedor> BuscarPorNombre(string nombre)
        {
            return BuscarPorNombreAsync(nombre).GetAwaiter().GetResult();
        }
        public long Insertar(Tproveedor proveedor)
        {
            return InsertarAsync(proveedor).GetAwaiter().GetResult();
        }
        public bool Actualizar(Tproveedor proveedor)
        {
            return ActualizarAsync(proveedor).GetAwaiter().GetResult();
        }
        public bool EliminarLogico(long id)
        {
            return EliminarLogicoAsync(id).GetAwaiter().GetResult();
        }
        public bool NombreExiste(string nombre, long? excluirId = null)
        {
            return NombreExisteAsync(nombre, excluirId).GetAwaiter().GetResult();
        }
        public bool EliminarFisico(long id)
        {
            return EliminarFisicoAsync(id).GetAwaiter().GetResult();
        }


    }

}
