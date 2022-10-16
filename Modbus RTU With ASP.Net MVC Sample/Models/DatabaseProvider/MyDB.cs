using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Modbus_RTU_With_ASP.Net_MVC_Sample.Models.DatabaseProvider
{
    public partial class MyDB : DbContext
    {
        public MyDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Table_Day> Table_Day { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_Day>()
                .Property(e => e.Time_Stamp)
                .IsFixedLength();
        }
    }
}
