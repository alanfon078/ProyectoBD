using ProyectoBD.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD.Interfaces
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        { 
            
            /*DateTime fechaSeleccionada2 = dtpFechaNacimiento.Value;
            string fechaBD2 = fechaSeleccionada2.ToString("yyyy-MM-dd");
            MessageBox.Show(fechaBD2);*/
            if (txtNombre.Text == "" || txtApellidos.Text == "" || txtUser.Text == "" || txtPassword.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTelefono.Text.Length < 10 || !long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El número de teléfono debe tener al menos 10 dígitos y contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new Clases.Validador().ValidarCorreo(txtCorreo.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido o excede los 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!new Clases.Validador().ValidarContrasena(txtPassword.Text))
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 256 caracteres, incluir al menos una letra mayúscula, un número y un carácter especial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {



                DateTime fechaSeleccionada = dtpFechaNacimiento.Value;
                string fechaBD = fechaSeleccionada.ToString("yyyy-MM-dd");

                Clases.clsUser user = new Clases.clsUser(txtNombre.Text, txtApellidos.Text, txtUser.Text, txtPassword.Text, txtCorreo.Text, txtTelefono.Text, fechaBD);
                conection c = new conection();
                if (c.RegistrarUsuario(user))
                {
                    MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtUser.Clear();
                    txtPassword.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                    dtpFechaNacimiento.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}
