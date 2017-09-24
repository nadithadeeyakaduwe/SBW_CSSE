using SBW.Entities.HRMModule;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess
{
    public class SBWEntities : DbContext
    {
        public SBWEntities() : base ("SarangaBatteryWorksDB")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
    }
}
