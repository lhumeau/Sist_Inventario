namespace Presentacion.Inventario
{
    partial class ActualizarInventario
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
            System.Windows.Forms.Label almacenamientoLabel;
            System.Windows.Forms.Label sistema_OperativoLabel;
            System.Windows.Forms.Label memoriaRAMLabel;
            System.Windows.Forms.Label procesadorLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label tipo_EquipoLabel;
            System.Windows.Forms.Label serviceTagLabel;
            System.Windows.Forms.Label numero_SerieLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label modeloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarInventario));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lbllistbox = new System.Windows.Forms.Label();
            this.txtAgregarInventario = new System.Windows.Forms.TextBox();
            this.btnBotonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.almacenamientoComboBox = new System.Windows.Forms.ComboBox();
            this.sistema_OperativoTextBox = new System.Windows.Forms.TextBox();
            this.memoriaRAMTextBox = new System.Windows.Forms.TextBox();
            this.procesadorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxIDinventario = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo_Equipo = new System.Windows.Forms.ComboBox();
            this.serviceTagTextBox = new System.Windows.Forms.TextBox();
            this.numero_SerieTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.txtbModelo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.dbinventarioDataSet = new Presentacion.DbinventarioDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager();
            this.dataTable1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataTable1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            almacenamientoLabel = new System.Windows.Forms.Label();
            sistema_OperativoLabel = new System.Windows.Forms.Label();
            memoriaRAMLabel = new System.Windows.Forms.Label();
            procesadorLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            tipo_EquipoLabel = new System.Windows.Forms.Label();
            serviceTagLabel = new System.Windows.Forms.Label();
            numero_SerieLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).BeginInit();
            this.dataTable1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Id",
            "Cantidad",
            "Tipo_Equipo",
            "Marca",
            "Color",
            "Modelo",
            "Marca",
            "Tipo_Equipo",
            "Numero_Serie",
            "ServiceTag",
            "Procesador",
            "MemoriaRAM",
            "OS",
            "Almacenamiento"});
            this.comboBox1.Location = new System.Drawing.Point(536, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 55;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(663, 52);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 54;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lbllistbox
            // 
            this.lbllistbox.AutoSize = true;
            this.lbllistbox.Location = new System.Drawing.Point(545, 28);
            this.lbllistbox.Name = "lbllistbox";
            this.lbllistbox.Size = new System.Drawing.Size(98, 13);
            this.lbllistbox.TabIndex = 53;
            this.lbllistbox.Text = "Critierio Busqueda :";
            // 
            // txtAgregarInventario
            // 
            this.txtAgregarInventario.Location = new System.Drawing.Point(345, 55);
            this.txtAgregarInventario.Name = "txtAgregarInventario";
            this.txtAgregarInventario.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarInventario.TabIndex = 51;
            // 
            // btnBotonBuscar
            // 
            this.btnBotonBuscar.Location = new System.Drawing.Point(451, 53);
            this.btnBotonBuscar.Name = "btnBotonBuscar";
            this.btnBotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBotonBuscar.TabIndex = 52;
            this.btnBotonBuscar.Text = "Buscar";
            this.btnBotonBuscar.UseVisualStyleBackColor = true;
            this.btnBotonBuscar.Click += new System.EventHandler(this.btnBotonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Actualizacion de Asignaciones de Inventario";
            // 
            // almacenamientoLabel
            // 
            almacenamientoLabel.AutoSize = true;
            almacenamientoLabel.Location = new System.Drawing.Point(470, 519);
            almacenamientoLabel.Name = "almacenamientoLabel";
            almacenamientoLabel.Size = new System.Drawing.Size(88, 13);
            almacenamientoLabel.TabIndex = 80;
            almacenamientoLabel.Text = "Almacenamiento:";
            // 
            // almacenamientoComboBox
            // 
            this.almacenamientoComboBox.FormattingEnabled = true;
            this.almacenamientoComboBox.Location = new System.Drawing.Point(468, 535);
            this.almacenamientoComboBox.Name = "almacenamientoComboBox";
            this.almacenamientoComboBox.Size = new System.Drawing.Size(100, 21);
            this.almacenamientoComboBox.TabIndex = 81;
            // 
            // sistema_OperativoLabel
            // 
            sistema_OperativoLabel.AutoSize = true;
            sistema_OperativoLabel.Location = new System.Drawing.Point(349, 520);
            sistema_OperativoLabel.Name = "sistema_OperativoLabel";
            sistema_OperativoLabel.Size = new System.Drawing.Size(96, 13);
            sistema_OperativoLabel.TabIndex = 78;
            sistema_OperativoLabel.Text = "Sistema Operativo:";
            // 
            // sistema_OperativoTextBox
            // 
            this.sistema_OperativoTextBox.Location = new System.Drawing.Point(345, 536);
            this.sistema_OperativoTextBox.Name = "sistema_OperativoTextBox";
            this.sistema_OperativoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sistema_OperativoTextBox.TabIndex = 79;
            // 
            // memoriaRAMLabel
            // 
            memoriaRAMLabel.AutoSize = true;
            memoriaRAMLabel.Location = new System.Drawing.Point(480, 472);
            memoriaRAMLabel.Name = "memoriaRAMLabel";
            memoriaRAMLabel.Size = new System.Drawing.Size(77, 13);
            memoriaRAMLabel.TabIndex = 76;
            memoriaRAMLabel.Text = "Memoria RAM:";
            // 
            // memoriaRAMTextBox
            // 
            this.memoriaRAMTextBox.Location = new System.Drawing.Point(468, 488);
            this.memoriaRAMTextBox.Name = "memoriaRAMTextBox";
            this.memoriaRAMTextBox.Size = new System.Drawing.Size(100, 20);
            this.memoriaRAMTextBox.TabIndex = 77;
            // 
            // procesadorLabel
            // 
            procesadorLabel.AutoSize = true;
            procesadorLabel.Location = new System.Drawing.Point(369, 472);
            procesadorLabel.Name = "procesadorLabel";
            procesadorLabel.Size = new System.Drawing.Size(64, 13);
            procesadorLabel.TabIndex = 74;
            procesadorLabel.Text = "Procesador:";
            // 
            // procesadorTextBox
            // 
            this.procesadorTextBox.Location = new System.Drawing.Point(345, 488);
            this.procesadorTextBox.Name = "procesadorTextBox";
            this.procesadorTextBox.Size = new System.Drawing.Size(100, 20);
            this.procesadorTextBox.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Id";
            // 
            // txtboxIDinventario
            // 
            this.txtboxIDinventario.Location = new System.Drawing.Point(207, 338);
            this.txtboxIDinventario.Name = "txtboxIDinventario";
            this.txtboxIDinventario.ReadOnly = true;
            this.txtboxIDinventario.Size = new System.Drawing.Size(100, 20);
            this.txtboxIDinventario.TabIndex = 72;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DisplayMember = "descripcion";
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(345, 575);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxColor.TabIndex = 71;
            this.comboBoxColor.ValueMember = "Id";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DisplayMember = "descripcion";
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(345, 394);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarca.TabIndex = 70;
            this.comboBoxMarca.ValueMember = "Id";
            // 
            // comboBoxTipo_Equipo
            // 
            this.comboBoxTipo_Equipo.DisplayMember = "descripcion";
            this.comboBoxTipo_Equipo.FormattingEnabled = true;
            this.comboBoxTipo_Equipo.Location = new System.Drawing.Point(345, 342);
            this.comboBoxTipo_Equipo.Name = "comboBoxTipo_Equipo";
            this.comboBoxTipo_Equipo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipo_Equipo.TabIndex = 69;
            this.comboBoxTipo_Equipo.ValueMember = "Id";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(369, 379);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 68;
            marcaLabel.Text = "Marca:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(375, 559);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 67;
            colorLabel.Text = "Color:";
            // 
            // tipo_EquipoLabel
            // 
            tipo_EquipoLabel.AutoSize = true;
            tipo_EquipoLabel.Location = new System.Drawing.Point(360, 326);
            tipo_EquipoLabel.Name = "tipo_EquipoLabel";
            tipo_EquipoLabel.Size = new System.Drawing.Size(67, 13);
            tipo_EquipoLabel.TabIndex = 66;
            tipo_EquipoLabel.Text = "Tipo Equipo:";
            // 
            // serviceTagLabel
            // 
            serviceTagLabel.AutoSize = true;
            serviceTagLabel.Location = new System.Drawing.Point(482, 326);
            serviceTagLabel.Name = "serviceTagLabel";
            serviceTagLabel.Size = new System.Drawing.Size(68, 13);
            serviceTagLabel.TabIndex = 64;
            serviceTagLabel.Text = "Service Tag:";
            // 
            // serviceTagTextBox
            // 
            this.serviceTagTextBox.Location = new System.Drawing.Point(468, 342);
            this.serviceTagTextBox.Name = "serviceTagTextBox";
            this.serviceTagTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceTagTextBox.TabIndex = 65;
            // 
            // numero_SerieLabel
            // 
            numero_SerieLabel.AutoSize = true;
            numero_SerieLabel.Location = new System.Drawing.Point(480, 379);
            numero_SerieLabel.Name = "numero_SerieLabel";
            numero_SerieLabel.Size = new System.Drawing.Size(74, 13);
            numero_SerieLabel.TabIndex = 62;
            numero_SerieLabel.Text = "Numero Serie:";
            // 
            // numero_SerieTextBox
            // 
            this.numero_SerieTextBox.Location = new System.Drawing.Point(468, 395);
            this.numero_SerieTextBox.Name = "numero_SerieTextBox";
            this.numero_SerieTextBox.Size = new System.Drawing.Size(100, 20);
            this.numero_SerieTextBox.TabIndex = 63;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(498, 428);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 60;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(468, 444);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 61;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(369, 425);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 58;
            modeloLabel.Text = "Modelo:";
            // 
            // txtbModelo
            // 
            this.txtbModelo.Location = new System.Drawing.Point(345, 444);
            this.txtbModelo.Name = "txtbModelo";
            this.txtbModelo.Size = new System.Drawing.Size(100, 20);
            this.txtbModelo.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(645, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 57;
            this.button2.Text = "Borrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(645, 342);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 39);
            this.BtnActualizar.TabIndex = 56;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dbinventarioDataSet
            // 
            this.dbinventarioDataSet.DataSetName = "DbinventarioDataSet";
            this.dbinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenamientoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorSetTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmpleadoSetTableAdapter = null;
            this.tableAdapterManager.Historial_AsignacionesSetTableAdapter = null;
            this.tableAdapterManager.InventarioSetTableAdapter = null;
            this.tableAdapterManager.MarcaSetTableAdapter = null;
            this.tableAdapterManager.ProyectoSetTableAdapter = null;
            this.tableAdapterManager.Tipo_equipoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1BindingNavigator
            // 
            this.dataTable1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTable1BindingNavigator.BindingSource = this.dataTable1BindingSource;
            this.dataTable1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTable1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTable1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dataTable1BindingNavigatorSaveItem});
            this.dataTable1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTable1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTable1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTable1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTable1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTable1BindingNavigator.Name = "dataTable1BindingNavigator";
            this.dataTable1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTable1BindingNavigator.Size = new System.Drawing.Size(1027, 25);
            this.dataTable1BindingNavigator.TabIndex = 82;
            this.dataTable1BindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dataTable1BindingNavigatorSaveItem
            // 
            this.dataTable1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTable1BindingNavigatorSaveItem.Enabled = false;
            this.dataTable1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTable1BindingNavigatorSaveItem.Image")));
            this.dataTable1BindingNavigatorSaveItem.Name = "dataTable1BindingNavigatorSaveItem";
            this.dataTable1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataTable1BindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn11});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 197);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Tipo_Equipo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tipo_Equipo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 92;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn9.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 67;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn10.HeaderText = "Color";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ServicesTag";
            this.dataGridViewTextBoxColumn4.HeaderText = "ServicesTag";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NumeroSerie";
            this.dataGridViewTextBoxColumn5.HeaderText = "NumeroSerie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 93;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Procesador";
            this.dataGridViewTextBoxColumn6.HeaderText = "Procesador";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 86;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MemoriaRAM";
            this.dataGridViewTextBoxColumn7.HeaderText = "MemoriaRAM";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 96;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OS";
            this.dataGridViewTextBoxColumn12.HeaderText = "OS";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 47;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Almacenamiento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Almacenamiento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 110;
            // 
            // ActualizarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataTable1BindingNavigator);
            this.Controls.Add(almacenamientoLabel);
            this.Controls.Add(this.almacenamientoComboBox);
            this.Controls.Add(sistema_OperativoLabel);
            this.Controls.Add(this.sistema_OperativoTextBox);
            this.Controls.Add(memoriaRAMLabel);
            this.Controls.Add(this.memoriaRAMTextBox);
            this.Controls.Add(procesadorLabel);
            this.Controls.Add(this.procesadorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxIDinventario);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxTipo_Equipo);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(colorLabel);
            this.Controls.Add(tipo_EquipoLabel);
            this.Controls.Add(serviceTagLabel);
            this.Controls.Add(this.serviceTagTextBox);
            this.Controls.Add(numero_SerieLabel);
            this.Controls.Add(this.numero_SerieTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.txtbModelo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.lbllistbox);
            this.Controls.Add(this.txtAgregarInventario);
            this.Controls.Add(this.btnBotonBuscar);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarInventario";
            this.Text = "ActualizarInventario";
            this.Load += new System.EventHandler(this.ActualizarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).EndInit();
            this.dataTable1BindingNavigator.ResumeLayout(false);
            this.dataTable1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lbllistbox;
        private System.Windows.Forms.TextBox txtAgregarInventario;
        private System.Windows.Forms.Button btnBotonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox almacenamientoComboBox;
        private System.Windows.Forms.TextBox sistema_OperativoTextBox;
        private System.Windows.Forms.TextBox memoriaRAMTextBox;
        private System.Windows.Forms.TextBox procesadorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxIDinventario;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxTipo_Equipo;
        private System.Windows.Forms.TextBox serviceTagTextBox;
        private System.Windows.Forms.TextBox numero_SerieTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox txtbModelo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnActualizar;
        private DbinventarioDataSet dbinventarioDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DbinventarioDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DbinventarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTable1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dataTable1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}