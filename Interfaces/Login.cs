using ProyectoBD.Conexion;
using ProyectoBD.Interfaces;

namespace ProyectoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool bLogin = false;
            conection c = new conection();
            bLogin = c.Login(txtUser.Text, txtPassword.Text);

            if (bLogin)
            {
                String s = txtUser.Text;
                Menu menu = new Menu(s);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos", "Error al iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
