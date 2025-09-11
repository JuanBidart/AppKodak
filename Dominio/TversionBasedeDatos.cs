using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TversionBasedeDatos
    {
        public long Id { get; set; }
        public string Version { get; set; } = string.Empty;
        public DateTime? Fecha { get; set; }
    }
}
