using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Inventario;
using Datos;
using Negocio.Inventario;
using Negocio;


namespace Negocio.Inventario
{
    public class InventarioCN
    {
        


        private InventarioDLC varinventario = new InventarioDLC();
        private InventarioDLC INventario
        {
            get
            {
                return varinventario ?? (varinventario = new InventarioDLC());
            }
        }

        public List<InventarioSet> GetInventario()
        {

            return INventario.GetInventario();
        }

        public void InsertInventario(InventarioSet inventario)
        {
            INventario.Insertinventario(inventario);
        }

        //---------------------------------
        private InventarioDLC varempleado = new InventarioDLC();
        private InventarioDLC EMpleado
        {
            get
            {
                return varempleado ?? (varempleado = new InventarioDLC());
            }
        }

        public List<EmpleadoSet> GetEmpleado()
        {

            return varempleado.GetEmpleado();
        }

        public void InsertarEmpleado(EmpleadoSet empleado)
        {
            varempleado.InsertEmpleado(empleado);
        }

        //------------------------------------------------------
        private InventarioDLC varmarca = new InventarioDLC();
        private InventarioDLC MArca
        {
            get
            {
                return varmarca ?? (varmarca = new InventarioDLC());
            }
        }

        public List<MarcaSet> GetMarca()
        {

            return varmarca.GetMarca();
        }

        public void InsertarMarca(MarcaSet marca)
        {
            varmarca.InsertMarca(marca);
        }

        //------------------------------------------------
        private InventarioDLC varproyecto = new InventarioDLC();
        private InventarioDLC PRoyecto
        {
            get
            {
                return varproyecto ?? (varproyecto = new InventarioDLC());
            }
        }

        public List<ProyectoSet> GetProyecto()
        {

            return varproyecto.GetProyecto();
        }

        public void InsertProyecto(ProyectoSet proyecto)
        {
            varproyecto.InsertProyecto(proyecto);
        }

        //-----------------------------------------------------------------
        private InventarioDLC varcolor = new InventarioDLC();
        private InventarioDLC COlor
        {
            get
            {
                return varcolor ?? (varcolor = new InventarioDLC());
            }
        }

        public List<ColorSet> GetColor()
        {

            return varcolor.GetColor();
        }

        public void InsertColor(ColorSet color)
        {
            varcolor.InsertColor(color);
        }

        public void BuscarColor(int buscarcolor)
        {
            varcolor.BuscarColor(buscarcolor);
        }




        //-------------------------------------------------
        private InventarioDLC vartipoequipo = new InventarioDLC();
        private InventarioDLC TipoEquipo
        {
            get
            {
                return vartipoequipo ?? (vartipoequipo = new InventarioDLC());
            }
        }

        public List<Tipo_equipoSet> GetTipoEquipo()
        {

            return vartipoequipo.GetTipoEquipo();
        }

        public void InsertTipoEquipo(Tipo_equipoSet tipoequipo)
        {
            vartipoequipo.InsertTipoEquipo(tipoequipo);
        }

        //--------------------------------------------------------
        private InventarioDLC actualizarinventario = new InventarioDLC();
        private InventarioDLC ACtualizarInventario
        {
            get
            {
                return actualizarinventario ?? (actualizarinventario = new InventarioDLC());
            }
        }



        public void MetActualizarEquipo(InventarioSet ActualizarEquipo)
        {
            actualizarinventario.ActualizarInventario(ActualizarEquipo);
        }
        //------------------------------------------------------------
        private InventarioDLC DelBorrarINV = new InventarioDLC();
        private InventarioDLC DELinventario
        {
            get
            {
                return DelBorrarINV ?? (DelBorrarINV = new InventarioDLC());
            }
        }



        public void BorrarInventario(InventarioSet BorrarInventario)
        {
            actualizarinventario.BorrarInventario(BorrarInventario);
        }
        //----------------------------------------------------------------------------
        private InventarioDLC actualizarEmpleado = new InventarioDLC();
        private InventarioDLC ACtualizarEmpleados
        {
            get
            {
                return actualizarEmpleado ?? (actualizarEmpleado = new InventarioDLC());
            }
        }



        public void ActualizarEmpleadosCN(EmpleadoSet ActualizarEmpleadoobj)
        {
            actualizarEmpleado.ActualizarEmpleado(ActualizarEmpleadoobj);
        }
        //------------------------------------------------------------
        private InventarioDLC DelVarEmpleado = new InventarioDLC();
        private InventarioDLC DELEmpleado
        {
            get
            {
                return DelVarEmpleado ?? (DelVarEmpleado = new InventarioDLC());
            }
        }



        public void BorrarInventario(EmpleadoSet BorrarEmpleadoobj2)
        {
            DelVarEmpleado.BorrarEmpleado(BorrarEmpleadoobj2);
        }
        //--------Siguiente metodo--------------------------------------------------------
        public void ActualizarColor(ColorSet colorsetact)
        {

            DelVarEmpleado.ActualizarColor(colorsetact);
        }
        public void BorrarColor(ColorSet ColorsetBorrar)
        {
            DelVarEmpleado.Borrarcolor(ColorsetBorrar);
        }

        // ------------------Borrar de Proyectos -----------------------
        public void ActualizarProyecto(ProyectoSet Project)
        {

            DelVarEmpleado.ActualizarProyecto(Project);
        }
        public void BorrarProyecto(ProyectoSet Project2)
        {
            DelVarEmpleado.BorrarProject(Project2);
        }

        ///--------------ACtualizar y Borrar Marca
        /// 
        public void ActualizarMarca(MarcaSet marca)
        {

            DelVarEmpleado.ActualizarMarca(marca);
        }
        public void BorrarMarca(MarcaSet marca2)
        {
            DelVarEmpleado.BorrarMarca(marca2);
        }

        // ---------------Tipo de EQuipo ACtualizar y Eliminar
        public void ActualizarTipo_Equipo(Tipo_equipoSet TipoEquipo)
        {

            DelVarEmpleado.ActualizarTIpoEquipo(TipoEquipo);
        }
        public void BorrarMarca(Tipo_equipoSet TipoEquipo2)
        {
            DelVarEmpleado.BorrarTipoEquipo(TipoEquipo2);
        }

        public void BorrarAsignacin(AsignacionSet Asignacion1)
        {
            DelVarEmpleado.BorrarAsignacion(Asignacion1);
        }
        public void InsertarAsignacion(AsignacionSet Asignacion2)
        {
            DelVarEmpleado.InsertAsignacion(Asignacion2);
        }
        public void ActualizacionAsignacion(AsignacionSet Asignacion3)
        {
            DelVarEmpleado.ActualizarAsignaciones(Asignacion3);
        }
        

    }
}

// ---------------Tipo de EQuipo insertar asignacion
            

         
                     
            ///-Fuera DE Clase---------------------------------------------------------
                    
           
            

    


   

       


       
       
       
    
