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
using Negocio.Inventario;
using Datos;
namespace Presentacion.Gestion
{
    public partial class EliminarColor : Form
    {
        public EliminarColor()
        {
            InitializeComponent();
        }

        private void colorSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colorSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }
        Datos.DbinventarioDataSet ds = new Datos.DbinventarioDataSet();
        Datos.DATOSDATASETTableAdapters.ColorSetTableAdapter ds2 = new Datos.DATOSDATASETTableAdapters.ColorSetTableAdapter();
        private void EliminarColor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.ColorSet' table. You can move, or remove it, as needed.
            colorSetDataGridView.DataSource = ds2.GetData();
            
        }

        private void colorSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = colorSetDataGridView.Rows[e.RowIndex];
            idTextBox.Text = dgv.Cells[0].Value.ToString();
            descripcionTextBox.Text = dgv.Cells[1].Value.ToString();

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

                colorSetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (colorSetDataGridView.DataSource as DataTable).DefaultView.RowFilter = comboBox1.Text + " LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                //  dataTable1BindingSource.RemoveFilter();
                MessageBox.Show("Debes seleccionar el criterio de busqueda y Escribir en Buscar");


            }
        }
        InventarioDLC umanager = new InventarioDLC();
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            umanager.Borrarcolor(new Datos.ColorSet()
            {
                Id = Convert.ToInt32(idTextBox.Text),

            });
            colorSetDataGridView.DataSource = colorSetTableAdapter.GetData();
        }

        private void EliminarColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}