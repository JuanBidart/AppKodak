using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tproductos
    {
        public long Id { get; set; }
        public string Cod { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public decimal? Recargo { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Stock { get; set; }
        public decimal? Iva { get; set; }
        public string? Marca { get; set; }
        public string? Observacion { get; set; }
        public bool Activo { get; set; }

    }
}
