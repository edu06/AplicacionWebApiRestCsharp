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
    
    public partial class sp_ver_todosincidencias_Result
    {
        public int Codigo_Incidencia { get; set; }
        public int Codigo_Receptor { get; set; }
        public int Codigo_Solicitante { get; set; }
        public string Titulo_Incidencia { get; set; }
        public string Descripcion { get; set; }
        public string Adjuntos { get; set; }
        public int Codigo_Tecnico_Asignado { get; set; }
        public System.DateTime Fecha_Creacion { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
