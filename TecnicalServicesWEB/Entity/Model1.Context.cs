//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecnicalServicesWEB.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBtecnicalservicesEntities : DbContext
    {
        public DBtecnicalservicesEntities()
            : base("name=DBtecnicalservicesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_PRODUCTFOLLOWING> TBL_PRODUCTFOLLOWING { get; set; }
        public virtual DbSet<TBL_ABOUTUS> TBL_ABOUTUS { get; set; }
        public virtual DbSet<TBL_PRODUCTS> TBL_PRODUCTS { get; set; }
        public virtual DbSet<TBL_CONNECTTION> TBL_CONNECTTION { get; set; }
    }
}
