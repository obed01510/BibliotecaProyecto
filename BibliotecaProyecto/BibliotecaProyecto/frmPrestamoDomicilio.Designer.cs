namespace BibliotecaProyecto
{
    partial class frmPrestamoDomicilio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamoDomicilio));
            System.Windows.Forms.Label fechaDevolucionLabel;
            this.bibliotecaProyectoDataSet = new BibliotecaProyecto.BibliotecaProyectoDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.PrestamosTableAdapter();
            this.tableAdapterManager = new BibliotecaProyecto.BibliotecaProyectoDataSetTableAdapters.TableAdapterManager();
            this.prestamosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.prestamosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fechaDevolucionTextBox = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            fechaDevolucionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingNavigator)).BeginInit();
            this.prestamosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.prestamosBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.prestamosBindingNavigator.TabIndex = 0;
            this.prestamosBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // fechaDevolucionLabel
            // 
            fechaDevolucionLabel.AutoSize = true;
            fechaDevolucionLabel.Location = new System.Drawing.Point(202, 107);
            fechaDevolucionLabel.Name = "fechaDevolucionLabel";
            fechaDevolucionLabel.Size = new System.Drawing.Size(119, 16);
            fechaDevolucionLabel.TabIndex = 1;
            fechaDevolucionLabel.Text = "Fecha Devolucion:";
            // 
            // fechaDevolucionTextBox
            // 
            this.fechaDevolucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prestamosBindingSource, "FechaDevolucion", true));
            this.fechaDevolucionTextBox.Location = new System.Drawing.Point(327, 104);
            this.fechaDevolucionTextBox.Name = "fechaDevolucionTextBox";
            this.fechaDevolucionTextBox.Size = new System.Drawing.Size(100, 22);
            this.fechaDevolucionTextBox.TabIndex = 2;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(528, 182);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmPrestamoDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(fechaDevolucionLabel);
            this.Controls.Add(this.fechaDevolucionTextBox);
            this.Controls.Add(this.prestamosBindingNavigator);
            this.Name = "frmPrestamoDomicilio";
            this.Text = "frmPrestamoDomicilio";
            this.Load += new System.EventHandler(this.frmPrestamoDomicilio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaProyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingNavigator)).EndInit();
            this.prestamosBindingNavigator.ResumeLayout(false);
            this.prestamosBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox fechaDevolucionTextBox;
        private System.Windows.Forms.Button btnRegresar;
    }
}