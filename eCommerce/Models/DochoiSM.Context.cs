﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DochoiSMEntities : DbContext
    {
        public DochoiSMEntities()
            : base("name=DochoiSMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SM_Contact> SM_Contact { get; set; }
        public DbSet<SM_Order> SM_Order { get; set; }
        public DbSet<SM_Post> SM_Post { get; set; }
        public DbSet<SM_Product> SM_Product { get; set; }
        public DbSet<SM_ProductType> SM_ProductType { get; set; }
    }
}
