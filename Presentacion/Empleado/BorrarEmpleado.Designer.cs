namespace Presentacion.Empleado
{
    partial class BorrarEmpleado
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label proyectoIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarEmpleado));
            this.dbinventarioDataSet = new Presentacion.DbinventarioDataSet();
            this.empleadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lbllistbox = new System.Windows.Forms.Label();
            this.txtAgregarInventario = new System.Windows.Forms.TextBox();
            this.btnBotonBuscar = new System.Windows.Forms.Button();
            this.lbldescriptivoeliminar = new System.Windows.Forms.Label();
            this.dgvBorrarRegistro = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager();
            this.proyectoSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.ProyectoSetTableAdapter();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.activoTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.proyectoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoIdTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            proyectoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(137, 367);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 40;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(137, 393);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 42;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(137, 419);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 44;
            apellidoLabel.Text = "Apellido:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(137, 445);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 46;
            cedulaLabel.Text = "Cedula:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(137, 498);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 50;
            activoLabel.Text = "Activo:";
            // 
            // proyectoIdLabel
            // 
            proyectoIdLabel.AutoSize = true;
            proyectoIdLabel.Location = new System.Drawing.Point(137, 471);
            proyectoIdLabel.Name = "proyectoIdLabel";
            proyectoIdLabel.Size = new System.Drawing.Size(64, 13);
            proyectoIdLabel.TabIndex = 55;
            proyectoIdLabel.Text = "Proyecto Id:";
            // 
            // dbinventarioDataSet
            // 
            this.dbinventarioDataSet.DataSetName = "DbinventarioDataSet";
            this.dbinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoSetBindingSource
            // 
            this.empleadoSetBindingSource.DataMember = "EmpleadoSet";
            this.empleadoSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // empleadoSetTableAdapter
            // 
            this.empleadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Apellido",
            "Cedula",
            "ProyectoID",
            "Activo"});
            this.comboBox1.Location = new System.Drawing.Point(355, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(482, 34);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 38;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lbllistbox
            // 
            this.lbllistbox.AutoSize = true;
            this.lbllistbox.Location = new System.Drawing.Point(364, 10);
            this.lbllistbox.Name = "lbllistbox";
            this.lbllistbox.Size = new System.Drawing.Size(98, 13);
            this.lbllistbox.TabIndex = 37;
            this.lbllistbox.Text = "Critierio Busqueda :";
            // 
            // txtAgregarInventario
            // 
            this.txtAgregarInventario.Location = new System.Drawing.Point(164, 37);
            this.txtAgregarInventario.Name = "txtAgregarInventario";
            this.txtAgregarInventario.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarInventario.TabIndex = 35;
            // 
            // btnBotonBuscar
            // 
            this.btnBotonBuscar.Location = new System.Drawing.Point(270, 35);
            this.btnBotonBuscar.Name = "btnBotonBuscar";
            this.btnBotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBotonBuscar.TabIndex = 36;
            this.btnBotonBuscar.Text = "Buscar";
            this.btnBotonBuscar.UseVisualStyleBackColor = true;
            this.btnBotonBuscar.Click += new System.EventHandler(this.btnBotonBuscar_Click);
            // 
            // lbldescriptivoeliminar
            // 
            this.lbldescriptivoeliminar.AutoSize = true;
            this.lbldescriptivoeliminar.Location = new System.Drawing.Point(279, 71);
            this.lbldescriptivoeliminar.Name = "lbldescriptivoeliminar";
            this.lbldescriptivoeliminar.Size = new System.Drawing.Size(165, 13);
            this.lbldescriptivoeliminar.TabIndex = 34;
            this.lbldescriptivoeliminar.Tag = "";
            this.lbldescriptivoeliminar.Text = "Seleccione Registro para Eliminar";
            // 
            // dgvBorrarRegistro
            // 
            this.dgvBorrarRegistro.AllowUserToAddRows = false;
            this.dgvBorrarRegistro.AllowUserToDeleteRows = false;
            this.dgvBorrarRegistro.AllowUserToOrderColumns = true;
            this.dgvBorrarRegistro.AutoGenerateColumns = false;
            this.dgvBorrarRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvBorrarRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvBorrarRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrarRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.proyectoIdDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn});
            this.dgvBorrarRegistro.DataSource = this.empleadoSetBindingSource;
            this.dgvBorrarRegistro.Location = new System.Drawing.Point(130, 97);
            this.dgvBorrarRegistro.Name = "dgvBorrarRegistro";
            this.dgvBorrarRegistro.ReadOnly = true;
            this.dgvBorrarRegistro.Size = new System.Drawing.Size(442, 226);
            this.dgvBorrarRegistro.TabIndex = 40;
            this.dgvBorrarRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrarRegistro_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 69;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn.Width = 65;
            // 
            // proyectoIdDataGridViewTextBoxColumn
            // 
            this.proyectoIdDataGridViewTextBoxColumn.DataPropertyName = "ProyectoId";
            this.proyectoIdDataGridViewTextBoxColumn.HeaderText = "ProyectoId";
            this.proyectoIdDataGridViewTextBoxColumn.Name = "proyectoIdDataGridViewTextBoxColumn";
            this.proyectoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.proyectoIdDataGridViewTextBoxColumn.Width = 83;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            this.activoDataGridViewTextBoxColumn.Width = 62;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenamientoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorSetTableAdapter = null;
            this.tableAdapterManager.EmpleadoSetTableAdapter = this.empleadoSetTableAdapter;
            this.tableAdapterManager.Historial_AsignacionesSetTableAdapter = null;
            this.tableAdapterManager.InventarioSetTableAdapter = null;
            this.tableAdapterManager.MarcaSetTableAdapter = null;
            this.tableAdapterManager.ProyectoSetTableAdapter = this.proyectoSetTableAdapter;
            this.tableAdapterManager.Tipo_equipoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proyectoSetTableAdapter
            // 
            this.proyectoSetTableAdapter.ClearBeforeFill = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(207, 364);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 41;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoSetBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(207, 390);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 43;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoSetBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(207, 416);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.ReadOnly = true;
            this.apellidoTextBox.Size = new System.Drawing.Size(121, 20);
            this.apellidoTextBox.TabIndex = 45;
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoSetBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(207, 442);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.ReadOnly = true;
            this.cedulaTextBox.Size = new System.Drawing.Size(121, 20);
            this.cedulaTextBox.TabIndex = 47;
            // 
            // activoTextBox
            // 
            this.activoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoSetBindingSource, "Activo", true));
            this.activoTextBox.Location = new System.Drawing.Point(207, 495);
            this.activoTextBox.Name = "activoTextBox";
            this.activoTextBox.ReadOnly = true;
            this.activoTextBox.Size = new System.Drawing.Size(121, 20);
            this.activoTextBox.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(498, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 39);
            this.button2.TabIndex = 54;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(384, 380);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(87, 39);
            this.BtnActualizar.TabIndex = 53;
            this.BtnActualizar.Text = "Eliminar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Registro  Seleccionado";
            // 
            // proyectoSetBindingSource
            // 
            this.proyectoSetBindingSource.DataMember = "ProyectoSet";
            this.proyectoSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // proyectoIdTextBox
            // 
            this.proyectoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoSetBindingSource, "ProyectoId", true));
            this.proyectoIdTextBox.Location = new System.Drawing.Point(207, 468);
            this.proyectoIdTextBox.Name = "proyectoIdTextBox";
            this.proyectoIdTextBox.ReadOnly = true;
            this.proyectoIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.proyectoIdTextBox.TabIndex = 56;
            // 
            // BorrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 535);
            this.Controls.Add(proyectoIdLabel);
            this.Controls.Add(this.proyectoIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoTextBox);
            this.Controls.Add(this.dgvBorrarRegistro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.lbllistbox);
            this.Controls.Add(this.txtAgregarInventario);
            this.Controls.Add(this.btnBotonBuscar);
            this.Controls.Add(this.lbldescriptivoeliminar);
            this.Name = "BorrarEmpleado";
            this.Text = "BorrarEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrarEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.BorrarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrarRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbinventarioDataSet dbinventarioDataSet;
        private System.Windows.Forms.BindingSource empleadoSetBindingSource;
        private DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter empleadoSetTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lbllistbox;
        private System.Windows.Forms.TextBox txtAgregarInventario;
        private System.Windows.Forms.Button btnBotonBuscar;
        private System.Windows.Forms.Label lbldescriptivoeliminar;
        private System.Windows.Forms.DataGridView dgvBorrarRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyectoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private DbinventarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox activoTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label1;
        private DbinventarioDataSetTableAdapters.ProyectoSetTableAdapter proyectoSetTableAdapter;
        private System.Windows.Forms.BindingSource proyectoSetBindingSource;
        private System.Windows.Forms.TextBox proyectoIdTextBox;
    }
}