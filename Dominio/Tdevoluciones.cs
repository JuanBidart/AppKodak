using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tdevoluciones
    {
        public long Id { get; set; }
        public long? IdVenta { get; set; }
        public long? IdDetalle { get; set; }
        public int? Cantidad { get; set; }
        public string? Motivo { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
