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
    
    public partial class Reserva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserva()
        {
            this.ReservaHabitacion = new HashSet<ReservaHabitacion>();
        }
    
        public string idReserva { get; set; }
        public Nullable<int> idClienteReserva { get; set; }
        public Nullable<System.DateTime> fechaInicioReserva { get; set; }
        public Nullable<System.DateTime> fechaFinalReserva { get; set; }
        public Nullable<decimal> precioTotalReserva { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaHabitacion> ReservaHabitacion { get; set; }
    }
}
