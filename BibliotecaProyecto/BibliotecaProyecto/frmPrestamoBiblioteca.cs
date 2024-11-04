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
    public partial class frmPrestamoBiblioteca : Form
    {
        public frmPrestamoBiblioteca()
        {
            InitializeComponent();
        }

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaProyectoDataSet);

        }

        private void frmPrestamoBiblioteca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.bibliotecaProyectoDataSet.Prestamos);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrestamos frmpre = new frmPrestamos(horaUsoTextBox.Text);
            this.Hide();
        }
    }
}
