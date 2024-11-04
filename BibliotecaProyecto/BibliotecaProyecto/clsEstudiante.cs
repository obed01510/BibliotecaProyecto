using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto
{
    public class clsEstudiante:clsUsuario
    {

        protected static string carrera;
        protected static string anioCurso;

        public clsEstudiante(string car, string anio)
        {
            carrera = car;
            anioCurso = anio;
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
                "Carrera: " + carrera + "\n" +
                "Año Curso: " + anioCurso,
                "Estudiante Registrado ");
        }

    }
}
