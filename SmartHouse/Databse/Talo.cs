//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartHouse.Databse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Talo
    {
        public int Id { get; set; }
        public Nullable<int> SijaintiId { get; set; }
        public Nullable<int> ValoId { get; set; }
        public Nullable<int> SaunaId { get; set; }
        public Nullable<System.DateTime> AsetusPaiva { get; set; }
        public Nullable<int> PatteriId { get; set; }
    
        public virtual Patteri Patteri { get; set; }
        public virtual Sauna Sauna { get; set; }
        public virtual Sijainti Sijainti { get; set; }
        public virtual Valo Valo { get; set; }
    }
}
