//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServicioTipoHabitacion
    {
        public int idServicioTipoHabitacion { get; set; }
        public Nullable<int> idServicioServicioTipoHabitacion { get; set; }
        public Nullable<int> idTipoHabitacionServicioTipoHabitacion { get; set; }
    
        public virtual Servicio Servicio { get; set; }
        public virtual TipoHabitacion TipoHabitacion { get; set; }
    }
}
