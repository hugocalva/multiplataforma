//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manual_inicioUTTT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inscripcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inscripcion()
        {
            this.Inscripcion_Actividad = new HashSet<Inscripcion_Actividad>();
        }
    
        public int id { get; set; }
        public int idTaller { get; set; }
        public int idAlumno { get; set; }
        public System.DateTime fechaInscripcion { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripcion_Actividad> Inscripcion_Actividad { get; set; }
        public virtual Taller Taller { get; set; }
    }
}
