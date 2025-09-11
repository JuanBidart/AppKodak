using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tusuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string? Tel { get; set; }
        public string? Mail { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public long? IdRol { get; set; }
        public string? Email { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool? IsActive { get; set; }
        public int? FailedLogins { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
