﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartHouseEntities : DbContext
    {
        public SmartHouseEntities()
            : base("name=SmartHouseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patteri> Patteri { get; set; }
        public virtual DbSet<Sauna> Sauna { get; set; }
        public virtual DbSet<Sijainti> Sijainti { get; set; }
        public virtual DbSet<Talo> Talo { get; set; }
        public virtual DbSet<Valo> Valo { get; set; }
    }
}