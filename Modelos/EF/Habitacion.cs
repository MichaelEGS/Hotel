//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Habitacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Habitacion()
        {
            this.Reservacion = new HashSet<Reservacion>();
        }
    
        public int IdHabitacion { get; set; }
        public string NumeroHabitacion { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public bool IsAvailable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservacion> Reservacion { get; set; }
    }
}
