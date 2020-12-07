//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionWebApiRest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receptor_Solicitudes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receptor_Solicitudes()
        {
            this.Incidencias = new HashSet<Incidencias>();
            this.Solicitud_Requerimientos = new HashSet<Solicitud_Requerimientos>();
        }
    
        public int Codigo_Receptor { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Direccion { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string Correo { get; set; }
        public string DPI { get; set; }
        public int Codigo_Perfil { get; set; }
        public string Pasword { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencias> Incidencias { get; set; }
        public virtual Perfiles Perfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud_Requerimientos> Solicitud_Requerimientos { get; set; }
    }
}
