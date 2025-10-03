using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TproductoProveedor
    {
        public long Id { get; set; }
        public long? IdProducto { get; set; }
        public long? IdProveedor { get; set; }
        public decimal? PrecioCosto { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public bool? EsPrincipal { get; set; }
        public string? CodigoProveedor { get; set; }
        public int? PlazoEntregaDias { get; set; }
        public int? Moq { get; set; }
        public string? Moneda { get; set; }
        public bool? Activo { get; set; }
    }
}
