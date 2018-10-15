namespace Examen.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBExamen : DbContext
    {
        public DBExamen()
            : base("name=DBExamen")
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employ> Employ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employ)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employ>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employ>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employ>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employ>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
