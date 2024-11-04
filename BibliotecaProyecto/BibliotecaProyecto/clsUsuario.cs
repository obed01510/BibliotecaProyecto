using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class clsUsuario
    {
        protected static int id;
        protected static string DNI;
        protected static string nombres;
        protected static string apellidos;
        protected static string correo;
        protected static string telefono;
        protected static string direccion;
        protected static int idTipoUsuario;

        public clsUsuario() { }
        public clsUsuario(int id_, string DNI_, string nom, string ape, string cor, string tel, string dir, int idTipo)
        {
            id = id_;
            DNI = DNI_;
            nombres = nom;
            apellidos = ape;
            correo = cor;
            telefono = tel;
            direccion = dir;
            idTipoUsuario = idTipo;
        }

        public virtual void MensajeRegistro()
        {

        }
    }
}
