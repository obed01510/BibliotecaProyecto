namespace BibliotecaProyecto
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label idTipoUsuarioLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label carreraLabel;
            System.Windows.Forms.Label anioCursoLabel;
            System.Windows.Forms.Label decripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.bibliotecaProyectoDataSet = new BibliotecaProyecto.BibliotecaProyectoDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TableAdapterManager();
            this.tipoUsuariosTableAdapter = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TipoUsuariosTableAdapter();
            this.usuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.idTipoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.carreraTextBox = new System.Windows.Forms.TextBox();
            this.anioCursoTextBox = new System.Windows.Forms.TextBox();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tipoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decripcionComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            idUsuarioLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            idTipoUsuarioLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            carreraLabel = new System.Windows.Forms.Label();
            anioCursoLabel = new System.Windows.Forms.Label();
            decripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).BeginInit();
            this.usuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuariosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(50, 20);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(71, 16);
            idUsuarioLabel.TabIndex = 1;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(50, 48);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(33, 16);
            dNILabel.TabIndex = 3;
            dNILabel.Text = "DNI:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(50, 76);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(66, 16);
            nombresLabel.TabIndex = 5;
            nombresLabel.Text = "Nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(50, 104);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(67, 16);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "Apellidos:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(50, 132);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(51, 16);
            correoLabel.TabIndex = 9;
            correoLabel.Text = "Correo:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(50, 160);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(64, 16);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(50, 188);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(67, 16);
            direccionLabel.TabIndex = 13;
            direccionLabel.Text = "Direccion:";
            // 
            // idTipoUsuarioLabel
            // 
            idTipoUsuarioLabel.AutoSize = true;
            idTipoUsuarioLabel.Location = new System.Drawing.Point(16, 19);
            idTipoUsuarioLabel.Name = "idTipoUsuarioLabel";
            idTipoUsuarioLabel.Size = new System.Drawing.Size(102, 16);
            idTipoUsuarioLabel.TabIndex = 15;
            idTipoUsuarioLabel.Text = "Id Tipo Usuario:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(48, 44);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(39, 16);
            areaLabel.TabIndex = 17;
            areaLabel.Text = "Area:";
            // 
            // carreraLabel
            // 
            carreraLabel.AutoSize = true;
            carreraLabel.Location = new System.Drawing.Point(48, 72);
            carreraLabel.Name = "carreraLabel";
            carreraLabel.Size = new System.Drawing.Size(55, 16);
            carreraLabel.TabIndex = 19;
            carreraLabel.Text = "Carrera:";
            // 
            // anioCursoLabel
            // 
            anioCursoLabel.AutoSize = true;
            anioCursoLabel.Location = new System.Drawing.Point(48, 100);
            anioCursoLabel.Name = "anioCursoLabel";
            anioCursoLabel.Size = new System.Drawing.Size(75, 16);
            anioCursoLabel.TabIndex = 21;
            anioCursoLabel.Text = "Anio Curso:";
            // 
            // decripcionLabel
            // 
            decripcionLabel.AutoSize = true;
            decripcionLabel.Location = new System.Drawing.Point(26, 228);
            decripcionLabel.Name = "decripcionLabel";
            decripcionLabel.Size = new System.Drawing.Size(88, 16);
            decripcionLabel.TabIndex = 31;
            decripcionLabel.Text = "Tipo Usuario:";
            // 
            // bibliotecaProyectoDataSet
            // 
            this.bibliotecaProyectoDataSet.DataSetName = "BibliotecaProyectoDataSet";
            this.bibliotecaProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bibliotecaProyectoDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibrosTableAdapter = null;
            this.tableAdapterManager.PrestamosTableAdapter = null;
            this.tableAdapterManager.TipoPrestamosTableAdapter = null;
            this.tableAdapterManager.TipoUsuariosTableAdapter = this.tipoUsuariosTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // tipoUsuariosTableAdapter
            // 
            this.tipoUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingNavigator
            // 
            this.usuariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuariosBindingNavigator.BindingSource = this.usuariosBindingSource;
            this.usuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuariosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usuariosBindingNavigatorSaveItem});
            this.usuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuariosBindingNavigator.Name = "usuariosBindingNavigator";
            this.usuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuariosBindingNavigator.Size = new System.Drawing.Size(1521, 27);
            this.usuariosBindingNavigator.TabIndex = 0;
            this.usuariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // usuariosBindingNavigatorSaveItem
            // 
            this.usuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosBindingNavigatorSaveItem.Image")));
            this.usuariosBindingNavigatorSaveItem.Name = "usuariosBindingNavigatorSaveItem";
            this.usuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.usuariosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.usuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuariosBindingNavigatorSaveItem_Click);
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(158, 17);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.idUsuarioTextBox.TabIndex = 2;
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(158, 45);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(100, 22);
            this.dNITextBox.TabIndex = 4;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(158, 73);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombresTextBox.TabIndex = 6;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(158, 101);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 22);
            this.apellidosTextBox.TabIndex = 8;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(158, 129);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 22);
            this.correoTextBox.TabIndex = 10;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(158, 157);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 22);
            this.telefonoTextBox.TabIndex = 12;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(158, 185);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 22);
            this.direccionTextBox.TabIndex = 14;
            // 
            // idTipoUsuarioTextBox
            // 
            this.idTipoUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdTipoUsuario", true));
            this.idTipoUsuarioTextBox.Location = new System.Drawing.Point(158, 13);
            this.idTipoUsuarioTextBox.Name = "idTipoUsuarioTextBox";
            this.idTipoUsuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTipoUsuarioTextBox.TabIndex = 16;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Area", true));
            this.areaTextBox.Location = new System.Drawing.Point(156, 41);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 22);
            this.areaTextBox.TabIndex = 18;
            // 
            // carreraTextBox
            // 
            this.carreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Carrera", true));
            this.carreraTextBox.Location = new System.Drawing.Point(156, 69);
            this.carreraTextBox.Name = "carreraTextBox";
            this.carreraTextBox.Size = new System.Drawing.Size(100, 22);
            this.carreraTextBox.TabIndex = 20;
            // 
            // anioCursoTextBox
            // 
            this.anioCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "AnioCurso", true));
            this.anioCursoTextBox.Location = new System.Drawing.Point(156, 97);
            this.anioCursoTextBox.Name = "anioCursoTextBox";
            this.anioCursoTextBox.Size = new System.Drawing.Size(100, 22);
            this.anioCursoTextBox.TabIndex = 22;
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Location = new System.Drawing.Point(328, 64);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.RowHeadersWidth = 51;
            this.usuariosDataGridView.RowTemplate.Height = 24;
            this.usuariosDataGridView.Size = new System.Drawing.Size(1181, 220);
            this.usuariosDataGridView.TabIndex = 23;
            this.usuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn2.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellidos";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdTipoUsuario";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdTipoUsuario";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn9.HeaderText = "Area";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Carrera";
            this.dataGridViewTextBoxColumn10.HeaderText = "Carrera";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AnioCurso";
            this.dataGridViewTextBoxColumn11.HeaderText = "AnioCurso";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(49, 43);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(177, 43);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(309, 43);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(448, 43);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tipoUsuariosBindingSource
            // 
            this.tipoUsuariosBindingSource.DataMember = "TipoUsuarios";
            this.tipoUsuariosBindingSource.DataSource = this.bibliotecaProyectoDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(decripcionLabel);
            this.panel1.Controls.Add(this.decripcionComboBox);
            this.panel1.Controls.Add(idUsuarioLabel);
            this.panel1.Controls.Add(this.idUsuarioTextBox);
            this.panel1.Controls.Add(dNILabel);
            this.panel1.Controls.Add(this.dNITextBox);
            this.panel1.Controls.Add(nombresLabel);
            this.panel1.Controls.Add(this.nombresTextBox);
            this.panel1.Controls.Add(apellidosLabel);
            this.panel1.Controls.Add(this.apellidosTextBox);
            this.panel1.Controls.Add(correoLabel);
            this.panel1.Controls.Add(this.correoTextBox);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 410);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(areaLabel);
            this.panel2.Controls.Add(this.idTipoUsuarioTextBox);
            this.panel2.Controls.Add(idTipoUsuarioLabel);
            this.panel2.Controls.Add(this.areaTextBox);
            this.panel2.Controls.Add(carreraLabel);
            this.panel2.Controls.Add(this.carreraTextBox);
            this.panel2.Controls.Add(anioCursoLabel);
            this.panel2.Controls.Add(this.anioCursoTextBox);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(3, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 130);
            this.panel2.TabIndex = 33;
            // 
            // decripcionComboBox
            // 
            this.decripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoUsuariosBindingSource, "Decripcion", true));
            this.decripcionComboBox.DataSource = this.tipoUsuariosBindingSource;
            this.decripcionComboBox.DisplayMember = "Decripcion";
            this.decripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decripcionComboBox.FormattingEnabled = true;
            this.decripcionComboBox.Location = new System.Drawing.Point(135, 225);
            this.decripcionComboBox.Name = "decripcionComboBox";
            this.decripcionComboBox.Size = new System.Drawing.Size(121, 24);
            this.decripcionComboBox.TabIndex = 32;
            this.decripcionComboBox.UseWaitCursor = true;
            this.decripcionComboBox.ValueMember = "IdTipoUsuarios";
            this.decripcionComboBox.SelectedIndexChanged += new System.EventHandler(this.decripcionComboBox_SelectedIndexChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegresar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.btnAdicionar);
            this.panel3.Location = new System.Drawing.Point(392, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 98);
            this.panel3.TabIndex = 32;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(560, 43);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.usuariosBindingNavigator);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).EndInit();
            this.usuariosBindingNavigator.ResumeLayout(false);
            this.usuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuariosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaProyectoDataSet bibliotecaProyectoDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BibliotecaProyectoDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private BibliotecaProyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usuariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox idTipoUsuarioTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox carreraTextBox;
        private System.Windows.Forms.TextBox anioCursoTextBox;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private BibliotecaProyectoDataSetTableAdapters.TipoUsuariosTableAdapter tipoUsuariosTableAdapter;
        private System.Windows.Forms.BindingSource tipoUsuariosBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox decripcionComboBox;
    }
}