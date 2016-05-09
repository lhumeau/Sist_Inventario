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
    public partial class ActEmpleado : Form
    {
        public ActEmpleado()
        {
            InitializeComponent();
        }

        private void ActEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.EmpleadoSet' table. You can move, or remove it, as needed.
            this.empleadoSetTableAdapter.Fill(this.dbinventarioDataSet.EmpleadoSet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex == -1) return;

             if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
             {
                 DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
                 idTextBox.Text = dgv.Cells[0].Value.ToString();
                 nombreTextBox.Text = dgv.Cells[1].Value.ToString();
                 apellidoTextBox.Text = dgv.Cells[2].Value.ToString();
                 cedulaTextBox.Text = dgv.Cells[3].Value.ToString();
                 proyectoIdTextBox.Text = dgv.Cells[4].Value.ToString();
                 activoTextBox.Text = dgv.Cells[5].Value.ToString();
             }
        }
        InventarioCN unmanager = new InventarioCN();

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = empleadoSetTableAdapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void btnBotonBuscar_Click(object sender, EventArgs e)
        {
            if (txtAgregarInventario.Text != "" & comboBox1.Text != "")
            {

                string searchValue = txtAgregarInventario.Text;

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = comboBox1.Text + " LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                //  dataTable1BindingSource.RemoveFilter();
                MessageBox.Show("Debes seleccionar el criterio de busqueda y Escribir en Buscar");


            }
        }

        private void BtnACtualizar_Click(object sender, EventArgs e)
        {
            unmanager.ActualizarEmpleadosCN(new EmpleadoSet()
            {
                Id = Convert.ToInt32(idTextBox.Text),
                Nombre = nombreTextBox.Text,
                Apellido = apellidoTextBox.Text,
                Cedula = cedulaTextBox.Text,
                ProyectoId = Convert.ToInt32(proyectoIdTextBox.Text),
                Activo = Convert.ToInt32(activoTextBox.Text),

              });
            dataGridView1.DataSource = empleadoSetTableAdapter.GetData();
        }

        private void ActEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }

        
       
    }
}
