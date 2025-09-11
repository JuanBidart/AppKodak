using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tcaja
    {
        public long Id { get; set; }
        public decimal? Gastos { get; set; }
        public decimal? EntradaDinero { get; set; }
        public decimal? SalidaDinero { get; set; }
        public decimal? Pagos { get; set; }
        public decimal? Impuestos { get; set; }
        public decimal? VentasDia { get; set; }
        public DateTime? Fecha { get; set; }
        public long? IdUsuario { get; set; }
    }
}
