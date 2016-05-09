namespace Presentacion.Gestion
{
    partial class EliminarColor
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarColor));
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
            this.colorSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lbllistbox = new System.Windows.Forms.Label();
            this.txtAgregarInventario = new System.Windows.Forms.TextBox();
            this.btnBotonBuscar = new System.Windows.Forms.Button();
            this.lbldescriptivoeliminar = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingNavigator)).BeginInit();
            this.colorSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(196, 309);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 45;
            idLabel.Text = "Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(151, 343);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 46;
            descripcionLabel.Text = "descripcion:";
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
            this.colorSetBindingNavigator.Size = new System.Drawing.Size(738, 25);
            this.colorSetBindingNavigator.TabIndex = 0;
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
            // colorSetDataGridView
            // 
            this.colorSetDataGridView.AllowUserToAddRows = false;
            this.colorSetDataGridView.AllowUserToDeleteRows = false;
            this.colorSetDataGridView.AllowUserToOrderColumns = true;
            this.colorSetDataGridView.AutoGenerateColumns = false;
            this.colorSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.colorSetDataGridView.DataSource = this.colorSetBindingSource;
            this.colorSetDataGridView.Location = new System.Drawing.Point(122, 131);
            this.colorSetDataGridView.Name = "colorSetDataGridView";
            this.colorSetDataGridView.ReadOnly = true;
            this.colorSetDataGridView.Size = new System.Drawing.Size(443, 133);
            this.colorSetDataGridView.TabIndex = 1;
            this.colorSetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.colorSetDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Descripcion",
            "id"});
            this.comboBox1.Location = new System.Drawing.Point(363, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(490, 66);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 44;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // lbllistbox
            // 
            this.lbllistbox.AutoSize = true;
            this.lbllistbox.Location = new System.Drawing.Point(372, 42);
            this.lbllistbox.Name = "lbllistbox";
            this.lbllistbox.Size = new System.Drawing.Size(98, 13);
            this.lbllistbox.TabIndex = 43;
            this.lbllistbox.Text = "Critierio Busqueda :";
            // 
            // txtAgregarInventario
            // 
            this.txtAgregarInventario.Location = new System.Drawing.Point(172, 69);
            this.txtAgregarInventario.Name = "txtAgregarInventario";
            this.txtAgregarInventario.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarInventario.TabIndex = 41;
            // 
            // btnBotonBuscar
            // 
            this.btnBotonBuscar.Location = new System.Drawing.Point(278, 67);
            this.btnBotonBuscar.Name = "btnBotonBuscar";
            this.btnBotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBotonBuscar.TabIndex = 42;
            this.btnBotonBuscar.Text = "Buscar";
            this.btnBotonBuscar.UseVisualStyleBackColor = true;
            this.btnBotonBuscar.Click += new System.EventHandler(this.btnBotonBuscar_Click);
            // 
            // lbldescriptivoeliminar
            // 
            this.lbldescriptivoeliminar.AutoSize = true;
            this.lbldescriptivoeliminar.Location = new System.Drawing.Point(250, 115);
            this.lbldescriptivoeliminar.Name = "lbldescriptivoeliminar";
            this.lbldescriptivoeliminar.Size = new System.Drawing.Size(165, 13);
            this.lbldescriptivoeliminar.TabIndex = 40;
            this.lbldescriptivoeliminar.Tag = "";
            this.lbldescriptivoeliminar.Text = "Seleccione Registro para Eliminar";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colorSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(221, 302);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 46;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colorSetBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(221, 340);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(490, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 39);
            this.button2.TabIndex = 56;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(376, 317);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(87, 39);
            this.BtnActualizar.TabIndex = 55;
            this.BtnActualizar.Text = "Eliminar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Registro  Seleccionado";
            // 
            // EliminarColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.lbllistbox);
            this.Controls.Add(this.txtAgregarInventario);
            this.Controls.Add(this.btnBotonBuscar);
            this.Controls.Add(this.lbldescriptivoeliminar);
            this.Controls.Add(this.colorSetDataGridView);
            this.Controls.Add(this.colorSetBindingNavigator);
            this.Name = "EliminarColor";
            this.Text = "EliminarColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarColor_FormClosing);
            this.Load += new System.EventHandler(this.EliminarColor_Load);
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
        private System.Windows.Forms.DataGridView colorSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lbllistbox;
        private System.Windows.Forms.TextBox txtAgregarInventario;
        private System.Windows.Forms.Button btnBotonBuscar;
        private System.Windows.Forms.Label lbldescriptivoeliminar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label1;
    }
}