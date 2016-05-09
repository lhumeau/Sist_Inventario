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
    public partial class RegistroInventario : Form
    {
        public RegistroInventario()
        {
            InitializeComponent();
        }
        //private string list = "";
        private void inventarioSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void inventarioSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.inventarioSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }
        private InventarioCN umanager = new InventarioCN();
        DataTable1TableAdapter dbta = new DataTable1TableAdapter(); 
        private void AgregarInventarioPRE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dbinventarioDataSet.DataTable1);
        

            // You will get selectedCells count 1 here
         //   DataGridViewSelectedCellCollection selectedCells = inventarioSetDataGridView.SelectedCells;
            // Call clearSelection 
           // inventarioSetDataGridView.ClearSelection();
            // Now You will get selectedCells count 0 here
         //   selectedCells = inventarioSetDataGridView.SelectedCells;

            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");


            // TODO: This line of code loads data into the 'dbinventarioDataSet.ColorSet' table. You can move, or remove it, as needed.
            this.colorSetTableAdapter.Fill(this.dbinventarioDataSet.ColorSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.EmpleadoSet' table. You can move, or remove it, as needed.
            this.empleadoSetTableAdapter.Fill(this.dbinventarioDataSet.EmpleadoSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.AsignacionSet' table. You can move, or remove it, as needed.
            this.asignacionSetTableAdapter.Fill(this.dbinventarioDataSet.AsignacionSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.Tipo_equipoSet' table. You can move, or remove it, as needed.
            this.tipo_equipoSetTableAdapter.Fill(this.dbinventarioDataSet.Tipo_equipoSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.MarcaSet' table. You can move, or remove it, as needed.
            this.marcaSetTableAdapter.Fill(this.dbinventarioDataSet.MarcaSet);
            



            // TODO: This line of code loads data into the 'dbinventarioDataSet.InventarioSet' table. You can move, or remove it, as needed.
           // this.inventarioSetTableAdapter.Fill(this.dbinventarioDataSet.InventarioSet);
            //inventarioSetDataGridView.DataSource = inventarioSetTableAdapter.GetData();

            // Carga la informacion al datagrid y no lo friza como el fill
           
            dataGridView1.DataSource = dbta.GetData();
            
      

            asignacionIdComboBox.SelectedIndex = 0;
            marcaIdComboBox.SelectedIndex = 0;
            colorIdComboBox.SelectedIndex = 0;
            tipo_equipoIdComboBox.SelectedIndex = 0;

           
         //   inventarioSetDataGridView.CurrentCell = null;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            umanager.InsertInventario(new InventarioSet()
            {
                MarcaId = Convert.ToInt32(marcaIdComboBox.SelectedValue),
                ColorId = Convert.ToInt32(colorIdComboBox.SelectedValue),
                Tipo_equipoId = Convert.ToInt32(tipo_equipoIdComboBox.SelectedValue),
                Modelo = modeloTextBox.Text,
                Cantidad = Convert.ToInt32(cantidadTextBox.Text),
                NumeroSerie = numeroSerieTextBox.Text,
                ServicesTag = servicesTagTextBox.Text,
                Procesador = procesadorTextBox.Text,
                MemoriaRAM = memoriaRAMTextBox.Text,
                Sistema_Operativo = sistema_OperativoTextBox.Text,
                Almacenamiento = Convert.ToInt32(almacenamientoComboBox.SelectedValue),
            });
           // this.inventarioSetTableAdapter.Fill(this.dbinventarioDataSet.InventarioSet);
            dataGridView1.DataSource = dbta.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }
       
       
        private void button1_Click_1(object sender, EventArgs e)
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

        

        private void LlenarDatagrid(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.InventarioSet' table. You can move, or remove it, as needed.
            this.inventarioSetTableAdapter.Fill(this.dbinventarioDataSet.InventarioSet);
        }

        private void inventarioSetDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            DataGridViewComboBoxEditingControl dgvCombo = e.Control as DataGridViewComboBoxEditingControl;

            if (dgvCombo != null)
            {
                //
                // se remueve el handler previo que pudiera tener asociado, a causa ediciones previas de la celda
                // evitando asi que se ejecuten varias veces el evento
                //
                dgvCombo.SelectedIndexChanged -= new EventHandler(dvgCombo_SelectedIndexChanged);

                dgvCombo.SelectedIndexChanged += new EventHandler(dvgCombo_SelectedIndexChanged);
            }

        }
        private void dvgCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            // se recupera el valor del combo
            // a modo de ejemplo se escribe en consola el valor seleccionado
            //
            ComboBox combo = sender as ComboBox;

            Console.WriteLine(combo.SelectedValue);

            //
            // se accede a la fila actual, para trabajr con otor de sus campos
            // en este caso se marca el check si se cambia la seleccion
            //
        //    DataGridViewRow row = inventarioSetDataGridView.CurrentRow;

         //   DataGridViewCheckBoxCell cell = row.Cells["Seleccionado"] as DataGridViewCheckBoxCell;
            //cell.Value = true;
        }


        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbta.GetData();

        }

        private void RegistroInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }


    }
}
