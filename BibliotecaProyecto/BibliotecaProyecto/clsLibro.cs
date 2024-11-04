using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto
{
    public class clsLibro
    {
        public int id;
        public string nombre;
        public string autor;
        public string editorial;
        public string aniopubliucacion;


        public clsLibro(int id, string nom, string aut, string edi, string anio)
        {
            this.id = id;
            nombre = nom;
            autor = aut;
            editorial = edi;
            aniopubliucacion = anio;
        }

        public void Mensaje()
        {
            MessageBox.Show("Id: " + id + "\n" +
                "Nombre: " + nombre + "\n" +
                "Autor: " + autor + "\n" +
                "Editorial: " + editorial + "\n" +
                "Año de publicacion: " + aniopubliucacion,
                "Libro Registrado");
        }
    }
}

