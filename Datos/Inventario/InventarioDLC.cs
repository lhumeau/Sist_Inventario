using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Datos.Inventario
{
    public class InventarioDLC
    {
        // private string strCodigo;
        public DATOSDATASET datasetdlc { get; set; }
        public DbinventarioDataSet dbinventariodataset;
        
        
        public List<InventarioSet> GetInventario()
        {
            List<InventarioSet> inventario = new List<InventarioSet>();
            using (var db = new Datos.DbinventarioEntities())
            {
                inventario = db.InventarioSets.ToList();
            }
            return inventario;
        }
        

       

        public void Insertinventario(InventarioSet inventario)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                db.InventarioSets.Add(inventario);
                db.SaveChanges();
            }
        }

        public void AgregarInventario(int Marcaid, int ColorId, int tipo_Equipoid,
          string modelo, int asignacionid, int cantidad)
        {
            using (DbinventarioEntities Context = new DbinventarioEntities())
            {
                InventarioSet invetario = new InventarioSet()
                {
                    MarcaId = Marcaid,
                    ColorId = ColorId,
                    Tipo_equipoId = tipo_Equipoid,
                    Modelo = modelo,
                    Cantidad = cantidad,
                };
                Context.InventarioSets.Add(invetario);
                Context.SaveChanges();
            }


        }
        public List<EmpleadoSet> GetEmpleado()
        {
            List<EmpleadoSet> Empleado = new List<EmpleadoSet>();
            using (var db = new Datos.DbinventarioEntities())
            {
                Empleado = db.EmpleadoSets.ToList();
            }
            return Empleado;
        }


        public void InsertEmpleado(EmpleadoSet empleado)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                db.EmpleadoSets.Add(empleado);
                db.SaveChanges();
            }
        }
        //-----------------------------------------------------------

        public List<MarcaSet> GetMarca()
        {
            List<MarcaSet> marca = new List<MarcaSet>();
            using (var db = new Datos.DbinventarioEntities())
            {
                marca = db.MarcaSets.ToList();
            }
            return marca;
        }


        public void InsertMarca(MarcaSet marca)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                db.MarcaSets.Add(marca);
                db.SaveChanges();
            }
        }
        //------------------------------------------------------
        public List<ProyectoSet> GetProyecto()
        {
            List<ProyectoSet> proyecto = new List<ProyectoSet>();
            using (var db = new Datos.DbinventarioEntities())
            {
                proyecto = db.ProyectoSets.ToList();
            }
            return proyecto;
        }


        public void InsertProyecto(ProyectoSet proyecto)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                db.ProyectoSets.Add(proyecto);
                db.SaveChanges();
            }
        }

        //----------------------------------------------------------

        public List<ColorSet> GetColor()
        {
            List<ColorSet> color = new List<ColorSet>();
            using (var db = new Datos.DbinventarioEntities())
            {
                color = db.ColorSets.ToList();
            }
            return color;
        }


        public void InsertColor(ColorSet color)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                db.ColorSets.Add(color);
                db.SaveChanges();
            }
        }

        public ColorSet BuscarColor(int codigo)
        {
            using (var context = new DbinventarioEntities())
            {
                var strSQL = from p in context.ColorSets
                             where p.Id == codigo
                             select p;
                return strSQL.FirstOrDefault();
            }
        }
        //---------------------------------------------------

        public List<Tipo_equipoSet> GetTipoEquipo()
        {
            List<Tipo_equipoSet> Tipo_Equipo = new List<Tipo_equipoSet>();
            using (var db = new Datos.DbinventarioEntities())
            {
                Tipo_Equipo = db.Tipo_equipoSet.ToList();
            }
            return Tipo_Equipo;
        }


        public void InsertTipoEquipo(Tipo_equipoSet TipoEquipo)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                db.Tipo_equipoSet.Add(TipoEquipo);
                db.SaveChanges();
            }
        }
        //---------------------------------------------------------------
        public void ActualizarInventario(InventarioSet ActInventario)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stub = db.InventarioSets.FirstOrDefault(c => c.Id == ActInventario.Id);
                    stub.MarcaId = ActInventario.MarcaId;
                    stub.MarcaId = ActInventario.MarcaId;
                    stub.Modelo = ActInventario.Modelo;
                    stub.NumeroSerie = ActInventario.NumeroSerie;
                    stub.ServicesTag = ActInventario.ServicesTag;
                    stub.Tipo_equipoId = ActInventario.Tipo_equipoId;
                    stub.ColorId = ActInventario.ColorId;
                    stub.Cantidad = ActInventario.Cantidad;


                    //   db.InventarioSets.Attach(db.InventarioSets.Single(c => c.Id == ActInventario.Id));

                    //  db.InventarioSets.Add(ActInventario);
                    db.SaveChanges();

                }
                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
        ///-----------------------------------------------------------------------------
        public void BorrarInventario(InventarioSet BorrarInventario)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stud = (from s1 in db.InventarioSets
                                where s1.Id == BorrarInventario.Id
                                select s1).FirstOrDefault();
                    db.InventarioSets.Remove(stud);
                    db.SaveChanges();

                }

                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
        //--------------------------------------------------------------------------
        public void ActualizarEmpleado(EmpleadoSet Empleadoobj)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stub = db.EmpleadoSets.FirstOrDefault(c => c.Id == Empleadoobj.Id);
                    stub.Id = Empleadoobj.Id;
                    stub.Nombre = Empleadoobj.Nombre;
                    stub.Apellido = Empleadoobj.Apellido;
                    stub.Cedula = Empleadoobj.Cedula;
                    stub.ProyectoId = Empleadoobj.ProyectoId;
                    stub.Activo = Empleadoobj.Activo;



                    //   db.InventarioSets.Attach(db.InventarioSets.Single(c => c.Id == ActInventario.Id));

                    //  db.InventarioSets.Add(ActInventario);
                    db.SaveChanges();

                }
                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
        ///-----------------------------------------------------------------------------
        public void BorrarEmpleado(EmpleadoSet BorrarEmpleado)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stud = (from s1 in db.EmpleadoSets
                                where s1.Id == BorrarEmpleado.Id
                                select s1).FirstOrDefault();
                    db.EmpleadoSets.Remove(stud);
                    db.SaveChanges();

                }

                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }
        }
        //------------------------------------------------------------------
        public void ActualizarColor(ColorSet color)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stub = db.ColorSets.FirstOrDefault(c => c.Id == color.Id);
                    stub.Id = color.Id;
                    stub.descripcion = color.descripcion;

                    db.SaveChanges();

                }
                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
        ///-----------------------------------------------------------------------------
        public void Borrarcolor(ColorSet colorsets2)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stud = (from s1 in db.ColorSets
                                where s1.Id == colorsets2.Id
                                select s1).FirstOrDefault();
                    db.ColorSets.Remove(stud);
                    db.SaveChanges();

                }

                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }
        }
        // Borrar Proyectos -----------------------------

        public void ActualizarProyecto(ProyectoSet Project)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stub = db.ColorSets.FirstOrDefault(c => c.Id == Project.Id);
                    stub.Id = Project.Id;
                    stub.descripcion = Project.descripcion;

                    db.SaveChanges();

                }
                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
        ///-----------------------------------------------------------------------------
        public void BorrarProject(ProyectoSet Project2)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stud = (from s1 in db.ProyectoSets
                                where s1.Id == Project2.Id
                                select s1).FirstOrDefault();
                    db.ProyectoSets.Remove(stud);
                    db.SaveChanges();

                }

                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }
            }
        }



        /// Actualizar y Borrar MArca Van ACa --------------------------------
        public void ActualizarMarca(MarcaSet Marca)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stub = db.MarcaSets.FirstOrDefault(c => c.Id == Marca.Id);
                    stub.Id = Marca.Id;
                    stub.descripcion = Marca.descripcion;

                    db.SaveChanges();

                }
                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
        ///-----------------------------------------------------------------------------
        public void BorrarMarca(MarcaSet marca2)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stud = (from s1 in db.MarcaSets
                                where s1.Id == marca2.Id
                                select s1).FirstOrDefault();
                    db.MarcaSets.Remove(stud);
                    db.SaveChanges();

                }

                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }
            }
        }
        /// Actualizar y Borrar MArca Van ACa --------------------------------
        public void ActualizarTIpoEquipo(Tipo_equipoSet Tipo_Equipo)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stub = db.Tipo_equipoSet.FirstOrDefault(c => c.Id == Tipo_Equipo.Id);
                    stub.Id = Tipo_Equipo.Id;
                    stub.descripcion = Tipo_Equipo.descripcion;

                    db.SaveChanges();

                }
                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }
        ///-----------------------------------------------------------------------------
        public void BorrarTipoEquipo(Tipo_equipoSet TIpo_Equipo2)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stud = (from s1 in db.Tipo_equipoSet
                                where s1.Id == TIpo_Equipo2.Id
                                select s1).FirstOrDefault();
                    db.Tipo_equipoSet.Remove(stud);
                    db.SaveChanges();

                }

                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }
            }
        }

        public void InsertAsignacion(AsignacionSet Asignacion)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                db.AsignacionSets.Add(Asignacion);
                db.SaveChanges();
            }
        }
        public void BorrarAsignacion(AsignacionSet Asignacion2)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stud = (from s1 in db.AsignacionSets
                                where s1.Id == Asignacion2.Id
                                select s1).FirstOrDefault();
                    db.AsignacionSets.Remove(stud);
                    db.SaveChanges();

                }

                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }
            }

        }
        public void ActualizarAsignaciones(AsignacionSet Asignaciones3)
        {
            using (var db = new Datos.DbinventarioEntities())
            {
                try
                {
                    var stub = db.AsignacionSets.FirstOrDefault(c => c.Id == Asignaciones3.Id);
                    stub.Fecha_Asignacion = Asignaciones3.Fecha_Asignacion;
                    stub.InventarioID = Asignaciones3.InventarioID;

                    db.SaveChanges();

                }
                catch (UpdateException ex)
                {
                    Console.WriteLine(ex.ToString());

                }


            }

        }


        //-------------------------------------------------------------


    }
}
 

