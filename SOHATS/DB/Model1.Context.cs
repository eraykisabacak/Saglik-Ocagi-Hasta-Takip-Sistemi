﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOHATS.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SOHATSEntities : DbContext
    {
        public SOHATSEntities()
            : base("name=SOHATSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cikis> cikis { get; set; }
        public virtual DbSet<hasta> hasta { get; set; }
        public virtual DbSet<islem> islem { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<poliklinik> poliklinik { get; set; }
        public virtual DbSet<sevk> sevk { get; set; }
    }
}
