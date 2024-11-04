using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class clsPrestamo
    {
        protected static int idprestamo;
        protected static int idLibro;
        protected static int idUsuario;
        private static string fecha;
        private static string estado;
        private static int idtipoprestamo;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int IdTipoPrestamo
        {
            get { return idtipoprestamo; }
            set { idtipoprestamo = value; }
        }

        public clsPrestamo() { }
        public clsPrestamo(int id_, int idlib, int idusu, string fe, string es, int idtipo)
        {
            idprestamo = id_;
            idLibro = idlib;
            idUsuario = idusu;
            fecha = fe;
            estado = es;
            idtipoprestamo = idtipo;    
        }

        public virtual void tipoPrestamo()
        {

        }
    }
}
