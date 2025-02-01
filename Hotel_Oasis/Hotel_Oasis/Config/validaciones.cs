using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hotel_Oasis.Config
{
    internal class validaciones
    {
        // Validación para que el nombre empiece con mayúscula
        public bool ValidarNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return false;

            // Expresión regular para validar que comience con mayúscula y luego minúsculas
            return Regex.IsMatch(nombre, @"^[A-Z][a-zA-Z]*$");
        }

        // Validación para números de teléfono (ejemplo: 10 dígitos)
        public bool ValidarTelefono(string telefono)
        {
            // Validar que el número de teléfono contenga exactamente 10 dígitos
            return Regex.IsMatch(telefono, @"^\d{10}$");
        }

        // Validación para correos electrónicos
        public bool ValidarCorreo(string correo)
        {
            // Expresión regular básica para validar un correo electrónico
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Validación de apellidos que empiecen con mayúscula
        public bool ValidarApellido(string apellido)
        {
            if (string.IsNullOrEmpty(apellido))
                return false;

            // Expresión regular para validar que comience con mayúscula y luego minúsculas
            return Regex.IsMatch(apellido, @"^[A-Z][a-zA-Z]*$");
        }
    }
}
