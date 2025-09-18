using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tproveedor
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Ciudad { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? PaginaWeb { get; set; }
        public decimal? Iva { get; set; }
        public bool Activo { get; set; } = true;
    }
}
