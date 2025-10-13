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

        public bool validarRegistro(String Nombre, String Apellidos, String User, String Password, String Correo, String Telefono)
        {
            bool esValido = false;

            Conexion.conection cn = new Conexion.conection();

            if (Nombre == "" || Apellidos == "" || User == "" || Password == "" || Correo == "" || Telefono == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Nombre.Length > 50 || Apellidos.Length > 50 || User.Length > 50)
            {
                MessageBox.Show("El nombre, apellidos o usuario exceden los caracteres permitidos. nombre(50), apellidos(100), usuario(20)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cn.ValidarUsuario(User) == false)
            {
                MessageBox.Show("El usuario no se encuentra disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Telefono.Length < 10 || !long.TryParse(Telefono, out _))
            {
                MessageBox.Show("El número de teléfono debe tener al menos 10 dígitos y contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new Clases.Validador().ValidarCorreo(Correo))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido o excede los 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new Clases.Validador().ValidarContrasena(Password))
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 256 caracteres, incluir al menos una letra mayúscula, un número y un carácter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                esValido = true;
            }

            return esValido;
        }

    }

}
