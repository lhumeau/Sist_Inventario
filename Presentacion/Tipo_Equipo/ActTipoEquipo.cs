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

namespace Presentacion.Tipo_Equipo
{
    public partial class ActTipoEquipo : Form
    {
        public ActTipoEquipo()
        {
            InitializeComponent();
        }

        private void tipo_equipoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipo_equipoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void ActTipoEquipo_Load(object sender, EventArgs e)
        {
            tipo_equipoSetDataGridView.DataSource = tipo_equipoSetTableAdapter.GetData();

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

                tipo_equipoSetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataTable1BindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                (tipo_equipoSetDataGridView.DataSource as DataTable).DefaultView.RowFilter = comboBox1.Text + " LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                //  dataTable1BindingSource.RemoveFilter();
                MessageBox.Show("Debes seleccionar el criterio de busqueda y Escribir en Buscar");


            }
        }

        private void tipo_equipoSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (!tipo_equipoSetDataGridView.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow dgv = tipo_equipoSetDataGridView.Rows[e.RowIndex];
                idTextBox.Text = dgv.Cells[0].Value.ToString();
                descripcionTextBox.Text = dgv.Cells[1].Value.ToString();
            }
           
        }
        InventarioDLC umanager = new InventarioDLC();
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            umanager.ActualizarTIpoEquipo(new Datos.Tipo_equipoSet()
            {
                Id = Convert.ToInt32(idTextBox.Text),
                descripcion = descripcionTextBox.Text,

            });
            tipo_equipoSetDataGridView.DataSource = tipo_equipoSetTableAdapter.GetData();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            tipo_equipoSetDataGridView.DataSource = tipo_equipoSetTableAdapter.GetData();
        }

        private void ActTipoEquipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
