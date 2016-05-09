using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class GestionTraspaso : Form
    {
        public GestionTraspaso()
        {
            InitializeComponent();
        }

        private void historial_AsignacionesSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historial_AsignacionesSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void historial_AsignacionesSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.historial_AsignacionesSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbinventarioDataSet);

        }

        private void GestionTraspaso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.Historial_AsignacionesSet' table. You can move, or remove it, as needed.
            this.historial_AsignacionesSetTableAdapter.Fill(this.dbinventarioDataSet.Historial_AsignacionesSet);

        }
    }
}
