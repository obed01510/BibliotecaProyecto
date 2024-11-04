namespace BibliotecaProyecto
{
    partial class frmLibro
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
            System.Windows.Forms.Label idLibrosLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label editorialLabel;
            System.Windows.Forms.Label anioPublicacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibro));
            this.bibliotecaProyectoDataSet = new BibliotecaProyecto.BibliotecaProyectoDataSet();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TableAdapterManager();
            this.librosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.librosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLibrosTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editorialTextBox = new System.Windows.Forms.TextBox();
            this.anioPublicacionTextBox = new System.Windows.Forms.TextBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLibros = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            idLibrosLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            editorialLabel = new System.Windows.Forms.Label();
            anioPublicacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingNavigator)).BeginInit();
            this.librosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.panelLibros.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLibrosLabel
            // 
            idLibrosLabel.AutoSize = true;
            idLibrosLabel.Location = new System.Drawing.Point(15, 20);
            idLibrosLabel.Name = "idLibrosLabel";
            idLibrosLabel.Size = new System.Drawing.Size(61, 16);
            idLibrosLabel.TabIndex = 1;
            idLibrosLabel.Text = "Id Libros:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(15, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(15, 76);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(41, 16);
            autorLabel.TabIndex = 5;
            autorLabel.Text = "Autor:";
            // 
            // editorialLabel
            // 
            editorialLabel.AutoSize = true;
            editorialLabel.Location = new System.Drawing.Point(15, 104);
            editorialLabel.Name = "editorialLabel";
            editorialLabel.Size = new System.Drawing.Size(59, 16);
            editorialLabel.TabIndex = 7;
            editorialLabel.Text = "Editorial:";
            // 
            // anioPublicacionLabel
            // 
            anioPublicacionLabel.AutoSize = true;
            anioPublicacionLabel.Location = new System.Drawing.Point(15, 132);
            anioPublicacionLabel.Name = "anioPublicacionLabel";
            anioPublicacionLabel.Size = new System.Drawing.Size(110, 16);
            anioPublicacionLabel.TabIndex = 9;
            anioPublicacionLabel.Text = "Anio Publicacion:";
            // 
            // bibliotecaProyectoDataSet
            // 
            this.bibliotecaProyectoDataSet.DataSetName = "BibliotecaProyectoDataSet";
            this.bibliotecaProyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bibliotecaProyectoDataSet;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibrosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.PrestamosTableAdapter = null;
            this.tableAdapterManager.TipoPrestamosTableAdapter = null;
            this.tableAdapterManager.TipoUsuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // librosBindingNavigator
            // 
            this.librosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.librosBindingNavigator.BindingSource = this.librosBindingSource;
            this.librosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.librosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.librosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.librosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.librosBindingNavigatorSaveItem});
            this.librosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.librosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.librosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.librosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.librosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.librosBindingNavigator.Name = "librosBindingNavigator";
            this.librosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.librosBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.librosBindingNavigator.TabIndex = 0;
            this.librosBindingNavigator.Text = "bindingNavigator1";
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
            // librosBindingNavigatorSaveItem
            // 
            this.librosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.librosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("librosBindingNavigatorSaveItem.Image")));
            this.librosBindingNavigatorSaveItem.Name = "librosBindingNavigatorSaveItem";
            this.librosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.librosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.librosBindingNavigatorSaveItem.Click += new System.EventHandler(this.librosBindingNavigatorSaveItem_Click);
            // 
            // idLibrosTextBox
            // 
            this.idLibrosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "IdLibros", true));
            this.idLibrosTextBox.Location = new System.Drawing.Point(131, 17);
            this.idLibrosTextBox.Name = "idLibrosTextBox";
            this.idLibrosTextBox.Size = new System.Drawing.Size(100, 22);
            this.idLibrosTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(131, 45);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(131, 73);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(100, 22);
            this.autorTextBox.TabIndex = 6;
            // 
            // editorialTextBox
            // 
            this.editorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Editorial", true));
            this.editorialTextBox.Location = new System.Drawing.Point(131, 101);
            this.editorialTextBox.Name = "editorialTextBox";
            this.editorialTextBox.Size = new System.Drawing.Size(100, 22);
            this.editorialTextBox.TabIndex = 8;
            // 
            // anioPublicacionTextBox
            // 
            this.anioPublicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "AnioPublicacion", true));
            this.anioPublicacionTextBox.Location = new System.Drawing.Point(131, 129);
            this.anioPublicacionTextBox.Name = "anioPublicacionTextBox";
            this.anioPublicacionTextBox.Size = new System.Drawing.Size(100, 22);
            this.anioPublicacionTextBox.TabIndex = 10;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(327, 62);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.RowHeadersWidth = 51;
            this.librosDataGridView.RowTemplate.Height = 24;
            this.librosDataGridView.Size = new System.Drawing.Size(461, 220);
            this.librosDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLibros";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdLibros";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Editorial";
            this.dataGridViewTextBoxColumn4.HeaderText = "Editorial";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AnioPublicacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "AnioPublicacion";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // panelLibros
            // 
            this.panelLibros.Controls.Add(idLibrosLabel);
            this.panelLibros.Controls.Add(this.idLibrosTextBox);
            this.panelLibros.Controls.Add(nombreLabel);
            this.panelLibros.Controls.Add(this.nombreTextBox);
            this.panelLibros.Controls.Add(autorLabel);
            this.panelLibros.Controls.Add(this.autorTextBox);
            this.panelLibros.Controls.Add(editorialLabel);
            this.panelLibros.Controls.Add(this.editorialTextBox);
            this.panelLibros.Controls.Add(anioPublicacionLabel);
            this.panelLibros.Controls.Add(this.anioPublicacionTextBox);
            this.panelLibros.Enabled = false;
            this.panelLibros.Location = new System.Drawing.Point(40, 45);
            this.panelLibros.Name = "panelLibros";
            this.panelLibros.Size = new System.Drawing.Size(238, 218);
            this.panelLibros.TabIndex = 12;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(20, 11);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(147, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 29);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(255, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(364, 11);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Location = new System.Drawing.Point(136, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 49);
            this.panel2.TabIndex = 17;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(468, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLibros);
            this.Controls.Add(this.librosDataGridView);
            this.Controls.Add(this.librosBindingNavigator);
            this.Name = "frmLibro";
            this.Text = "frmLibro";
            this.Load += new System.EventHandler(this.frmLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingNavigator)).EndInit();
            this.librosBindingNavigator.ResumeLayout(false);
            this.librosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.panelLibros.ResumeLayout(false);
            this.panelLibros.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaProyectoDataSet bibliotecaProyectoDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaProyectoDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private BibliotecaProyectoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator librosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton librosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idLibrosTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox editorialTextBox;
        private System.Windows.Forms.TextBox anioPublicacionTextBox;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panelLibros;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
    }
}