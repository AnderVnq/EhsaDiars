using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Validators
    {

        public static bool ValidarDNI(string dni)
        {
            return Regex.IsMatch(dni, @"^\d{8}$");
        }

        public static bool ValidarNombreApellido(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }

        public static bool ValidarTelefono(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\d{9}$");
        }
        public static bool ValidarTextoSinRepetir(string texto)
        {
            char prevChar = '\0';
            foreach (char c in texto)
            {
                if (c == prevChar)
                    return false;
                prevChar = c;
            }
            return true;
        }

    }
}
