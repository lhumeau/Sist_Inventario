namespace Presentacion.Gestion
{
    partial class RegistroColor
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
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroColor));
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dbinventarioDataSet = new Presentacion.DbinventarioDataSet();
            this.colorSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.ColorSetTableAdapter();
            this.tableAdapterManager = new Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager();
            this.colorSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.colorSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.colorSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscarColor = new System.Windows.Forms.Button();
            this.txtBuscarColor = new System.Windows.Forms.TextBox();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingNavigator)).BeginInit();
            this.colorSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(118, 80);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(37, 13);
            descripcionLabel.TabIndex = 21;
            descripcionLabel.Text = "Color :";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(139, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Borrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(46, 153);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 39);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dbinventarioDataSet
            // 
            this.dbinventarioDataSet.DataSetName = "DbinventarioDataSet";
            this.dbinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colorSetBindingSource
            // 
            this.colorSetBindingSource.DataMember = "ColorSet";
            this.colorSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // colorSetTableAdapter
            // 
            this.colorSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenamientoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorSetTableAdapter = this.colorSetTableAdapter;
            this.tableAdapterManager.EmpleadoSetTableAdapter = null;
            this.tableAdapterManager.Historial_AsignacionesSetTableAdapter = null;
            this.tableAdapterManager.InventarioSetTableAdapter = null;
            this.tableAdapterManager.MarcaSetTableAdapter = null;
            this.tableAdapterManager.ProyectoSetTableAdapter = null;
            this.tableAdapterManager.Tipo_equipoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colorSetBindingNavigator
            // 
            this.colorSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.colorSetBindingNavigator.BindingSource = this.colorSetBindingSource;
            this.colorSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.colorSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.colorSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.colorSetBindingNavigatorSaveItem});
            this.colorSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.colorSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.colorSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.colorSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.colorSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.colorSetBindingNavigator.Name = "colorSetBindingNavigator";
            this.colorSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.colorSetBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.colorSetBindingNavigator.TabIndex = 21;
            this.colorSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // colorSetBindingNavigatorSaveItem
            // 
            this.colorSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("colorSetBindingNavigatorSaveItem.Image")));
            this.colorSetBindingNavigatorSaveItem.Name = "colorSetBindingNavigatorSaveItem";
            this.colorSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.colorSetBindingNavigatorSaveItem.Text = "Save Data";
            this.colorSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.colorSetBindingNavigatorSaveItem_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colorSetBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(85, 111);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 22;
            // 
            // colorSetDataGridView
            // 
            this.colorSetDataGridView.AllowUserToAddRows = false;
            this.colorSetDataGridView.AllowUserToDeleteRows = false;
            this.colorSetDataGridView.AllowUserToOrderColumns = true;
            this.colorSetDataGridView.AutoGenerateColumns = false;
            this.colorSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            this.colorSetDataGridView.DataSource = this.colorSetBindingSource;
            this.colorSetDataGridView.Location = new System.Drawing.Point(282, 79);
            this.colorSetDataGridView.Name = "colorSetDataGridView";
            this.colorSetDataGridView.ReadOnly = true;
            this.colorSetDataGridView.Size = new System.Drawing.Size(270, 220);
            this.colorSetDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // BtnBuscarColor
            // 
            this.BtnBuscarColor.Location = new System.Drawing.Point(413, 42);
            this.BtnBuscarColor.Name = "BtnBuscarColor";
            this.BtnBuscarColor.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarColor.TabIndex = 24;
            this.BtnBuscarColor.Text = "Buscar Color :";
            this.BtnBuscarColor.UseVisualStyleBackColor = true;
            this.BtnBuscarColor.Click += new System.EventHandler(this.BtnBuscarColor_Click);
            // 
            // txtBuscarColor
            // 
            this.txtBuscarColor.Location = new System.Drawing.Point(307, 45);
            this.txtBuscarColor.Name = "txtBuscarColor";
            this.txtBuscarColor.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarColor.TabIndex = 25;
            // 
            // RegistroColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 359);
            this.Controls.Add(this.txtBuscarColor);
            this.Controls.Add(this.BtnBuscarColor);
            this.Controls.Add(this.colorSetDataGridView);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.colorSetBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "RegistroColor";
            this.Text = "RegistroColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroColor_FormClosing);
            this.Load += new System.EventHandler(this.RegistroColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingNavigator)).EndInit();
            this.colorSetBindingNavigator.ResumeLayout(false);
            this.colorSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAgregar;
        private DbinventarioDataSet dbinventarioDataSet;
        private System.Windows.Forms.BindingSource colorSetBindingSource;
        private DbinventarioDataSetTableAdapters.ColorSetTableAdapter colorSetTableAdapter;
        private DbinventarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator colorSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton colorSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DataGridView colorSetDataGridView;
        private System.Windows.Forms.Button BtnBuscarColor;
        private System.Windows.Forms.TextBox txtBuscarColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}