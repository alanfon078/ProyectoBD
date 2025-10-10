using ProyectoBD.Conexion;
using MySql.Data.MySqlClient;
using ProyectoBD.Interfaces;

namespace ProyectoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool bLogin = false;
            conection c = new conection();
            bLogin = c.Login(txtUser.Text, txtPassword.Text);

            if (bLogin)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos");
            }
        }

        /*private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsUser producto = new clsUser();
            // LECTURA DE DATOS
            producto.Clave = Convert.ToInt32(txtClave.Text);
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDouble(txtPrecio.Text);
            producto.Foto = "foto" + producto.Clave + ".jpg";

            // FUNCIONES DE VALIDACIÓN


            // GUARDAR LA INFORMACIÓN
            clsDaoProductos objProducto = new clsDaoProductos();
            if (objProducto.AgregarUsuario(producto))
            {
                MessageBox.Show("Producto almacenado correctamente");
            }

        }*/

    }
}
