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
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaProyectoDataSet);

        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bibliotecaProyectoDataSet.Libros);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            librosBindingSource.AddNew();
            idLibrosTextBox.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsLibro objLib = new clsLibro(int.Parse(idLibrosTextBox.Text), nombreTextBox.Text, autorTextBox.Text, editorialTextBox.Text, anioPublicacionTextBox.Text);
            objLib.Mensaje();
            librosBindingSource.EndEdit();
            librosTableAdapter.Update(bibliotecaProyectoDataSet.Libros);
            librosDataGridView.Refresh();
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
                librosTableAdapter.Delete(int.Parse(idLibrosTextBox.Text));
                bibliotecaProyectoDataSet.Libros.Rows.RemoveAt(librosDataGridView.CurrentCell.RowIndex);
                librosTableAdapter.Update(bibliotecaProyectoDataSet.Libros);
            }
        }
    }
}
