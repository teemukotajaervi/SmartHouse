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
    
    public partial class Patteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patteri()
        {
            this.Talo = new HashSet<Talo>();
        }
    
        public int Id { get; set; }
        public string Nimi { get; set; }
        public string Koodi { get; set; }
        public Nullable<bool> Tila { get; set; }
        public Nullable<decimal> Lampotila { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Talo> Talo { get; set; }
    }
}
