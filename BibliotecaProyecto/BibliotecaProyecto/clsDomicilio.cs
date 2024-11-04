using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto
{
    public class clsDomicilio:clsPrestamo
    {
        protected static string FechaDevolucion;

        public clsDomicilio(string fecD)
        {
            FechaDevolucion = fecD;
        }

        public override void tipoPrestamo()
        {
            MessageBox.Show("IdPrestamo: " + idprestamo + "\n" +
                "IdLibro: " + idLibro + "\n" +
                "IdUsuario: " + idUsuario + "\n" +
                "Fecha prestamo: " + Fecha + "\n" +
                "Estado: " + Estado + "\n" +
                "Fecha Devolucion" + FechaDevolucion + "\n" +
                "El usuario podra sacar el libro de la biblioteca por el tiempo estipulado",
                " Tipo de Prestamo: Domicilio");
        }
    }
}
