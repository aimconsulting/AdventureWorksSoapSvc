namespace AdventureWorksSvc.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AWDataContext : DbContext
    {
        public AWDataContext()
            : base("name=AWDataContext")
        {
        }

        public virtual DbSet<DimProduct> DimProducts { get; set; }
        public virtual DbSet<DimProductCategory> DimProductCategories { get; set; }
        public virtual DbSet<DimProductSubcategory> DimProductSubcategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimProduct>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.DealerPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.Style)
                .IsFixedLength();
        }
    }
}
