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
    public partial class RegistroColor : Form
    {
        public RegistroColor()
        {
            InitializeComponent();
        }

        private void colorSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colorSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void RegistroColor_Load(object sender, EventArgs e)
        {

            colorSetDataGridView.DataSource = colorSetTableAdapter.GetData();
            

        }
        private InventarioCN umanager = new InventarioCN();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            umanager.InsertColor(new ColorSet()
            {
                descripcion = descripcionTextBox.Text,
            });
            this.colorSetTableAdapter.Fill(this.dbinventarioDataSet.ColorSet);

        }

        private void BtnBuscarColor_Click(object sender, EventArgs e)
        {
            if (txtBuscarColor.Text != "")
            {
                string searchValue = txtBuscarColor.Text;

                colorSetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                colorSetBindingSource.Filter = "nombre LIKE '" + searchValue + "%'";
                //here you can do selection if you need
            }
            else
            {
                colorSetBindingSource.RemoveFilter();


            }

        }

        private void RegistroColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
