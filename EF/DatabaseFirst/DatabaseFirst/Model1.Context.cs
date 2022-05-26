﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ZensarDBEntities : DbContext
    {
        public ZensarDBEntities()
            : base("name=ZensarDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
    
        public virtual ObjectResult<sp_deptdetails_Result> sp_deptdetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_deptdetails_Result>("sp_deptdetails");
        }
    
        public virtual ObjectResult<sp_findEmployee_Result> sp_findEmployee(Nullable<int> eid)
        {
            var eidParameter = eid.HasValue ?
                new ObjectParameter("eid", eid) :
                new ObjectParameter("eid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_findEmployee_Result>("sp_findEmployee", eidParameter);
        }
    }
}