namespace Domain.Properties
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BurstyDataContext : DbContext
    {
        public BurstyDataContext()
            : base("name=BurstyDataContext")
        {
        }

        public virtual DbSet<Check> Checks { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Check>()
                .HasMany(e => e.Lines)
                .WithRequired(e => e.Check)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Log>()
                .HasMany(e => e.Checks)
                .WithRequired(e => e.Log)
                .WillCascadeOnDelete(false);
        }
    }
}
