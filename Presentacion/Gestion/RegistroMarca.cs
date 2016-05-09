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

namespace Presentacion.Gestion
{
    public partial class RegistroMarca : Form
    {
        public RegistroMarca()
        {
            InitializeComponent();
        }

        private void marcaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marcaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void RegistroMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.MarcaSet' table. You can move, or remove it, as needed.
            this.marcaSetTableAdapter.Fill(this.dbinventarioDataSet.MarcaSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }
        private InventarioCN umanager = new InventarioCN();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            umanager.InsertarMarca(new MarcaSet()
            {
               
               descripcion = descripcionTextBox.Text,
               

            });
            this.marcaSetTableAdapter.Fill(this.dbinventarioDataSet.MarcaSet);
        }

        private void RegistroMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
