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
    
    public partial class ProyectoSet
    {
        public ProyectoSet()
        {
            this.EmpleadoSets = new HashSet<EmpleadoSet>();
            this.AsignacionSets = new HashSet<AsignacionSet>();
        }
    
        public int Id { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<EmpleadoSet> EmpleadoSets { get; set; }
        public virtual ICollection<AsignacionSet> AsignacionSets { get; set; }
    }
}
