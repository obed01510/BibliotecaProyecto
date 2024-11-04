using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto
{
    public class clsBiblioteca:clsPrestamo
    {
        protected static int horadev;

        public clsBiblioteca(int HD )
        {
            horadev = HD;
        }

        public override void tipoPrestamo()
        {
            MessageBox.Show("IdPrestamo: " + idprestamo + "\n" +
                "IdLibro: " + idLibro + "\n" +
                "IdUsuario: " + idUsuario + "\n" +
                "Fecha prestamo: " + Fecha + "\n" +
                "Estado: " + Estado + "\n" +
                "Hora de Devolucion" + horadev + "\n" +
                "El usuario unicamente podra usar el libro en las intalaciones de la biblioteca",
                "Tipo prestamo: Biblioteca ");
        }
    }
}
