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
            if (dni.Length < 4)
            {
                return false;
            }
            return Regex.IsMatch(dni, @"^\d{8}$");
        }

        public static bool ValidarNombreApellido(string texto)
        {
            if (texto.Length < 4)
            {
                return false;
            }
            return Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }

        public static bool ValidarTelefono(string telefono)
        {
            if (telefono.Length < 4)
            {
                return false;
            }
            return Regex.IsMatch(telefono, @"^\d{9}$");
        }
        public static bool ValidarTextoSinRepetir(string texto)
        {
            if (texto.Length < 4)
            {
                return false;
            }
            char prevChar = '\0';
            foreach (char c in texto)
            {
                if (c == prevChar)
                    return false;
                prevChar = c;
            }
            return true;
        }

        public static bool ValidarSoloNumeros(string texto)
        {
            if (texto.Length < 4)
            {
                return false;
            }
            Regex regex = new Regex("^[0-9]+$");

            return regex.IsMatch(texto);
        }


        public static bool ValidarTexto(string texto)
        {

            Regex regex = new Regex("^[a-zA-Z ]+$");

            // Validar la cadena
            return regex.IsMatch(texto);
        }



        public static bool ValidarRepeticion(string texto, int maxRepetitions)
        {
            if (string.IsNullOrEmpty(texto) || texto.Length < maxRepetitions)
            {
                return true;
            }

            char prevChar = texto[0];
            int count = 1; // Contador para el número de repeticiones.
            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] == prevChar)
                {
                    count++;
                }
                else
                {
                    count = 1;
                    prevChar = texto[i];
                }
                if (count > maxRepetitions)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
