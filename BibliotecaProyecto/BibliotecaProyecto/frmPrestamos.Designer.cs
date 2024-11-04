namespace BibliotecaProyecto
{
    partial class frmPrestamos
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
            System.Windows.Forms.Label idPrestamosLabel;
            System.Windows.Forms.Label idLibroLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label idTipoPrestamoLabel;
            System.Windows.Forms.Label horaUsoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaDevolucionLabel1;
            System.Windows.Forms.Label fechaPrestamoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            this.bibliotecaProyectoDataSet = new BibliotecaProyecto.BibliotecaProyectoDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TableAdapterManager();
            this.prestamosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prestamosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPrestamosTextBox = new System.Windows.Forms.TextBox();
            this.idLibroTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.idTipoPrestamoTextBox = new System.Windows.Forms.TextBox();
            this.horaUsoTextBox = new System.Windows.Forms.TextBox();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panelPrestamo1 = new System.Windows.Forms.Panel();
            this.fechaPrestamoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionComboBox = new System.Windows.Forms.ComboBox();
            this.tipoPrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.fechaDevolucionTextBox = new System.Windows.Forms.TextBox();
            this.tipoPrestamosTableAdapter = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TipoPrestamosTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            idPrestamosLabel = new System.Windows.Forms.Label();
            idLibroLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            idTipoPrestamoLabel = new System.Windows.Forms.Label();
            horaUsoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaDevolucionLabel1 = new System.Windows.Forms.Label();
            fechaPrestamoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingNavigator)).BeginInit();
            this.prestamosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            this.panelPrestamo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPrestamosBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPrestamosLabel
            // 
            idPrestamosLabel.AutoSize = true;
            idPrestamosLabel.Location = new System.Drawing.Point(13, 23);
            idPrestamosLabel.Name = "idPrestamosLabel";
            idPrestamosLabel.Size = new System.Drawing.Size(89, 16);
            idPrestamosLabel.TabIndex = 1;
            idPrestamosLabel.Text = "Id Prestamos:";
            // 
            // idLibroLabel
            // 
            idLibroLabel.AutoSize = true;
            idLibroLabel.Location = new System.Drawing.Point(13, 51);
            idLibroLabel.Name = "idLibroLabel";
            idLibroLabel.Size = new System.Drawing.Size(54, 16);
            idLibroLabel.TabIndex = 3;
            idLibroLabel.Text = "Id Libro:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(13, 79);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(71, 16);
            idUsuarioLabel.TabIndex = 5;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(13, 135);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(53, 16);
            estadoLabel.TabIndex = 9;
            estadoLabel.Text = "Estado:";
            // 
            // idTipoPrestamoLabel
            // 
            idTipoPrestamoLabel.AutoSize = true;
            idTipoPrestamoLabel.Location = new System.Drawing.Point(19, 12);
            idTipoPrestamoLabel.Name = "idTipoPrestamoLabel";
            idTipoPrestamoLabel.Size = new System.Drawing.Size(113, 16);
            idTipoPrestamoLabel.TabIndex = 11;
            idTipoPrestamoLabel.Text = "Id Tipo Prestamo:";
            // 
            // horaUsoLabel
            // 
            horaUsoLabel.AutoSize = true;
            horaUsoLabel.Location = new System.Drawing.Point(13, 31);
            horaUsoLabel.Name = "horaUsoLabel";
            horaUsoLabel.Size = new System.Drawing.Size(68, 16);
            horaUsoLabel.TabIndex = 13;
            horaUsoLabel.Text = "Hora Uso:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(50, 167);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(82, 16);
            descripcionLabel.TabIndex = 17;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaDevolucionLabel1
            // 
            fechaDevolucionLabel1.AutoSize = true;
            fechaDevolucionLabel1.Location = new System.Drawing.Point(13, 64);
            fechaDevolucionLabel1.Name = "fechaDevolucionLabel1";
            fechaDevolucionLabel1.Size = new System.Drawing.Size(119, 16);
            fechaDevolucionLabel1.TabIndex = 18;
            fechaDevolucionLabel1.Text = "Fecha Devolucion:";
            // 
            // fechaPrestamoLabel
            // 
            fechaPrestamoLabel.AutoSize = true;
            fechaPrestamoLabel.Location = new System.Drawing.Point(17, 107);
            fechaPrestamoLabel.Name = "fechaPrestamoLabel";
            fechaPrestamoLabel.Size = new System.Drawing.Size(109, 16);
            fechaPrestamoLabel.TabIndex = 18;
            fechaPrestamoLabel.Text = "Fecha Prestamo:";
            // 
            // bibliotecaProyectoDataSet
            // 
            this.bibliotecaProyectoDataSet.DataSetName = "BibliotecaProyectoDataSet";
            this.bibliotecaProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.bibliotecaProyectoDataSet;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibrosTableAdapter = null;
            this.tableAdapterManager.PrestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager.TipoPrestamosTableAdapter = null;
            this.tableAdapterManager.TipoUsuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // prestamosBindingNavigator
            // 
            this.prestamosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prestamosBindingNavigator.BindingSource = this.prestamosBindingSource;
            this.prestamosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prestamosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prestamosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.prestamosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prestamosBindingNavigatorSaveItem});
            this.prestamosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prestamosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prestamosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prestamosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prestamosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prestamosBindingNavigator.Name = "prestamosBindingNavigator";
            this.prestamosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prestamosBindingNavigator.Size = new System.Drawing.Size(1478, 27);
            this.prestamosBindingNavigator.TabIndex = 0;
            this.prestamosBindingNavigator.Text = "bindingNavigator1";
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
            // prestamosBindingNavigatorSaveItem
            // 
            this.prestamosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prestamosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prestamosBindingNavigatorSaveItem.Image")));
            this.prestamosBindingNavigatorSaveItem.Name = "prestamosBindingNavigatorSaveItem";
            this.prestamosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.prestamosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.prestamosBindingNavigatorSaveItem.Click += new System.EventHandler(this.prestamosBindingNavigatorSaveItem_Click);
            // 
            // idPrestamosTextBox
            // 
            this.idPrestamosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "IdPrestamos", true));
            this.idPrestamosTextBox.Location = new System.Drawing.Point(138, 20);
            this.idPrestamosTextBox.Name = "idPrestamosTextBox";
            this.idPrestamosTextBox.Size = new System.Drawing.Size(200, 22);
            this.idPrestamosTextBox.TabIndex = 2;
            // 
            // idLibroTextBox
            // 
            this.idLibroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "IdLibro", true));
            this.idLibroTextBox.Location = new System.Drawing.Point(138, 48);
            this.idLibroTextBox.Name = "idLibroTextBox";
            this.idLibroTextBox.Size = new System.Drawing.Size(200, 22);
            this.idLibroTextBox.TabIndex = 4;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(138, 76);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(200, 22);
            this.idUsuarioTextBox.TabIndex = 6;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(138, 132);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(200, 22);
            this.estadoTextBox.TabIndex = 10;
            // 
            // idTipoPrestamoTextBox
            // 
            this.idTipoPrestamoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "IdTipoPrestamo", true));
            this.idTipoPrestamoTextBox.Location = new System.Drawing.Point(138, 3);
            this.idTipoPrestamoTextBox.Name = "idTipoPrestamoTextBox";
            this.idTipoPrestamoTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTipoPrestamoTextBox.TabIndex = 12;
            // 
            // horaUsoTextBox
            // 
            this.horaUsoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "HoraUso", true));
            this.horaUsoTextBox.Location = new System.Drawing.Point(138, 31);
            this.horaUsoTextBox.Name = "horaUsoTextBox";
            this.horaUsoTextBox.Size = new System.Drawing.Size(200, 22);
            this.horaUsoTextBox.TabIndex = 14;
            // 
            // prestamosDataGridView
            // 
            this.prestamosDataGridView.AutoGenerateColumns = false;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.prestamosDataGridView.DataSource = this.prestamosBindingSource;
            this.prestamosDataGridView.Location = new System.Drawing.Point(467, 55);
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            this.prestamosDataGridView.RowHeadersWidth = 51;
            this.prestamosDataGridView.RowTemplate.Height = 24;
            this.prestamosDataGridView.Size = new System.Drawing.Size(974, 220);
            this.prestamosDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPrestamos";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPrestamos";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdLibro";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdLibro";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaPrestamo";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaPrestamo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdTipoPrestamo";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdTipoPrestamo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HoraUso";
            this.dataGridViewTextBoxColumn7.HeaderText = "HoraUso";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FechaDevolucion";
            this.dataGridViewTextBoxColumn8.HeaderText = "FechaDevolucion";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(455, 376);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panelPrestamo1
            // 
            this.panelPrestamo1.Controls.Add(fechaPrestamoLabel);
            this.panelPrestamo1.Controls.Add(this.fechaPrestamoTextBox);
            this.panelPrestamo1.Controls.Add(descripcionLabel);
            this.panelPrestamo1.Controls.Add(this.descripcionComboBox);
            this.panelPrestamo1.Controls.Add(this.panel2);
            this.panelPrestamo1.Controls.Add(idPrestamosLabel);
            this.panelPrestamo1.Controls.Add(this.idPrestamosTextBox);
            this.panelPrestamo1.Controls.Add(idLibroLabel);
            this.panelPrestamo1.Controls.Add(this.idLibroTextBox);
            this.panelPrestamo1.Controls.Add(idUsuarioLabel);
            this.panelPrestamo1.Controls.Add(this.idUsuarioTextBox);
            this.panelPrestamo1.Controls.Add(estadoLabel);
            this.panelPrestamo1.Controls.Add(this.estadoTextBox);
            this.panelPrestamo1.Location = new System.Drawing.Point(11, 35);
            this.panelPrestamo1.Name = "panelPrestamo1";
            this.panelPrestamo1.Size = new System.Drawing.Size(419, 347);
            this.panelPrestamo1.TabIndex = 19;
            this.panelPrestamo1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrestamo1_Paint);
            // 
            // fechaPrestamoTextBox
            // 
            this.fechaPrestamoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "FechaPrestamo", true));
            this.fechaPrestamoTextBox.Location = new System.Drawing.Point(138, 104);
            this.fechaPrestamoTextBox.Name = "fechaPrestamoTextBox";
            this.fechaPrestamoTextBox.Size = new System.Drawing.Size(200, 22);
            this.fechaPrestamoTextBox.TabIndex = 19;
            // 
            // descripcionComboBox
            // 
            this.descripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoPrestamosBindingSource, "Descripcion", true));
            this.descripcionComboBox.DataSource = this.tipoPrestamosBindingSource;
            this.descripcionComboBox.DisplayMember = "Descripcion";
            this.descripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descripcionComboBox.FormattingEnabled = true;
            this.descripcionComboBox.Location = new System.Drawing.Point(138, 164);
            this.descripcionComboBox.Name = "descripcionComboBox";
            this.descripcionComboBox.Size = new System.Drawing.Size(121, 24);
            this.descripcionComboBox.TabIndex = 18;
            this.descripcionComboBox.ValueMember = "IdTipoPrestamo";
            this.descripcionComboBox.SelectedIndexChanged += new System.EventHandler(this.descripcionComboBox_SelectedIndexChanged);
            // 
            // tipoPrestamosBindingSource
            // 
            this.tipoPrestamosBindingSource.DataMember = "TipoPrestamos";
            this.tipoPrestamosBindingSource.DataSource = this.bibliotecaProyectoDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(fechaDevolucionLabel1);
            this.panel2.Controls.Add(idTipoPrestamoLabel);
            this.panel2.Controls.Add(this.fechaDevolucionTextBox);
            this.panel2.Controls.Add(this.idTipoPrestamoTextBox);
            this.panel2.Controls.Add(horaUsoLabel);
            this.panel2.Controls.Add(this.horaUsoTextBox);
            this.panel2.Location = new System.Drawing.Point(29, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 86);
            this.panel2.TabIndex = 17;
            // 
            // fechaDevolucionTextBox
            // 
            this.fechaDevolucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "FechaDevolucion", true));
            this.fechaDevolucionTextBox.Location = new System.Drawing.Point(138, 61);
            this.fechaDevolucionTextBox.Name = "fechaDevolucionTextBox";
            this.fechaDevolucionTextBox.Size = new System.Drawing.Size(200, 22);
            this.fechaDevolucionTextBox.TabIndex = 19;
            // 
            // tipoPrestamosTableAdapter
            // 
            this.tipoPrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(552, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(651, 376);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(745, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelPrestamo1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.prestamosDataGridView);
            this.Controls.Add(this.prestamosBindingNavigator);
            this.Name = "frmPrestamos";
            this.Text = "frmPrestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingNavigator)).EndInit();
            this.prestamosBindingNavigator.ResumeLayout(false);
            this.prestamosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            this.panelPrestamo1.ResumeLayout(false);
            this.panelPrestamo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPrestamosBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaProyectoDataSet bibliotecaProyectoDataSet;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private BibliotecaProyectoDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private BibliotecaProyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prestamosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prestamosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idPrestamosTextBox;
        private System.Windows.Forms.TextBox idLibroTextBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox idTipoPrestamoTextBox;
        private System.Windows.Forms.TextBox horaUsoTextBox;
        private System.Windows.Forms.DataGridView prestamosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panelPrestamo1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tipoPrestamosBindingSource;
        private BibliotecaProyectoDataSetTableAdapters.TipoPrestamosTableAdapter tipoPrestamosTableAdapter;
        private System.Windows.Forms.ComboBox descripcionComboBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox fechaDevolucionTextBox;
        private System.Windows.Forms.TextBox fechaPrestamoTextBox;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEliminar;
    }
}