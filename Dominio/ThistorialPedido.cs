using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ThistorialPedido
    {
        public long Id { get; set; }
        public decimal? PrecioAnterior { get; set; }
        public decimal? PrecioActual { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? CostoAnterior { get; set; }
        public decimal? CostoActual { get; set; }
        public long? IdProducto { get; set; }
        public long? IdVenta { get; set; }
    }
}
