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
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaProyectoDataSet);

        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaProyectoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaProyectoDataSet.Usuarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsuarios frmusu = new frmUsuarios(carreraTextBox.Text, anioCursoTextBox.Text); 

            this.Hide();
        }
    }
}
