using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using System.Data.Sql;
using System.Data.Entity;
using Datos.Inventario;
using Negocio;
using Negocio.Inventario;
using System.Threading;
using System.Data.Linq;
using System.Data.SqlClient;
using Presentacion.DbinventarioDataSetTableAdapters;


namespace Presentacion.Asignaciones
{
    public partial class updateAsignaciones : Form
    {
        public updateAsignaciones()
        {
            InitializeComponent();
        }

        private void updateAsignaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.EmpleadoSet' table. You can move, or remove it, as needed.
            this.empleadoSetTableAdapter.Fill(this.dbinventarioDataSet.EmpleadoSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.ProyectoSet' table. You can move, or remove it, as needed.
            this.proyectoSetTableAdapter.Fill(this.dbinventarioDataSet.ProyectoSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.AsignacionSet' table. You can move, or remove it, as needed.
            this.asignacionSetTableAdapter.Fill(this.dbinventarioDataSet.AsignacionSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.AsignacionesActualesEmpleados' table. You can move, or remove it, as needed.
            this.asignacionesActualesEmpleadosTableAdapter.Fill(this.dbinventarioDataSet.AsignacionesActualesEmpleados);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.EquipoSinAsignar' table. You can move, or remove it, as needed.
            this.equipoSinAsignarTableAdapter.Fill(this.dbinventarioDataSet.EquipoSinAsignar);

        }

        private void asignacionesActualesEmpleadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!asignacionesActualesEmpleadosDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow dgv = asignacionesActualesEmpleadosDataGridView.Rows[e.RowIndex];
                idTextBox.Text = dgv.Cells[0].Value.ToString();
                proyectoIdTextBox.Text = dgv.Cells[4].Value.ToString();
                empleadoIdTextBox.Text = string.Format(dgv.Cells[1].Value.ToString());
                fecha_AsignacionDateTimePicker.Text = Convert.ToString(dgv.Cells[6].Value.ToString());
                
                {

                }
            }
        }

        private void equipoSinAsignarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex == -1) return;

            if (!equipoSinAsignarDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow dgv = equipoSinAsignarDataGridView.Rows[e.RowIndex];
                inventarioIDTextBox.Text = dgv.Cells[0].Value.ToString();

                {

                }
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asignacionesActualesEmpleadosDataGridView.DataSource = asignacionesActualesEmpleadosTableAdapter.GetData();
        }

        private void BtnBuscarEquiposAsignados_Click(object sender, EventArgs e)
        {
            if (txtBuscar1.Text != "" & Comboxbox2Filtro.Text != "")
            {

                string searchValue = txtBuscar1.Text;

                asignacionesActualesEmpleadosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (asignacionesActualesEmpleadosDataGridView.DataSource as DataTable).DefaultView.RowFilter = Comboxbox2Filtro.Text + " LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                //  dataTable1BindingSource.RemoveFilter();
                MessageBox.Show("Debes seleccionar el criterio de busqueda y Escribir en Buscar");


            }
        
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            equipoSinAsignarDataGridView.DataSource = equipoSinAsignarTableAdapter.GetData();
        }

        private void btnBotonBuscar_Click(object sender, EventArgs e)
        {
            if (txtAgregarInventario.Text != "" & comboBox1.Text != "")
            {

                string searchValue = txtAgregarInventario.Text;

                equipoSinAsignarDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (equipoSinAsignarDataGridView.DataSource as DataTable).DefaultView.RowFilter = comboBox1.Text + " LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                //  dataTable1BindingSource.RemoveFilter();
                MessageBox.Show("Debes seleccionar el criterio de busqueda y Escribir en Buscar");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }
        private InventarioCN umanager = new InventarioCN();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            umanager.ActualizacionAsignacion(new AsignacionSet()
            {
                Id = Convert.ToInt32(idTextBox.Text),
                Fecha_Asignacion = fecha_AsignacionDateTimePicker.Value,
                InventarioID = Convert.ToInt32(inventarioIDTextBox.Text),

            });
            // this.inventarioSetTableAdapter.Fill(this.dbinventarioDataSet.InventarioSet);
            asignacionesActualesEmpleadosDataGridView.DataSource = asignacionesActualesEmpleadosTableAdapter.GetData();
            equipoSinAsignarDataGridView.DataSource = equipoSinAsignarTableAdapter.GetData();
        }
      
       
    }
}
