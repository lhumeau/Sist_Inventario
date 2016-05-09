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
using Datos.Inventario;
using Negocio;
using System.Data.Sql;
using System.Data.Entity;
using Negocio.Inventario;
using System.Threading;
using System.Data.Linq;
using System.Data.SqlClient;
using Presentacion.DbinventarioDataSetTableAdapters;

namespace Presentacion.Inventario
{
    public partial class ActualizarInventario : Form
    {
        public ActualizarInventario()
        {
            InitializeComponent();
        }

        private void ActualizarInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.DataTable1' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = dataTable1TableAdapter.GetData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
                txtboxIDinventario.Text = dgv.Cells[0].Value.ToString();
                cantidadTextBox.Text = dgv.Cells[1].Value.ToString();
                comboBoxTipo_Equipo.Text = dgv.Cells[2].Value.ToString();
                comboBoxMarca.Text = dgv.Cells[3].Value.ToString();
                txtbModelo.Text = dgv.Cells[4].Value.ToString();
                comboBoxColor.Text = dgv.Cells[5].Value.ToString();
                serviceTagTextBox.Text = dgv.Cells[6].Value.ToString();
                numero_SerieTextBox.Text = dgv.Cells[7].Value.ToString();
                procesadorTextBox.Text = dgv.Cells[8].Value.ToString();
                memoriaRAMTextBox.Text = dgv.Cells[9].Value.ToString();
                sistema_OperativoTextBox.Text = dgv.Cells[10].Value.ToString();
                almacenamientoComboBox.Text = dgv.Cells[11].Value.ToString();


            }
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
        private InventarioCN umanager = new InventarioCN();
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            umanager.MetActualizarEquipo(new InventarioSet()
            {
                Id = Convert.ToInt32(txtboxIDinventario.Text),
                MarcaId = Convert.ToInt32(comboBoxMarca.SelectedValue),
                ColorId = Convert.ToInt32(comboBoxColor.SelectedValue),
                Tipo_equipoId = Convert.ToInt32(comboBoxTipo_Equipo.SelectedValue),
                Modelo = txtbModelo.Text,
                Cantidad = Convert.ToInt32(cantidadTextBox.Text),
                NumeroSerie = numero_SerieTextBox.Text,
                ServicesTag = serviceTagTextBox.Text,
                Procesador = procesadorTextBox.Text,
                MemoriaRAM = memoriaRAMTextBox.Text,
                Sistema_Operativo = sistema_OperativoTextBox.Text,
                Almacenamiento = Convert.ToInt32(almacenamientoComboBox.SelectedValue),
            });
            // this.inventarioSetTableAdapter.Fill(this.dbinventarioDataSet.InventarioSet);
            dataGridView1.DataSource = dataTable1TableAdapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataTable1TableAdapter.GetData();
        }
    }
}
