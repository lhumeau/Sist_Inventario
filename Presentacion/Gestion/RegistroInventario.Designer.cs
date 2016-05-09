namespace Presentacion.Inventario
{
    partial class RegistroInventario
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
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label marcaIdLabel1;
            System.Windows.Forms.Label colorIdLabel;
            System.Windows.Forms.Label tipo_equipoIdLabel;
            System.Windows.Forms.Label numeroSerieLabel;
            System.Windows.Forms.Label servicesTagLabel;
            System.Windows.Forms.Label asignacionIdLabel;
            System.Windows.Forms.Label procesadorLabel;
            System.Windows.Forms.Label memoriaRAMLabel;
            System.Windows.Forms.Label sistema_OperativoLabel;
            System.Windows.Forms.Label almacenamientoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInventario));
            System.Windows.Forms.Label idLabel;
            this.dbinventarioDataSet = new Presentacion.DbinventarioDataSet();
            this.inventarioSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.InventarioSetTableAdapter();
            this.tableAdapterManager = new Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager();
            this.asignacionSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.AsignacionSetTableAdapter();
            this.empleadoSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter();
            this.marcaSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.MarcaSetTableAdapter();
            this.tipo_equipoSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.Tipo_equipoSetTableAdapter();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.marcaIdComboBox = new System.Windows.Forms.ComboBox();
            this.marcaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorIdComboBox = new System.Windows.Forms.ComboBox();
            this.colorSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_equipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.tipoequipoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbinventarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbinventarioDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroSerieTextBox = new System.Windows.Forms.TextBox();
            this.servicesTagTextBox = new System.Windows.Forms.TextBox();
            this.marcaSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.colorSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.ColorSetTableAdapter();
            this.btnBotonBuscar = new System.Windows.Forms.Button();
            this.txtAgregarInventario = new System.Windows.Forms.TextBox();
            this.lbllistbox = new System.Windows.Forms.Label();
            this.asignacionSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionIdComboBox = new System.Windows.Forms.ComboBox();
            this.inventarioSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioRelacionadoBinding = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.DataTable1TableAdapter();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PanelAgregar = new System.Windows.Forms.Panel();
            this.almacenamientoComboBox = new System.Windows.Forms.ComboBox();
            this.sistema_OperativoTextBox = new System.Windows.Forms.TextBox();
            this.memoriaRAMTextBox = new System.Windows.Forms.TextBox();
            this.procesadorTextBox = new System.Windows.Forms.TextBox();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoriaRAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaOperativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            modeloLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            marcaIdLabel1 = new System.Windows.Forms.Label();
            colorIdLabel = new System.Windows.Forms.Label();
            tipo_equipoIdLabel = new System.Windows.Forms.Label();
            numeroSerieLabel = new System.Windows.Forms.Label();
            servicesTagLabel = new System.Windows.Forms.Label();
            asignacionIdLabel = new System.Windows.Forms.Label();
            procesadorLabel = new System.Windows.Forms.Label();
            memoriaRAMLabel = new System.Windows.Forms.Label();
            sistema_OperativoLabel = new System.Windows.Forms.Label();
            almacenamientoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoequipoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioRelacionadoBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.PanelAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(49, 134);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(48, 13);
            modeloLabel.TabIndex = 7;
            modeloLabel.Text = "Modelo :";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(45, 188);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(55, 13);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad :";
            // 
            // marcaIdLabel1
            // 
            marcaIdLabel1.AutoSize = true;
            marcaIdLabel1.Location = new System.Drawing.Point(54, 48);
            marcaIdLabel1.Name = "marcaIdLabel1";
            marcaIdLabel1.Size = new System.Drawing.Size(43, 13);
            marcaIdLabel1.TabIndex = 14;
            marcaIdLabel1.Text = "Marca :";
            // 
            // colorIdLabel
            // 
            colorIdLabel.AutoSize = true;
            colorIdLabel.Location = new System.Drawing.Point(60, 75);
            colorIdLabel.Name = "colorIdLabel";
            colorIdLabel.Size = new System.Drawing.Size(37, 13);
            colorIdLabel.TabIndex = 15;
            colorIdLabel.Text = "Color :";
            // 
            // tipo_equipoIdLabel
            // 
            tipo_equipoIdLabel.AutoSize = true;
            tipo_equipoIdLabel.Location = new System.Drawing.Point(28, 107);
            tipo_equipoIdLabel.Name = "tipo_equipoIdLabel";
            tipo_equipoIdLabel.Size = new System.Drawing.Size(69, 13);
            tipo_equipoIdLabel.TabIndex = 16;
            tipo_equipoIdLabel.Text = "Tipo equipo :";
            // 
            // numeroSerieLabel
            // 
            numeroSerieLabel.AutoSize = true;
            numeroSerieLabel.Location = new System.Drawing.Point(32, 214);
            numeroSerieLabel.Name = "numeroSerieLabel";
            numeroSerieLabel.Size = new System.Drawing.Size(74, 13);
            numeroSerieLabel.TabIndex = 18;
            numeroSerieLabel.Text = "Numero Serie:";
            // 
            // servicesTagLabel
            // 
            servicesTagLabel.AutoSize = true;
            servicesTagLabel.Location = new System.Drawing.Point(33, 240);
            servicesTagLabel.Name = "servicesTagLabel";
            servicesTagLabel.Size = new System.Drawing.Size(73, 13);
            servicesTagLabel.TabIndex = 19;
            servicesTagLabel.Text = "Services Tag:";
            // 
            // asignacionIdLabel
            // 
            asignacionIdLabel.AutoSize = true;
            asignacionIdLabel.Location = new System.Drawing.Point(32, 161);
            asignacionIdLabel.Name = "asignacionIdLabel";
            asignacionIdLabel.Size = new System.Drawing.Size(74, 13);
            asignacionIdLabel.TabIndex = 25;
            asignacionIdLabel.Text = "Asignacion Id:";
            // 
            // procesadorLabel
            // 
            procesadorLabel.AutoSize = true;
            procesadorLabel.Location = new System.Drawing.Point(30, 256);
            procesadorLabel.Name = "procesadorLabel";
            procesadorLabel.Size = new System.Drawing.Size(64, 13);
            procesadorLabel.TabIndex = 0;
            procesadorLabel.Text = "Procesador:";
            // 
            // memoriaRAMLabel
            // 
            memoriaRAMLabel.AutoSize = true;
            memoriaRAMLabel.Location = new System.Drawing.Point(17, 282);
            memoriaRAMLabel.Name = "memoriaRAMLabel";
            memoriaRAMLabel.Size = new System.Drawing.Size(77, 13);
            memoriaRAMLabel.TabIndex = 2;
            memoriaRAMLabel.Text = "Memoria RAM:";
            // 
            // sistema_OperativoLabel
            // 
            sistema_OperativoLabel.AutoSize = true;
            sistema_OperativoLabel.Location = new System.Drawing.Point(-2, 308);
            sistema_OperativoLabel.Name = "sistema_OperativoLabel";
            sistema_OperativoLabel.Size = new System.Drawing.Size(96, 13);
            sistema_OperativoLabel.TabIndex = 4;
            sistema_OperativoLabel.Text = "Sistema Operativo:";
            // 
            // almacenamientoLabel
            // 
            almacenamientoLabel.AutoSize = true;
            almacenamientoLabel.Location = new System.Drawing.Point(6, 334);
            almacenamientoLabel.Name = "almacenamientoLabel";
            almacenamientoLabel.Size = new System.Drawing.Size(88, 13);
            almacenamientoLabel.TabIndex = 6;
            almacenamientoLabel.Text = "Almacenamiento:";
            // 
            // dbinventarioDataSet
            // 
            this.dbinventarioDataSet.DataSetName = "DbinventarioDataSet";
            this.dbinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioSetBindingSource
            // 
            this.inventarioSetBindingSource.DataMember = "InventarioSet";
            this.inventarioSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // inventarioSetTableAdapter
            // 
            this.inventarioSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenamientoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionSetTableAdapter = this.asignacionSetTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorSetTableAdapter = null;
            this.tableAdapterManager.EmpleadoSetTableAdapter = this.empleadoSetTableAdapter;
            this.tableAdapterManager.Historial_AsignacionesSetTableAdapter = null;
            this.tableAdapterManager.InventarioSetTableAdapter = this.inventarioSetTableAdapter;
            this.tableAdapterManager.MarcaSetTableAdapter = this.marcaSetTableAdapter;
            this.tableAdapterManager.ProyectoSetTableAdapter = null;
            this.tableAdapterManager.Tipo_equipoSetTableAdapter = this.tipo_equipoSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // asignacionSetTableAdapter
            // 
            this.asignacionSetTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoSetTableAdapter
            // 
            this.empleadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // marcaSetTableAdapter
            // 
            this.marcaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_equipoSetTableAdapter
            // 
            this.tipo_equipoSetTableAdapter.ClearBeforeFill = true;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(112, 131);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 4;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(112, 185);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 6;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(10, 400);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 39);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(145, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "Borrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // marcaIdComboBox
            // 
            this.marcaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "MarcaId", true));
            this.marcaIdComboBox.DataSource = this.marcaSetBindingSource;
            this.marcaIdComboBox.DisplayMember = "descripcion";
            this.marcaIdComboBox.FormattingEnabled = true;
            this.marcaIdComboBox.Location = new System.Drawing.Point(112, 45);
            this.marcaIdComboBox.Name = "marcaIdComboBox";
            this.marcaIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.marcaIdComboBox.TabIndex = 1;
            this.marcaIdComboBox.ValueMember = "Id";
            // 
            // marcaSetBindingSource
            // 
            this.marcaSetBindingSource.DataMember = "MarcaSet";
            this.marcaSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // colorIdComboBox
            // 
            this.colorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "ColorId", true));
            this.colorIdComboBox.DataSource = this.colorSetBindingSource;
            this.colorIdComboBox.DisplayMember = "descripcion";
            this.colorIdComboBox.FormattingEnabled = true;
            this.colorIdComboBox.Location = new System.Drawing.Point(112, 72);
            this.colorIdComboBox.Name = "colorIdComboBox";
            this.colorIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.colorIdComboBox.TabIndex = 2;
            this.colorIdComboBox.ValueMember = "Id";
            // 
            // colorSetBindingSource
            // 
            this.colorSetBindingSource.DataMember = "ColorSet";
            this.colorSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // marcaSetBindingSource1
            // 
            this.marcaSetBindingSource1.DataMember = "MarcaSet";
            this.marcaSetBindingSource1.DataSource = this.dbinventarioDataSet;
            // 
            // tipo_equipoIdComboBox
            // 
            this.tipo_equipoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "Tipo_equipoId", true));
            this.tipo_equipoIdComboBox.DataSource = this.tipoequipoSetBindingSource;
            this.tipo_equipoIdComboBox.DisplayMember = "descripcion";
            this.tipo_equipoIdComboBox.FormattingEnabled = true;
            this.tipo_equipoIdComboBox.Location = new System.Drawing.Point(112, 104);
            this.tipo_equipoIdComboBox.Name = "tipo_equipoIdComboBox";
            this.tipo_equipoIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.tipo_equipoIdComboBox.TabIndex = 3;
            this.tipo_equipoIdComboBox.ValueMember = "Id";
            // 
            // tipoequipoSetBindingSource
            // 
            this.tipoequipoSetBindingSource.DataMember = "Tipo_equipoSet";
            this.tipoequipoSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // empleadoSetBindingSource
            // 
            this.empleadoSetBindingSource.DataMember = "EmpleadoSet";
            this.empleadoSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // dbinventarioDataSetBindingSource
            // 
            this.dbinventarioDataSetBindingSource.DataSource = this.dbinventarioDataSet;
            this.dbinventarioDataSetBindingSource.Position = 0;
            // 
            // dbinventarioDataSetBindingSource1
            // 
            this.dbinventarioDataSetBindingSource1.DataSource = this.dbinventarioDataSet;
            this.dbinventarioDataSetBindingSource1.Position = 0;
            // 
            // asignacionSetBindingSource
            // 
            this.asignacionSetBindingSource.DataMember = "AsignacionSet";
            this.asignacionSetBindingSource.DataSource = this.dbinventarioDataSetBindingSource1;
            // 
            // numeroSerieTextBox
            // 
            this.numeroSerieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "NumeroSerie", true));
            this.numeroSerieTextBox.Location = new System.Drawing.Point(112, 211);
            this.numeroSerieTextBox.Name = "numeroSerieTextBox";
            this.numeroSerieTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroSerieTextBox.TabIndex = 7;
            // 
            // servicesTagTextBox
            // 
            this.servicesTagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "ServicesTag", true));
            this.servicesTagTextBox.Location = new System.Drawing.Point(112, 237);
            this.servicesTagTextBox.Name = "servicesTagTextBox";
            this.servicesTagTextBox.Size = new System.Drawing.Size(100, 20);
            this.servicesTagTextBox.TabIndex = 8;
            // 
            // marcaSetBindingSource2
            // 
            this.marcaSetBindingSource2.DataMember = "MarcaSet";
            this.marcaSetBindingSource2.DataSource = this.dbinventarioDataSet;
            // 
            // colorSetTableAdapter
            // 
            this.colorSetTableAdapter.ClearBeforeFill = true;
            // 
            // btnBotonBuscar
            // 
            this.btnBotonBuscar.Location = new System.Drawing.Point(558, 48);
            this.btnBotonBuscar.Name = "btnBotonBuscar";
            this.btnBotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBotonBuscar.TabIndex = 22;
            this.btnBotonBuscar.Text = "Buscar";
            this.btnBotonBuscar.UseVisualStyleBackColor = true;
            this.btnBotonBuscar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtAgregarInventario
            // 
            this.txtAgregarInventario.Location = new System.Drawing.Point(452, 50);
            this.txtAgregarInventario.Name = "txtAgregarInventario";
            this.txtAgregarInventario.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarInventario.TabIndex = 9;
            // 
            // lbllistbox
            // 
            this.lbllistbox.AutoSize = true;
            this.lbllistbox.Location = new System.Drawing.Point(652, 23);
            this.lbllistbox.Name = "lbllistbox";
            this.lbllistbox.Size = new System.Drawing.Size(98, 13);
            this.lbllistbox.TabIndex = 25;
            this.lbllistbox.Text = "Critierio Busqueda :";
            // 
            // asignacionSetBindingSource1
            // 
            this.asignacionSetBindingSource1.DataMember = "AsignacionSet";
            this.asignacionSetBindingSource1.DataSource = this.dbinventarioDataSet;
            // 
            // empleadoSetBindingSource1
            // 
            this.empleadoSetBindingSource1.DataMember = "EmpleadoSet";
            this.empleadoSetBindingSource1.DataSource = this.dbinventarioDataSet;
            // 
            // asignacionIdComboBox
            // 
            this.asignacionIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "AsignacionId", true));
            this.asignacionIdComboBox.DataSource = this.empleadoSetBindingSource1;
            this.asignacionIdComboBox.DisplayMember = "Nombre";
            this.asignacionIdComboBox.FormattingEnabled = true;
            this.asignacionIdComboBox.Location = new System.Drawing.Point(112, 158);
            this.asignacionIdComboBox.Name = "asignacionIdComboBox";
            this.asignacionIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.asignacionIdComboBox.TabIndex = 5;
            this.asignacionIdComboBox.ValueMember = "Id";
            // 
            // inventarioSetBindingSource1
            // 
            this.inventarioSetBindingSource1.DataMember = "InventarioSet";
            this.inventarioSetBindingSource1.DataSource = this.dbinventarioDataSet;
            // 
            // InventarioRelacionadoBinding
            // 
            this.InventarioRelacionadoBinding.AllowNew = true;
            this.InventarioRelacionadoBinding.DataMember = "DataTable1";
            this.InventarioRelacionadoBinding.DataSource = this.dbinventarioDataSet;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dbinventarioDataSet;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(770, 47);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 27;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Color",
            "Modelo",
            "Marca",
            "Tipo_Equipo",
            "Numero_Serie",
            "ServiceTag"});
            this.comboBox1.Location = new System.Drawing.Point(643, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // PanelAgregar
            // 
            this.PanelAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.PanelAgregar.Controls.Add(idLabel);
            this.PanelAgregar.Controls.Add(almacenamientoLabel);
            this.PanelAgregar.Controls.Add(this.almacenamientoComboBox);
            this.PanelAgregar.Controls.Add(sistema_OperativoLabel);
            this.PanelAgregar.Controls.Add(this.sistema_OperativoTextBox);
            this.PanelAgregar.Controls.Add(memoriaRAMLabel);
            this.PanelAgregar.Controls.Add(this.memoriaRAMTextBox);
            this.PanelAgregar.Controls.Add(procesadorLabel);
            this.PanelAgregar.Controls.Add(this.procesadorTextBox);
            this.PanelAgregar.Location = new System.Drawing.Point(12, 12);
            this.PanelAgregar.Name = "PanelAgregar";
            this.PanelAgregar.Size = new System.Drawing.Size(220, 382);
            this.PanelAgregar.TabIndex = 30;
            // 
            // almacenamientoComboBox
            // 
            this.almacenamientoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "Almacenamiento", true));
            this.almacenamientoComboBox.FormattingEnabled = true;
            this.almacenamientoComboBox.Location = new System.Drawing.Point(100, 331);
            this.almacenamientoComboBox.Name = "almacenamientoComboBox";
            this.almacenamientoComboBox.Size = new System.Drawing.Size(100, 21);
            this.almacenamientoComboBox.TabIndex = 7;
            // 
            // sistema_OperativoTextBox
            // 
            this.sistema_OperativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "Sistema_Operativo", true));
            this.sistema_OperativoTextBox.Location = new System.Drawing.Point(100, 305);
            this.sistema_OperativoTextBox.Name = "sistema_OperativoTextBox";
            this.sistema_OperativoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sistema_OperativoTextBox.TabIndex = 5;
            // 
            // memoriaRAMTextBox
            // 
            this.memoriaRAMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "MemoriaRAM", true));
            this.memoriaRAMTextBox.Location = new System.Drawing.Point(100, 279);
            this.memoriaRAMTextBox.Name = "memoriaRAMTextBox";
            this.memoriaRAMTextBox.Size = new System.Drawing.Size(100, 20);
            this.memoriaRAMTextBox.TabIndex = 3;
            // 
            // procesadorTextBox
            // 
            this.procesadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "Procesador", true));
            this.procesadorTextBox.Location = new System.Drawing.Point(100, 253);
            this.procesadorTextBox.Name = "procesadorTextBox";
            this.procesadorTextBox.Size = new System.Drawing.Size(100, 20);
            this.procesadorTextBox.TabIndex = 1;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dbinventarioDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numeroSerieDataGridViewTextBoxColumn,
            this.serviceTagDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.tipoEquipoDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.procesadorDataGridViewTextBoxColumn,
            this.memoriaRAMDataGridViewTextBoxColumn,
            this.sistemaOperativoDataGridViewTextBoxColumn,
            this.almacenamientoDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(234, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 307);
            this.dataGridView1.TabIndex = 31;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dbinventarioDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 67;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 74;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // numeroSerieDataGridViewTextBoxColumn
            // 
            this.numeroSerieDataGridViewTextBoxColumn.DataPropertyName = "Numero_Serie";
            this.numeroSerieDataGridViewTextBoxColumn.HeaderText = "Numero_Serie";
            this.numeroSerieDataGridViewTextBoxColumn.Name = "numeroSerieDataGridViewTextBoxColumn";
            this.numeroSerieDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroSerieDataGridViewTextBoxColumn.Width = 99;
            // 
            // serviceTagDataGridViewTextBoxColumn
            // 
            this.serviceTagDataGridViewTextBoxColumn.DataPropertyName = "ServiceTag";
            this.serviceTagDataGridViewTextBoxColumn.HeaderText = "ServiceTag";
            this.serviceTagDataGridViewTextBoxColumn.Name = "serviceTagDataGridViewTextBoxColumn";
            this.serviceTagDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceTagDataGridViewTextBoxColumn.Width = 87;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 62;
            // 
            // tipoEquipoDataGridViewTextBoxColumn
            // 
            this.tipoEquipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Equipo";
            this.tipoEquipoDataGridViewTextBoxColumn.HeaderText = "Tipo_Equipo";
            this.tipoEquipoDataGridViewTextBoxColumn.Name = "tipoEquipoDataGridViewTextBoxColumn";
            this.tipoEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoEquipoDataGridViewTextBoxColumn.Width = 92;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 56;
            // 
            // procesadorDataGridViewTextBoxColumn
            // 
            this.procesadorDataGridViewTextBoxColumn.DataPropertyName = "Procesador";
            this.procesadorDataGridViewTextBoxColumn.HeaderText = "Procesador";
            this.procesadorDataGridViewTextBoxColumn.Name = "procesadorDataGridViewTextBoxColumn";
            this.procesadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.procesadorDataGridViewTextBoxColumn.Width = 86;
            // 
            // memoriaRAMDataGridViewTextBoxColumn
            // 
            this.memoriaRAMDataGridViewTextBoxColumn.DataPropertyName = "MemoriaRAM";
            this.memoriaRAMDataGridViewTextBoxColumn.HeaderText = "MemoriaRAM";
            this.memoriaRAMDataGridViewTextBoxColumn.Name = "memoriaRAMDataGridViewTextBoxColumn";
            this.memoriaRAMDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoriaRAMDataGridViewTextBoxColumn.Width = 96;
            // 
            // sistemaOperativoDataGridViewTextBoxColumn
            // 
            this.sistemaOperativoDataGridViewTextBoxColumn.DataPropertyName = "Sistema_Operativo";
            this.sistemaOperativoDataGridViewTextBoxColumn.HeaderText = "Sistema_Operativo";
            this.sistemaOperativoDataGridViewTextBoxColumn.Name = "sistemaOperativoDataGridViewTextBoxColumn";
            this.sistemaOperativoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sistemaOperativoDataGridViewTextBoxColumn.Width = 121;
            // 
            // almacenamientoDataGridViewTextBoxColumn
            // 
            this.almacenamientoDataGridViewTextBoxColumn.DataPropertyName = "Almacenamiento";
            this.almacenamientoDataGridViewTextBoxColumn.HeaderText = "Almacenamiento";
            this.almacenamientoDataGridViewTextBoxColumn.Name = "almacenamientoDataGridViewTextBoxColumn";
            this.almacenamientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.almacenamientoDataGridViewTextBoxColumn.Width = 110;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 69;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(66, 11);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(112, 20);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // RegistroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(asignacionIdLabel);
            this.Controls.Add(this.asignacionIdComboBox);
            this.Controls.Add(this.lbllistbox);
            this.Controls.Add(this.txtAgregarInventario);
            this.Controls.Add(this.btnBotonBuscar);
            this.Controls.Add(servicesTagLabel);
            this.Controls.Add(this.servicesTagTextBox);
            this.Controls.Add(numeroSerieLabel);
            this.Controls.Add(this.numeroSerieTextBox);
            this.Controls.Add(tipo_equipoIdLabel);
            this.Controls.Add(this.tipo_equipoIdComboBox);
            this.Controls.Add(colorIdLabel);
            this.Controls.Add(this.colorIdComboBox);
            this.Controls.Add(marcaIdLabel1);
            this.Controls.Add(this.marcaIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.PanelAgregar);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "RegistroInventario";
            this.Text = "AgregarInventarioPRE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroInventario_FormClosing);
            this.Load += new System.EventHandler(this.AgregarInventarioPRE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoequipoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioRelacionadoBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.PanelAgregar.ResumeLayout(false);
            this.PanelAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbinventarioDataSet dbinventarioDataSet;
        private System.Windows.Forms.BindingSource inventarioSetBindingSource;
        private DbinventarioDataSetTableAdapters.InventarioSetTableAdapter inventarioSetTableAdapter;
        private DbinventarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox marcaIdComboBox;
        private System.Windows.Forms.ComboBox colorIdComboBox;
        private System.Windows.Forms.ComboBox tipo_equipoIdComboBox;
        private DbinventarioDataSetTableAdapters.MarcaSetTableAdapter marcaSetTableAdapter;
        private System.Windows.Forms.BindingSource marcaSetBindingSource;
        private DbinventarioDataSetTableAdapters.Tipo_equipoSetTableAdapter tipo_equipoSetTableAdapter;
        private System.Windows.Forms.BindingSource marcaSetBindingSource1;
        private System.Windows.Forms.BindingSource dbinventarioDataSetBindingSource;
        private System.Windows.Forms.BindingSource tipoequipoSetBindingSource;
        private DbinventarioDataSetTableAdapters.AsignacionSetTableAdapter asignacionSetTableAdapter;
        private System.Windows.Forms.BindingSource dbinventarioDataSetBindingSource1;
        private System.Windows.Forms.BindingSource asignacionSetBindingSource;
        private DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter empleadoSetTableAdapter;
        private System.Windows.Forms.BindingSource empleadoSetBindingSource;
        private System.Windows.Forms.TextBox numeroSerieTextBox;
        private System.Windows.Forms.TextBox servicesTagTextBox;
        private System.Windows.Forms.BindingSource marcaSetBindingSource2;
        private System.Windows.Forms.BindingSource colorSetBindingSource;
        private DbinventarioDataSetTableAdapters.ColorSetTableAdapter colorSetTableAdapter;
        private System.Windows.Forms.Button btnBotonBuscar;
        private System.Windows.Forms.TextBox txtAgregarInventario;
        private System.Windows.Forms.Label lbllistbox;
        private System.Windows.Forms.BindingSource empleadoSetBindingSource1;
        private System.Windows.Forms.BindingSource asignacionSetBindingSource1;
        private System.Windows.Forms.ComboBox asignacionIdComboBox;
        private System.Windows.Forms.BindingSource inventarioSetBindingSource1;
        private System.Windows.Forms.BindingSource InventarioRelacionadoBinding;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DbinventarioDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel PanelAgregar;
        private System.Windows.Forms.ComboBox almacenamientoComboBox;
        private System.Windows.Forms.TextBox sistema_OperativoTextBox;
        private System.Windows.Forms.TextBox memoriaRAMTextBox;
        private System.Windows.Forms.TextBox procesadorTextBox;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procesadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoriaRAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sistemaOperativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;

    }
}