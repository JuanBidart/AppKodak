using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tventa
    {
        public long Id { get; set; }
        public long? IdCliente { get; set; }
        public long? IdUsuario { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Total { get; set; }
        public string? NumeroComprobante { get; set; }
        public string? TipoComprobante { get; set; }
        public string? Estado { get; set; }
        public long? IdListaPrecio { get; set; }
        public string? Moneda { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
