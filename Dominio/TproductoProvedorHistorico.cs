using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TproductoProvedorHistorico
    {
        public long Id { get; set; }
        public long? IdProducto { get; set; }
        public long? IdProveedor { get; set; }
        public decimal? PrecioCosto { get; set; }
        public DateTime? FechaCosto { get; set; }
    }
}
