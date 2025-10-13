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
using ProyectoBD.Clases;

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
            Validador v = new Validador();
            if (v.validarRegistro(txtNombre.Text, txtApellidos.Text, txtUser.Text, txtPassword.Text, txtCorreo.Text, txtTelefono.Text))
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

        private void chboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chboxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
