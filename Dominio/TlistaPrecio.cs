using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TlistaPrecio
    {
        public long Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public decimal? PorcentajeDescuento { get; set; }
    }
}
