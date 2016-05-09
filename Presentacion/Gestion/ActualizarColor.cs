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



namespace Presentacion.Gestion
{
    public partial class ActualizarColor : Form
    {
        public ActualizarColor()
        {
            InitializeComponent();
        }

        private void ActualizarColor_Load(object sender, EventArgs e)
        {
            colorSetDataGridView.DataSource = colorSetTableAdapter.GetData();
        
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        InventarioDLC umanger = new InventarioDLC();
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            umanger.ActualizarColor(new Datos.ColorSet()
            {
                Id = Convert.ToInt32(idTextBox.Text),
                descripcion = descripcionTextBox.Text,


            });

            colorSetDataGridView.DataSource = colorSetTableAdapter.GetData();
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

        private void ActualizarColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
