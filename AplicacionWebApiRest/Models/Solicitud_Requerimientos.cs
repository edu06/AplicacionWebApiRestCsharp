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
    
    public partial class Solicitud_Requerimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitud_Requerimientos()
        {
            this.Comentarios_Requerimientos = new HashSet<Comentarios_Requerimientos>();
        }
    
        public int Codigo_Requerimientos { get; set; }
        public int Codigo_Receptor { get; set; }
        public int Codigo_Solicitante { get; set; }
        public string Titulo_Requerimiento { get; set; }
        public string Descripcion { get; set; }
        public string Adjuntos { get; set; }
        public int Codigo_Tecnico_Asignado { get; set; }
        public System.DateTime Fecha_Creacion { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentarios_Requerimientos> Comentarios_Requerimientos { get; set; }
        public virtual Receptor_Solicitudes Receptor_Solicitudes { get; set; }
        public virtual Tecnico_Soporte Tecnico_Soporte { get; set; }
    }
}
