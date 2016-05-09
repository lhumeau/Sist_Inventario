namespace Presentacion.Gestion
{
    partial class ActualizarColor
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
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarColor));
            this.dbinventarioDataSet = new Presentacion.DbinventarioDataSet();
            this.empleadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter();
            this.colorSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.ColorSetTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lbllistbox = new System.Windows.Forms.Label();
            this.txtAgregarInventario = new System.Windows.Forms.TextBox();
            this.btnBotonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager();
            this.colorSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descripcionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(186, 333);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 59;
            descripcionLabel.Text = "descripcion:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(231, 299);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 58;
            idLabel.Text = "Id:";
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
            // colorSetBindingSource
            // 
            this.colorSetBindingSource.DataMember = "ColorSet";
            this.colorSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // colorSetTableAdapter
            // 
            this.colorSetTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Descripcion",
            "id"});
            this.comboBox1.Location = new System.Drawing.Point(398, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 50;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(525, 49);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 49;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // lbllistbox
            // 
            this.lbllistbox.AutoSize = true;
            this.lbllistbox.Location = new System.Drawing.Point(407, 25);
            this.lbllistbox.Name = "lbllistbox";
            this.lbllistbox.Size = new System.Drawing.Size(98, 13);
            this.lbllistbox.TabIndex = 48;
            this.lbllistbox.Text = "Critierio Busqueda :";
            // 
            // txtAgregarInventario
            // 
            this.txtAgregarInventario.Location = new System.Drawing.Point(207, 52);
            this.txtAgregarInventario.Name = "txtAgregarInventario";
            this.txtAgregarInventario.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarInventario.TabIndex = 46;
            // 
            // btnBotonBuscar
            // 
            this.btnBotonBuscar.Location = new System.Drawing.Point(313, 50);
            this.btnBotonBuscar.Name = "btnBotonBuscar";
            this.btnBotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBotonBuscar.TabIndex = 47;
            this.btnBotonBuscar.Text = "Buscar";
            this.btnBotonBuscar.UseVisualStyleBackColor = true;
            this.btnBotonBuscar.Click += new System.EventHandler(this.btnBotonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Registro  Seleccionado";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(525, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 39);
            this.button2.TabIndex = 63;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(411, 307);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(87, 39);
            this.BtnActualizar.TabIndex = 62;
            this.BtnActualizar.Text = "Eliminar";
            this.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colorSetBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(256, 330);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 61;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colorSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(256, 292);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 60;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenamientoSetTableAdapter = null;
            this.tableAdapterManager.AsignacionSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorSetTableAdapter = this.colorSetTableAdapter;
            this.tableAdapterManager.EmpleadoSetTableAdapter = this.empleadoSetTableAdapter;
            this.tableAdapterManager.Historial_AsignacionesSetTableAdapter = null;
            this.tableAdapterManager.InventarioSetTableAdapter = null;
            this.tableAdapterManager.MarcaSetTableAdapter = null;
            this.tableAdapterManager.ProyectoSetTableAdapter = null;
            this.tableAdapterManager.Tipo_equipoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.DbinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.colorSetDataGridView.Location = new System.Drawing.Point(207, 79);
            this.colorSetDataGridView.Name = "colorSetDataGridView";
            this.colorSetDataGridView.ReadOnly = true;
            this.colorSetDataGridView.Size = new System.Drawing.Size(393, 171);
            this.colorSetDataGridView.TabIndex = 64;
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
            // ActualizarColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 461);
            this.Controls.Add(this.colorSetDataGridView);
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
            this.Name = "ActualizarColor";
            this.Text = "ActualizarColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActualizarColor_FormClosing);
            this.Load += new System.EventHandler(this.ActualizarColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbinventarioDataSet dbinventarioDataSet;
        private System.Windows.Forms.BindingSource empleadoSetBindingSource;
        private DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter empleadoSetTableAdapter;
        private System.Windows.Forms.BindingSource colorSetBindingSource;
        private DbinventarioDataSetTableAdapters.ColorSetTableAdapter colorSetTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lbllistbox;
        private System.Windows.Forms.TextBox txtAgregarInventario;
        private System.Windows.Forms.Button btnBotonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private DbinventarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView colorSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}