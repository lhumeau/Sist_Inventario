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
    public partial class RegistroProyecto : Form
    {
        public RegistroProyecto()
        {
            InitializeComponent();
        }

        private void proyectoSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectoSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void RegistroProyecto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.ProyectoSet' table. You can move, or remove it, as needed.
            this.proyectoSetTableAdapter.Fill(this.dbinventarioDataSet.ProyectoSet);

        }
        private InventarioCN umanager = new InventarioCN();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            umanager.InsertProyecto(new ProyectoSet()
            {
                descripcion = descripcionTextBox.Text,
            });
            this.proyectoSetTableAdapter.Fill(this.dbinventarioDataSet.ProyectoSet);

        }

        private void RegistroProyecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hiding the window, because closing it makes the window unaccessible.
            this.Hide();
            this.Parent = null;
            e.Cancel = true; //hides the form, cancels closing event
        }

    }
}
