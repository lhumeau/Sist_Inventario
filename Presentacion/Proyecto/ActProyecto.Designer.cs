namespace Presentacion.Proyecto
{
    partial class ActProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActProyecto));
            this.dbinventarioDataSet = new Presentacion.DbinventarioDataSet();
            this.proyectoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.ProyectoSetTableAdapter();
            this.tableAdapterManager = new Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager();
            this.proyectoSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.proyectoSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proyectoSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lbllistbox = new System.Windows.Forms.Label();
            this.txtAgregarInventario = new System.Windows.Forms.TextBox();
            this.btnBotonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetBindingNavigator)).BeginInit();
            this.proyectoSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(210, 368);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 70;
            idLabel.Text = "Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(165, 395);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 71;
            descripcionLabel.Text = "descripcion:";
            // 
            // dbinventarioDataSet
            // 
            this.dbinventarioDataSet.DataSetName = "DbinventarioDataSet";
            this.dbinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoSetBindingSource
            // 
            this.proyectoSetBindingSource.DataMember = "ProyectoSet";
            this.proyectoSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // proyectoSetTableAdapter
            // 
            this.proyectoSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenamientoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorSetTableAdapter = null;
            this.tableAdapterManager.EmpleadoSetTableAdapter = null;
            this.tableAdapterManager.Historial_AsignacionesSetTableAdapter = null;
            this.tableAdapterManager.InventarioSetTableAdapter = null;
            this.tableAdapterManager.MarcaSetTableAdapter = null;
            this.tableAdapterManager.ProyectoSetTableAdapter = this.proyectoSetTableAdapter;
            this.tableAdapterManager.Tipo_equipoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proyectoSetBindingNavigator
            // 
            this.proyectoSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proyectoSetBindingNavigator.BindingSource = this.proyectoSetBindingSource;
            this.proyectoSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proyectoSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proyectoSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.proyectoSetBindingNavigatorSaveItem});
            this.proyectoSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proyectoSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proyectoSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proyectoSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proyectoSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proyectoSetBindingNavigator.Name = "proyectoSetBindingNavigator";
            this.proyectoSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proyectoSetBindingNavigator.Size = new System.Drawing.Size(812, 25);
            this.proyectoSetBindingNavigator.TabIndex = 0;
            this.proyectoSetBindingNavigator.Text = "bindingNavigator1";
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
            // proyectoSetBindingNavigatorSaveItem
            // 
            this.proyectoSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proyectoSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proyectoSetBindingNavigatorSaveItem.Image")));
            this.proyectoSetBindingNavigatorSaveItem.Name = "proyectoSetBindingNavigatorSaveItem";
            this.proyectoSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proyectoSetBindingNavigatorSaveItem.Text = "Save Data";
            this.proyectoSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.proyectoSetBindingNavigatorSaveItem_Click);
            // 
            // proyectoSetDataGridView
            // 
            this.proyectoSetDataGridView.AllowUserToAddRows = false;
            this.proyectoSetDataGridView.AllowUserToDeleteRows = false;
            this.proyectoSetDataGridView.AllowUserToOrderColumns = true;
            this.proyectoSetDataGridView.AutoGenerateColumns = false;
            this.proyectoSetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.proyectoSetDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.proyectoSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectoSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.proyectoSetDataGridView.DataSource = this.proyectoSetBindingSource;
            this.proyectoSetDataGridView.Location = new System.Drawing.Point(196, 99);
            this.proyectoSetDataGridView.Name = "proyectoSetDataGridView";
            this.proyectoSetDataGridView.ReadOnly = true;
            this.proyectoSetDataGridView.Size = new System.Drawing.Size(393, 220);
            this.proyectoSetDataGridView.TabIndex = 1;
            this.proyectoSetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectoSetDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 86;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Descripcion",
            "id"});
            this.comboBox1.Location = new System.Drawing.Point(387, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 60;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(514, 58);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 59;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lbllistbox
            // 
            this.lbllistbox.AutoSize = true;
            this.lbllistbox.Location = new System.Drawing.Point(396, 34);
            this.lbllistbox.Name = "lbllistbox";
            this.lbllistbox.Size = new System.Drawing.Size(98, 13);
            this.lbllistbox.TabIndex = 58;
            this.lbllistbox.Text = "Critierio Busqueda :";
            // 
            // txtAgregarInventario
            // 
            this.txtAgregarInventario.Location = new System.Drawing.Point(196, 61);
            this.txtAgregarInventario.Name = "txtAgregarInventario";
            this.txtAgregarInventario.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarInventario.TabIndex = 56;
            // 
            // btnBotonBuscar
            // 
            this.btnBotonBuscar.Location = new System.Drawing.Point(302, 59);
            this.btnBotonBuscar.Name = "btnBotonBuscar";
            this.btnBotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBotonBuscar.TabIndex = 57;
            this.btnBotonBuscar.Text = "Buscar";
            this.btnBotonBuscar.UseVisualStyleBackColor = true;
            this.btnBotonBuscar.Click += new System.EventHandler(this.btnBotonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Registro  Seleccionado";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(502, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 39);
            this.button2.TabIndex = 69;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(387, 373);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(99, 39);
            this.BtnActualizar.TabIndex = 68;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(235, 365);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 71;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoSetBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(235, 392);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 72;
            // 
            // ActProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 568);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.lbllistbox);
            this.Controls.Add(this.txtAgregarInventario);
            this.Controls.Add(this.btnBotonBuscar);
            this.Controls.Add(this.proyectoSetDataGridView);
            this.Controls.Add(this.proyectoSetBindingNavigator);
            this.Name = "ActProyecto";
            this.Text = "ActProyecto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActProyecto_FormClosing);
            this.Load += new System.EventHandler(this.ActProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetBindingNavigator)).EndInit();
            this.proyectoSetBindingNavigator.ResumeLayout(false);
            this.proyectoSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbinventarioDataSet dbinventarioDataSet;
        private System.Windows.Forms.BindingSource proyectoSetBindingSource;
        private DbinventarioDataSetTableAdapters.ProyectoSetTableAdapter proyectoSetTableAdapter;
        private DbinventarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proyectoSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton proyectoSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView proyectoSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lbllistbox;
        private System.Windows.Forms.TextBox txtAgregarInventario;
        private System.Windows.Forms.Button btnBotonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
    }
}