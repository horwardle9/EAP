namespace WcfService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBEmployees : DbContext
    {
        public DBEmployees()
            : base("name=DBEmployees")
        {
        }

        public virtual DbSet<tbEmployee> tbEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //sql
            modelBuilder.Entity<tbEmployee>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<tbEmployee>()
                .Property(e => e.EmployeeName)
                .IsUnicode(false);

            modelBuilder.Entity<tbEmployee>()
                .Property(e => e.EmployeeDepartment)
                .IsUnicode(false);
        
        }
    }
}
