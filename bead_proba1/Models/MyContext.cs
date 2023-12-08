using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bead_proba1.Models;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }

    public virtual DbSet<CustomerRegion> CustomerRegions { get; set; }

    public virtual DbSet<OrderCustomer> OrderCustomers { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jana\\source\\repos\\bead_proba1\\bead_proba1\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity.HasKey(e => e.PostalCode).HasName("PK__customer__CEB4298C9BCFC7AA");

            entity.ToTable("customer_address");

            entity.Property(e => e.PostalCode)
                .ValueGeneratedNever()
                .HasColumnName("postal_code");
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.State)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("state");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__customer___state__70DDC3D8");
        });

        modelBuilder.Entity<CustomerDetail>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__customer__CD65CB8548D4C32E");

            entity.ToTable("customer_details");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('Customer Name')")
                .HasColumnName("customer_name");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.Segment)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("segment");

            entity.HasOne(d => d.PostalCodeNavigation).WithMany(p => p.CustomerDetails)
                .HasForeignKey(d => d.PostalCode)
                .HasConstraintName("FK__customer___posta__74AE54BC");
        });

        modelBuilder.Entity<CustomerRegion>(entity =>
        {
            entity.HasKey(e => e.State).HasName("PK__customer__A9360BC2B41FA5B1");

            entity.ToTable("customer_region");

            entity.Property(e => e.State)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Region)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("region");
        });

        modelBuilder.Entity<OrderCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("order_customers");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("customer_id");
            entity.Property(e => e.OrderId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("order_id");

            entity.HasOne(d => d.Customer).WithMany()
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__order_cus__custo__778AC167");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__order_cus__order__76969D2E");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__order_de__46596229A60DDD5A");

            entity.ToTable("order_details");

            entity.Property(e => e.OrderId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("order_id");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("order_date");
            entity.Property(e => e.ShipDate)
                .HasColumnType("date")
                .HasColumnName("ship_date");
            entity.Property(e => e.ShipMode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ship_mode");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("order_products");

            entity.Property(e => e.OrderId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("order_id");
            entity.Property(e => e.ProductId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("product_id");
            entity.Property(e => e.Sales)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("sales");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__order_pro__order__797309D9");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__order_pro__produ__7A672E12");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__products__47027DF53AC200CC");

            entity.ToTable("products");

            entity.Property(e => e.ProductId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("product_id");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("product_name");
            entity.Property(e => e.SubCategory)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sub_category");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
