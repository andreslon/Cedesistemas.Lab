//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cedesistemas.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicles
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<int> UserId { get; set; }
    }
}
