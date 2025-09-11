using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TMovimientoCaja
    {
        public long Id { get; set; }
        public string? TipoOperacion { get; set; }
        public decimal? Monto { get; set; }
        public long? IdUsuario { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
