using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsu = new frmUsuarios();
            frmUsu.ShowDialog();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            frmLibro frmlib = new frmLibro();
            frmlib.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamos frmPre = new frmPrestamos();
            frmPre.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
