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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaProyectoDataSet);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.TipoUsuarios' Puede moverla o quitarla según sea necesario.
            this.tipoUsuariosTableAdapter.Fill(this.bibliotecaProyectoDataSet.TipoUsuarios);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaProyectoDataSet.Usuarios);

        }
        public frmUsuarios(string area)
        {
            InitializeComponent();
            ar = area;
        }
        public frmUsuarios(string carrera, string aniocurso )
        {
            InitializeComponent();
            car = carrera;
            anio = aniocurso;
        }
        public static string ar, car, anio;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.AddNew();
            idUsuarioTextBox.Focus();
            decripcionComboBox.SelectedIndex = -1;
            panel1.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Borrar Registro ",
             MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usuariosTableAdapter.Delete(int.Parse(idUsuarioTextBox.Text));
                bibliotecaProyectoDataSet.Usuarios.Rows.RemoveAt(usuariosDataGridView.CurrentCell.RowIndex);
                usuariosTableAdapter.Update(bibliotecaProyectoDataSet.Usuarios);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (decripcionComboBox.SelectedIndex == 0)
            {
                clsDocente objdoc = new clsDocente(ar);
                objdoc.MensajeRegistro();
                areaTextBox.Text = ar;
            }
            if (decripcionComboBox.SelectedIndex == 1)
            {
                clsEstudiante objest = new clsEstudiante(car, anio);
                objest.MensajeRegistro();
                carreraTextBox.Text = car;
                anioCursoTextBox.Text = anio;
            }
            usuariosBindingSource.EndEdit();
            usuariosTableAdapter.Update(bibliotecaProyectoDataSet.Usuarios);
            usuariosDataGridView.Refresh();

            panel1.Enabled = false;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void decripcionComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idTipoUsuarioTextBox.Text=(decripcionComboBox.SelectedIndex+1).ToString();

            clsUsuario objusu = new clsUsuario(int.Parse(idUsuarioTextBox.Text.ToString()), dNITextBox.Text, nombresTextBox.Text, apellidosTextBox.Text, correoTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, int.Parse(idTipoUsuarioTextBox.Text.ToString()));
            if (decripcionComboBox.SelectedIndex == 0)
            { 
                frmDocente objDoc = new frmDocente();
                objDoc.ShowDialog(); ;

            }
            else if (decripcionComboBox.SelectedIndex == 1)
            {
                frmEstudiante objEst = new frmEstudiante();
                objEst.ShowDialog(); ;


            }

            
        }

        private void usuariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void decripcionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { }
            

        private void decripcionLabel_Click(object sender, EventArgs e)
        { }
        
    }
}
