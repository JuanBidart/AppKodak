using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TcomboPromocion
    {
        public long Id { get; set; }
        public long? IdPromocion { get; set; }
        public long? IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Descuento { get; set; }
    }
}
