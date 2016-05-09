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

namespace Presentacion.Empleado
{
    public partial class BorrarEmpleado : Form
    {
        public BorrarEmpleado()
        {
            InitializeComponent();
        }

        private void BorrarEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.ProyectoSet' table. You can move, or remove it, as needed.
            this.proyectoSetTableAdapter.Fill(this.dbinventarioDataSet.ProyectoSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.EmpleadoSet' table. You can move, or remove it, as needed.
            this.empleadoSetTableAdapter.Fill(this.dbinventarioDataSet.EmpleadoSet);
            dgvBorrarRegistro.DataSource = empleadoSetTableAdapter.GetData();

        }
        private InventarioCN umanager = new InventarioCN();
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            umanager.BorrarInventario(new EmpleadoSet()
                 {

                     Id = Convert.ToInt32(idTextBox.Text),
                 });
            dgvBorrarRegistro.DataSource = empleadoSetTableAdapter.GetData();


        }

        private void btnBotonBuscar_Click(object sender, EventArgs e)
        {
            if (txtAgregarInventario.Text != "" & comboBox1.Text != "")
            {

                string searchValue = txtAgregarInventario.Text;

                dgvBorrarRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (dgvBorrarRegistro.DataSource as DataTable).DefaultView.RowFilter = comboBox1.Text + " LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                //  dataTable1BindingSource.RemoveFilter();
                MessageBox.Show("Debes seleccionar el criterio de busqueda y Escribir en Buscar");


            }
        }

        private void dgvBorrarRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvBorrarRegistro.Rows[e.RowIndex];
            idTextBox.Text = dgv.Cells[0].Value.ToString();
            nombreTextBox.Text = dgv.Cells[1].Value.ToString();
            apellidoTextBox.Text = dgv.Cells[2].Value.ToString();
            cedulaTextBox.Text = dgv.Cells[3].Value.ToString();
            proyectoIdTextBox.Text = dgv.Cells[4].Value.ToString();
            activoTextBox.Text = dgv.Cells[5].Value.ToString();


        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dgvBorrarRegistro.DataSource = empleadoSetTableAdapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            umanager.BorrarInventario(new EmpleadoSet()
            {

                Id = Convert.ToInt32(idTextBox.Text),
            });
            dgvBorrarRegistro.DataSource = empleadoSetTableAdapter.GetData();

        }

        private void BorrarEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
