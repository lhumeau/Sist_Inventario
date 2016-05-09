using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes.ReporteDetEmpleado
{
    public partial class GenerarReporte : Form
    {
        public GenerarReporte()
        {
            InitializeComponent();
        }

        private void GenerarReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbinventarioDataSet.EmpleadoSet' table. You can move, or remove it, as needed.
            this.empleadoSetTableAdapter.Fill(this.dbinventarioDataSet.EmpleadoSet);

        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //MostrarReporte Mostrar = new MostrarReporte();
//            Mostrar.idempleado = Convert.ToInt32(comboBoxSeleccionarEmpleado.SelectedItem);
  //          Mostrar.ShowDialog();
        }
    }
}
