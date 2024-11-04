using BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters;
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
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaProyectoDataSet);

        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.TipoPrestamos' Puede moverla o quitarla según sea necesario.
            this.tipoPrestamosTableAdapter.Fill(this.bibliotecaProyectoDataSet.TipoPrestamos);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.bibliotecaProyectoDataSet.Prestamos);

        }
        public frmPrestamos(string atributo)
        {
            InitializeComponent();
            atri = atributo;
        }
      
        public static string atri;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            prestamosBindingSource.AddNew();
            idPrestamosTextBox.Focus();
            panelPrestamo1.Enabled = true;
        }

        private void panelPrestamo1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (descripcionComboBox.SelectedIndex == 0)
            {
                clsDomicilio objdoc = new clsDomicilio(atri);
                fechaDevolucionTextBox.Text = atri;
                objdoc.tipoPrestamo();
            }
            if (descripcionComboBox.SelectedIndex == 1)
            {
                clsBiblioteca objbib = new clsBiblioteca(int.Parse(atri));
                horaUsoTextBox.Text = atri;
                objbib.tipoPrestamo();
            }
            prestamosBindingSource.EndEdit();
            prestamosTableAdapter.Update(bibliotecaProyectoDataSet.Prestamos);
            prestamosDataGridView.Refresh();
        }

        private void descripcionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipoPrestamoTextBox.Text = (descripcionComboBox.SelectedIndex + 1).ToString();

            clsPrestamo objprest = new clsPrestamo(int.Parse(idPrestamosTextBox.Text.ToString()), int.Parse(idLibroTextBox.Text.ToString()), int.Parse(idUsuarioTextBox.Text), fechaPrestamoTextBox.Text, estadoTextBox.Text,int.Parse( idTipoPrestamoTextBox.Text));
            if (descripcionComboBox.SelectedIndex == 0)
            {
                frmPrestamoDomicilio objdoc = new frmPrestamoDomicilio();
                objdoc.ShowDialog(); ;

            }
            else if (descripcionComboBox.SelectedIndex == 1)
            {
                frmPrestamoBiblioteca objbib = new frmPrestamoBiblioteca();
                objbib.ShowDialog(); ;


            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Borrar Registro ",
             MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                prestamosTableAdapter.Delete(int.Parse(idPrestamosTextBox.Text));
                bibliotecaProyectoDataSet.Prestamos.Rows.RemoveAt(prestamosDataGridView.CurrentCell.RowIndex);
                prestamosTableAdapter.Update(bibliotecaProyectoDataSet.Prestamos);
            }
        }
    }
}
