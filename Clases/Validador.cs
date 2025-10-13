using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProyectoBD.Clases
{
        public class Validador
        {
            private const int MaxLongitudCorreo = 50;
            private const int MaxLongitudContrasena = 256;
            
            
            // Expresión regular para validar correo electrónico
            private static readonly Regex EmailRegex = new Regex(
            @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant
            );
            
            
            // Expresión regular para validar contraseñas:
            // - Mínimo 8 caracteres
            // - Máximo 256 caracteres
            // - Al menos una letra mayúscula
            // - Al menos un número
            // - Al menos un carácter especial
            private static readonly Regex PasswordRegex = new Regex(
            @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,256}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant
            );

            
            
            /// Valida si un correo electrónico tiene un formato correcto y no excede los 50 caracteres
            public bool ValidarCorreo(string email)
            {
                if (string.IsNullOrWhiteSpace(email)) return false;
                if (email.Length > MaxLongitudCorreo) return false;
                return EmailRegex.IsMatch(email);
            }
            
            
            /// Valida si una contraseña cumple con los requisitos mínimos:
            /// 8 caracteres, 1 mayúscula, 1 número, 1 carácter especial y máximo 256 caracteres
            public bool ValidarContrasena(string password)
            {   
                if (string.IsNullOrEmpty(password)) return false;
                if (password.Length > MaxLongitudContrasena) return false;
                return PasswordRegex.IsMatch(password);
            }

    }

}
