namespace Presentacion.Reportes.ReporteDetEmpleado
{
    partial class GenerarReporte
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
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.comboBoxSeleccionarEmpleado = new System.Windows.Forms.ComboBox();
            this.empleadoSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbinventarioDataSet = new Presentacion.DbinventarioDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empleadoSetTableAdapter = new Presentacion.DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(137, 152);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(121, 39);
            this.BtnGenerarReporte.TabIndex = 0;
            this.BtnGenerarReporte.Text = "Generar Reporte";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // comboBoxSeleccionarEmpleado
            // 
            this.comboBoxSeleccionarEmpleado.DataSource = this.empleadoSetBindingSource;
            this.comboBoxSeleccionarEmpleado.DisplayMember = "Nombre";
            this.comboBoxSeleccionarEmpleado.FormattingEnabled = true;
            this.comboBoxSeleccionarEmpleado.Location = new System.Drawing.Point(137, 112);
            this.comboBoxSeleccionarEmpleado.Name = "comboBoxSeleccionarEmpleado";
            this.comboBoxSeleccionarEmpleado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeleccionarEmpleado.TabIndex = 1;
            this.comboBoxSeleccionarEmpleado.ValueMember = "Id";
            // 
            // empleadoSetBindingSource
            // 
            this.empleadoSetBindingSource.DataMember = "EmpleadoSet";
            this.empleadoSetBindingSource.DataSource = this.dbinventarioDataSet;
            // 
            // dbinventarioDataSet
            // 
            this.dbinventarioDataSet.DataSetName = "DbinventarioDataSet";
            this.dbinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reporte de Equipo por Empleado";
            // 
            // empleadoSetTableAdapter
            // 
            this.empleadoSetTableAdapter.ClearBeforeFill = true;
            // 
            // GenerarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSeleccionarEmpleado);
            this.Controls.Add(this.BtnGenerarReporte);
            this.Name = "GenerarReporte";
            this.Text = "GenerarReporte";
            this.Load += new System.EventHandler(this.GenerarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbinventarioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.ComboBox comboBoxSeleccionarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DbinventarioDataSet dbinventarioDataSet;
        private System.Windows.Forms.BindingSource empleadoSetBindingSource;
        private DbinventarioDataSetTableAdapters.EmpleadoSetTableAdapter empleadoSetTableAdapter;
    }
}