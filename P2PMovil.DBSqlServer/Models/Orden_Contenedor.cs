//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P2PMovil.DBSqlServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orden_Contenedor
    {
        public int OrdenContenedorID { get; set; }
        public string ORDEN_CAJA { get; set; }
        public string NUM_ORDEN { get; set; }
        public int CAJAS { get; set; }
        public string SELLO1 { get; set; }
        public string SELLO2 { get; set; }
        public string CONTENEDOR { get; set; }
        public string CONTENEDORID { get; set; }
        public Nullable<decimal> PESO_ESTIMADO { get; set; }
        public Nullable<decimal> PESO_REAL { get; set; }
        public Nullable<decimal> TARA { get; set; }
    }
}
