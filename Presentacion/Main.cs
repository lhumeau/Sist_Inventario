using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Inventario;
using Presentacion.Gestion;
using Presentacion.Reportes;
using Presentacion.Empleado;
using Presentacion.Proyecto;
using Presentacion.Marca;
using Presentacion.Tipo_Equipo;
using Presentacion.Reportes.ReporteDetEmpleado;
using Presentacion.Asignaciones;



namespace Presentacion
{
    public partial class Main : Form
    {
        //Instancias de objetos
        RegistroInventario agregarinventario = new RegistroInventario();
        RegistroEmpleado regempleado = new RegistroEmpleado();
        RegistroTipo_Equipo regtipo_equipo = new RegistroTipo_Equipo();
        RegistroMarca regmarca = new RegistroMarca();
        RegistroColor regcolor = new RegistroColor();
        RegistroProyecto regproyecto = new RegistroProyecto();
        RegistroTipo_Equipo regtipoequipo = new RegistroTipo_Equipo();
        RegistroInventario reginventario = new RegistroInventario();
        ReporteEquipoAsignado regeqasig = new ReporteEquipoAsignado();
       // ActInventario actinventario = new ActInventario();
        BorrarInventario DelRegInventario = new BorrarInventario();
        ActualizarInventario ActEmpleado = new ActualizarInventario();
        BorrarEmpleado DelRegEmpleado = new BorrarEmpleado();
        EliminarColor DelColor = new EliminarColor();
        ActualizarColor ActColor = new ActualizarColor();
        DelProyecto DelProyecto = new DelProyecto();
        ActProyecto ActProyecto = new ActProyecto();
        ActualizarMArca actmarca = new ActualizarMArca();
        BorrarMarca borrarmarca = new BorrarMarca();
        ActTipoEquipo actTipoEquipo = new ActTipoEquipo();
        DelTipoEquipo DelTipoEquipo = new DelTipoEquipo();
        ActualizarAsignaciones regActualizaciones = new ActualizarAsignaciones();
        BorrarAsignaciones delasignaciones = new BorrarAsignaciones();
        updateAsignaciones updateASignaciones = new updateAsignaciones();

       
        //WinFormReportePorProyecto WFReportPorProyecto = new WinFormReportePorProyecto();
     

        
        public Main()
        {
            InitializeComponent();
        }
        

        private void activoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            agregarinventario.Show();
            agregarinventario.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            agregarinventario.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regempleado.Show();
            regempleado.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regempleado.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
            
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regmarca.Show();
            regmarca.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regmarca.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regcolor.Show();
            regcolor.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regcolor.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");

        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regproyecto.Show();
            regproyecto.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regproyecto.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");

        }

        private void tipoEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regtipoequipo.Show();
            regtipoequipo.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regtipoequipo.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regproyecto.Show();
            regproyecto.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regproyecto.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reginventario.Show();
            reginventario.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            reginventario.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");

            
        }
       
        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regeqasig.Show();
            regeqasig.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regeqasig.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActEmpleado.Show();
            ActEmpleado.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            ActEmpleado.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void activoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelRegInventario.Show();
            DelRegInventario.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            DelRegInventario.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");

        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelRegEmpleado.Show();
            DelRegEmpleado.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            DelRegEmpleado.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void empleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ActEmpleado.Show();
            ActEmpleado.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            ActEmpleado.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelColor.Show();
            DelColor.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            DelColor.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void colorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ActColor.Show();
            ActColor.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            ActColor.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void proyectoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DelProyecto.Show();
            DelProyecto.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            DelProyecto.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void proyectoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActProyecto.Show();
            ActProyecto.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            ActProyecto.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            borrarmarca.Show();
            borrarmarca.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            borrarmarca.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");

        }

        private void marcaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            actmarca.Show();
            actmarca.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            actmarca.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void tIpoEquipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelTipoEquipo.Show();
            DelTipoEquipo.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            DelTipoEquipo.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
           
                
        }

        private void tipoEquipoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            actTipoEquipo.Show();
            actTipoEquipo.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            actTipoEquipo.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
           
        }

        private void equiposPorProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        GenerarReporte RepEmpleado = new GenerarReporte();
        private void porUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepEmpleado.Show();
        }

        private void asignaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regActualizaciones.Show();
            regActualizaciones.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            regActualizaciones.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");

        }

        private void asignaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delasignaciones.Show();
            delasignaciones.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            delasignaciones.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }

        private void asignaciónToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updateASignaciones.Show();
            updateASignaciones.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            updateASignaciones.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
        }
    }
}
