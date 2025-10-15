using ProyectoBD.Clases;
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
    public partial class VerUsuarios : Form
    {
        public VerUsuarios(String s)
        {
            InitializeComponent();
            CargarUsuarios();
            lblUser.Text = s;
        }

        private void CargarUsuarios()
        {
            // Configura el ListView
            listViewUsuarios.View = View.Details;
            listViewUsuarios.GridLines = true;
            listViewUsuarios.FullRowSelect = true;

            listViewUsuarios.Clear();

            // Agregar las columnas
            listViewUsuarios.Columns.Add("USUARIO", 100);
            listViewUsuarios.Columns.Add("NOMBRE", 120);
            listViewUsuarios.Columns.Add("APELLIDOS", 120);
            listViewUsuarios.Columns.Add("EMAIL", 150);
            listViewUsuarios.Columns.Add("ESTATUS", 80);
            listViewUsuarios.Columns.Add("FECHA NACIMIENTO", 100);
            listViewUsuarios.Columns.Add("FECHA DE CREACION", 120);

            conection c = new conection();
            List<clsUser> listaUsuarios = c.ObtenerUsuarios();

            foreach (clsUser usuario in listaUsuarios)
            {
                ListViewItem item = new ListViewItem(usuario.User);
                item.SubItems.Add(usuario.Nombre);
                item.SubItems.Add(usuario.Apellidos);
                item.SubItems.Add(usuario.Correo);
                item.SubItems.Add(usuario.Status ? "Activo" : "Inactivo");
                item.SubItems.Add(usuario.FechaNacimiento);
                item.SubItems.Add(usuario.FechaCreacion); 
                listViewUsuarios.Items.Add(item);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu m = new Menu(lblUser.Text);
            m.Show();
            this.Hide();
        }
    }
}
