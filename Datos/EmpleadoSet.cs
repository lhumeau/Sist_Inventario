//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpleadoSet
    {
        public EmpleadoSet()
        {
            this.Historial_AsignacionesSet = new HashSet<Historial_AsignacionesSet>();
            this.AsignacionSets = new HashSet<AsignacionSet>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int ProyectoId { get; set; }
        public int Activo { get; set; }
    
        public virtual ICollection<Historial_AsignacionesSet> Historial_AsignacionesSet { get; set; }
        public virtual ProyectoSet ProyectoSet { get; set; }
        public virtual ICollection<AsignacionSet> AsignacionSets { get; set; }
    }
}
