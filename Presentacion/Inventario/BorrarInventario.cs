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

namespace Presentacion.Inventario
{
    public partial class BorrarInventario : Form
    {
        public BorrarInventario()
        {
            InitializeComponent();
        }

        private void BorrarInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.DataTable1' table. You can move, or remove it, as needed.
            dvg.DataSource = dataTable1TableAdapter.GetData();

        }

        private void btnBotonBuscar_Click(object sender, EventArgs e)
        {
            if (txtAgregarInventario.Text != "" & comboBox1.Text != "")
            {

                string searchValue = txtAgregarInventario.Text;

                dvg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (dvg.DataSource as DataTable).DefaultView.RowFilter = comboBox1.Text + " LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                //  dataTable1BindingSource.RemoveFilter();
                MessageBox.Show("Debes seleccionar el criterio de busqueda y Escribir en Buscar");


            }
        }
        private InventarioCN umanager = new InventarioCN();
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            umanager.BorrarInventario(new InventarioSet()
            {

                Id = Convert.ToInt32(idTextBox.Text),
            });
            dvg.DataSource = dataTable1TableAdapter.GetData();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dvg.DataSource = dataTable1TableAdapter.GetData();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!dvg.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow dgv = dvg.Rows[e.RowIndex];
                idTextBox.Text = dgv.Cells[0].Value.ToString();
                cantidadTextBox.Text = dgv.Cells[1].Value.ToString();
                tipo_EquipoTextBox.Text = dgv.Cells[2].Value.ToString();
                marcaTextBox.Text = dgv.Cells[3].Value.ToString();
                modeloTextBox.Text = dgv.Cells[4].Value.ToString();
                colorTextBox.Text = dgv.Cells[5].Value.ToString();
                servicesTagTextBox.Text = dgv.Cells[6].Value.ToString();
                numeroSerieTextBox.Text = dgv.Cells[7].Value.ToString();
                procesadorTextBox.Text = dgv.Cells[8].Value.ToString();
                memoriaRAMTextBox.Text = dgv.Cells[9].Value.ToString();
                oSTextBox.Text = dgv.Cells[10].Value.ToString();
                almacenamientoTextBox.Text = dgv.Cells[11].Value.ToString();


            }
        }
    }
}
