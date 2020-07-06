using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExamaxityApp.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Data Source=examaxity.database.windows.net;Initial Catalog=ExamAxity;Persist Security Info=True;User ID=examen;Password=********;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CantidadInventario).HasMaxLength(200);

                entity.Property(e => e.Costo).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(200);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
