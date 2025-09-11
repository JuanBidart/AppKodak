using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Negocio
{
    public static class Herramientas
    {



        public static string GuardarSeguro(string texto)
        {
            byte[] datos = Encoding.UTF8.GetBytes(texto);
            byte[] protegidos = ProtectedData.Protect(datos, null, DataProtectionScope.LocalMachine);
            return Convert.ToBase64String(protegidos);
        }

        public static string LeerSeguro(string base64)
        {
            byte[] protegidos = Convert.FromBase64String(base64);
            byte[] datos = ProtectedData.Unprotect(protegidos, null, DataProtectionScope.LocalMachine);
            return Encoding.UTF8.GetString(datos);
        }


    }
}
