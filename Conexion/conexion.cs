using ProyectoBD.POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoBD.Conexion
{
    internal class conexion
    {
        bool AgregarUsuario(clsUser usuario)
        {

            /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=ProyectoBD; user=root; pwd=root";
            cn.Open();

            /// AGREGAR EL REGISTRO A LA BASE DE DATOS
            string strSQL = "insert into productos (clave, nombre, precio, foto)" +
                " values (@Clave, @Nombre, @precio, @Foto)";
            MySqlCommand comando = new MySqlCommand(strSQL, cn);
            comando.Parameters.AddWithValue("Clave", usuario.Clave);
            comando.Parameters.AddWithValue("Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("Precio", usuario.Precio);
            comando.Parameters.AddWithValue("Foto", usuario.Foto);
            comando.ExecuteNonQuery();

            /// FINALIZAMOS LA CONEXION CERRAMOS TODO
            comando.Dispose();
            cn.Close();
            cn.Dispose();

            return true;
        }

    }
}
