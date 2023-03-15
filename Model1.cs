using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace projectEFullstacl
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Clients)
                .Map(m => m.ToTable("Purchase").MapLeftKey("Cid").MapRightKey("Pcode"));

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Measure_unit)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Requests)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Pcode);

            modelBuilder.Entity<Request>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Request>()
                .Property(e => e.Wname)
                .IsUnicode(false);

            modelBuilder.Entity<Request>()
                .Property(e => e.Sname)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Requests)
                .WithOptional(e => e.Supplier)
                .HasForeignKey(e => e.Sname);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Requests)
                .WithOptional(e => e.Warehouse)
                .HasForeignKey(e => e.Wname);
        }
    }
}
