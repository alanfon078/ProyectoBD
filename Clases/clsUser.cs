using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.POJO
{
    internal class clsUser
    {

        private int id;
        private string nombre;
        private string apellidos;
        private string user;
        private string password;
        private bool status;
        private string correo;
        private string telefono;
        private string fechaNacimiento;

        public clsUser(string nombre, string apellidos, string user, string password, bool status, string correo, string telefono, string fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.User = user;
            this.Password = password;
            this.Status = status;
            this.Correo = correo;
            this.Telefono = telefono;
            this.FechaNacimiento = fechaNacimiento;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

    }
}
