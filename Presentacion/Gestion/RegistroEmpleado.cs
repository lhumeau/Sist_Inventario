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
using Negocio.Inventario;
using System.Data.Sql;
using System.Data.Entity;


namespace Presentacion.Gestion
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }
       
        private void empleadoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }
        private InventarioCN umanager = new InventarioCN();
        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.ProyectoSet' table. You can move, or remove it, as needed.
            this.proyectoSetTableAdapter.Fill(this.dbinventarioDataSet.ProyectoSet);
            // TODO: This line of code loads data into the 'dbinventarioDataSet.EmpleadoSet' table. You can move, or remove it, as needed.
            //this.empleadoSetTableAdapter.Fill(this.dbinventarioDataSet.EmpleadoSet);
            empleadoSetDataGridView.DataSource = empleadoSetTableAdapter.GetData();

        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //int activo = Convert.ToInt32(proyectoIdComboBox.SelectedValue);
            umanager.InsertarEmpleado(new EmpleadoSet()
            {
              Nombre = nombreTextBox.Text,
              Apellido = apellidoTextBox.Text,
              Cedula = cedulaTextBox.Text,
              ProyectoId = Convert.ToInt32(proyectoIdComboBox.SelectedValue),
              Activo = Convert.ToInt32(activoTextBox.Text),
              
            });
            empleadoSetDataGridView.DataSource = empleadoSetTableAdapter.GetData();
            //this.empleadoSetTableAdapter.Fill(this.dbinventarioDataSet.EmpleadoSet);
            
            

        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text != "")
            {
                string searchValue = txtBuscarEmpleado.Text;

                empleadoSetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                empleadoSetBindingSource.Filter = "Nombre LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                empleadoSetBindingSource.RemoveFilter();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            this.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void RegistroEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
