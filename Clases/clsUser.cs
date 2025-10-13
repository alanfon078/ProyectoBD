using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.Clases
{
    internal class clsUser
    {

        private string nombre;
        private string apellidos;
        private string user;
        private string password;
        private bool status;
        private string correo;
        private string telefono;
        private string fechaNacimiento;
        private string fechaCreacion;

        public clsUser()
        {
        }

        public clsUser(string nombre, string apellidos, string user, string password, bool status, string correo, string telefono, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.user = user;
            this.password = password;
            this.status = status;
            this.correo = correo;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

        public clsUser(string nombre, string apellidos, string user, string password, string correo, string telefono, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.user = user;
            this.password = password;
            this.correo = correo;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
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

        public string FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

    }
}