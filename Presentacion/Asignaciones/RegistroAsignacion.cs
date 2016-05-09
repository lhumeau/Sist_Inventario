using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Asignaciones
{
    public partial class RegistroAsignacion : Form
    {
        public RegistroAsignacion()
        {
            InitializeComponent();
        }

        private void RegistroAsignacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.DTasignaciones' table. You can move, or remove it, as needed.
            this.dTasignacionesTableAdapter.Fill(this.dbinventarioDataSet.DTasignaciones);

        }
    }
}
