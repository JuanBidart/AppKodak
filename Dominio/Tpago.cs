using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tpago
    {
        public long Id { get; set; }
        public long? IdVenta { get; set; }
        public long? IdFormaPago { get; set; }
        public decimal? Monto { get; set; }
    }
}
