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
    public partial class RegistroTipo_Equipo : Form
    {
        public RegistroTipo_Equipo()
        {
            InitializeComponent();
        }

        private void tipo_equipoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipo_equipoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void Tipo_Equipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.Tipo_equipoSet' table. You can move, or remove it, as needed.
            this.tipo_equipoSetTableAdapter.Fill(this.dbinventarioDataSet.Tipo_equipoSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }
        private InventarioCN umanager = new InventarioCN();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            umanager.InsertTipoEquipo(new Tipo_equipoSet()
            {
                descripcion = descripcionTextBox.Text,

            });

            this.tipo_equipoSetTableAdapter.Fill(this.dbinventarioDataSet.Tipo_equipoSet);
        }

        private void RegistroTipo_Equipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }
    }
}
