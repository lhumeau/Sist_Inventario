using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Inventario;


namespace Presentacion.Marca
{
    public partial class BorrarMarca : Form
    {
        public BorrarMarca()
        {
            InitializeComponent();
        }

        private void inventarioSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.inventarioSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void marcaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void BorrarMarca_Load(object sender, EventArgs e)
        {
            marcaSetDataGridView.DataSource = marcaSetTableAdapter.GetData();

        }

        private void marcaSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!marcaSetDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow dgv = marcaSetDataGridView.Rows[e.RowIndex];
                idTextBox.Text = dgv.Cells[0].Value.ToString();
                descripcionTextBox.Text = dgv.Cells[1].Value.ToString();
            }
           
        }

        private void btnBotonBuscar_Click(object sender, EventArgs e)
        {
            if (txtAgregarInventario.Text != "" & comboBox1.Text != "")
            {

                string searchValue = txtAgregarInventario.Text;

                marcaSetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (marcaSetDataGridView.DataSource as DataTable).DefaultView.RowFilter = comboBox1.Text + " LIKE '" + searchValue + "%'";
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
        InventarioDLC umanger = new InventarioDLC();
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            umanger.BorrarMarca(new Datos.MarcaSet()
            {
                Id = Convert.ToInt32(idTextBox.Text),
                
                


            });

            marcaSetDataGridView.DataSource = marcaSetTableAdapter.GetData();
        }

        private void BorrarMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
