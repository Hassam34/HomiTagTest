//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomiTagTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddedBy { get; set; }
        public int GeneresId { get; set; }
        public bool Statsus { get; set; }
        public System.DateTime CreationTimeStamp { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string Duration { get; set; }
        public Nullable<double> Rating { get; set; }
    
        public virtual Genere Genere { get; set; }
    }
}
