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
        public static bool EsNumero(string textBox) 
        {
            char ultimo = textBox.Last();
            
            
                if (Char.IsDigit(ultimo))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                                   

        }

        public static string ObtenerFechaActual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
        public static string ObtenerHoraActual()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }



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
