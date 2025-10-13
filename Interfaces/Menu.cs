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
using ProyectoBD.Conexion;

namespace ProyectoBD.Interfaces
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(String s)
        {
            InitializeComponent();
            lblUser.Text = s;

        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            RegistroUsuarios ru = new RegistroUsuarios();
            this.Hide();
            ru.Show();
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios vu = new VerUsuarios(lblUser.Text);
            this.Hide();
            vu.Show();
        }
    }
}
