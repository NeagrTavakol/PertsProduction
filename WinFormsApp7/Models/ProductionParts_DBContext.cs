using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WinFormsApp7.Models
{
    public partial class ProductionParts_DBContext : DbContext
    {
        public ProductionParts_DBContext()
        {
        }

        public ProductionParts_DBContext(DbContextOptions<ProductionParts_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Part> Parts { get; set; } = null!;
        public virtual DbSet<ProductionOrder> ProductionOrders { get; set; } = null!;
        public virtual DbSet<ProductionStep> ProductionSteps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NDKLHMF;Database=ProductionParts_DB;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Part>(entity =>
            {
                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.PartName).HasMaxLength(150);

                entity.Property(e => e.PdfFilePath).HasMaxLength(255);
            });

            modelBuilder.Entity<ProductionOrder>(entity =>
            {
                entity.Property(e => e.ProductionOrderId).HasColumnName("ProductionOrderID");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.ProductionOrders)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionOrders_Parts");
            });

            modelBuilder.Entity<ProductionStep>(entity =>
            {
                entity.Property(e => e.ProductionStepId).HasColumnName("ProductionStepID");

                entity.Property(e => e.OperatorName).HasMaxLength(150);

                entity.Property(e => e.ProductionOrderId).HasColumnName("ProductionOrderID");

                entity.Property(e => e.WorkStation).HasMaxLength(150);

                entity.HasOne(d => d.ProductionOrder)
                    .WithMany(p => p.ProductionSteps)
                    .HasForeignKey(d => d.ProductionOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductionSteps_ProductionOrders");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
