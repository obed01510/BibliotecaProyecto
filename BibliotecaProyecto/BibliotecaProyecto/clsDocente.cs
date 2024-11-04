using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto
{
    public class clsDocente:clsUsuario
    {
        protected static string area;

        public clsDocente (string ar)
        {
            area = ar;
        }

    public override void MensajeRegistro()
    {
        MessageBox.Show("IdUsuario: " + id + "\n" +
            "DNI: " + DNI + "\n" +
            "Nombres: " + nombres + "\n" +
            "Apellidos: " + apellidos + "\n" +
            "Correo: " + correo + "\n" +
            "Telefono: " + telefono + "\n" +
            "Direccion: " + direccion + "\n" +
            "Area: " + area,
            "Docente Registrado ");
    }

}
}
