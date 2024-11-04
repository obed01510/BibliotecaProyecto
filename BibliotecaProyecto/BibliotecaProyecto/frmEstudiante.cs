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
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usuariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bibliotecaProyectoDataSet);
                MessageBox.Show("Datos guardados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaProyectoDataSet.Usuarios);

            // Llama al método de prueba de conexión al cargar el formulario
            TestConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsuarios frmusu = new frmUsuarios(carreraTextBox.Text, anioCursoTextBox.Text);
            this.Hide();
        }

        private void TestConnection()
        {
            try
            {
                using (var connection = new System.Data.OleDb.OleDbConnection(Properties.Settings.Default.BibliotecaProyectoConnectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}");
            }
        }
    }
}
