using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TdetalleVentas
    {
        public long Id { get; set; }
        public long? IdVenta { get; set; }
        public long? IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? SubtotalLinea { get; set; }
        public decimal? IvaPercent { get; set; }
        public decimal? MontoIva { get; set; }
        public decimal? DescuentoPercent { get; set; }
        public decimal? PrecioCostoSnapshot { get; set; }
        public decimal? TotalLinea { get; set; }
    }
}
