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
    }
}
