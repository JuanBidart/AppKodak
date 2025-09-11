using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TstockMovimiento
    {
        public long Id { get; set; }
        public long? IdProducto { get; set; }
        public string? Tipo { get; set; }
        public int? Cantidad { get; set; }
        public string? ReferenciaTipo { get; set; }
        public long? ReferenciaId { get; set; }
        public long? IdUsuario { get; set; }
        public DateTime? Fecha { get; set; }
        public long? IdAlmacen { get; set; }
    }
}
