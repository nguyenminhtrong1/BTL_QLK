using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL_QLK.Models
{
    public partial class QLKHDbContext : DbContext
    {
        public QLKHDbContext() : base("name=QLKHDbContext")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonID)
            .IsUnicode(false);
        }
    }

}
