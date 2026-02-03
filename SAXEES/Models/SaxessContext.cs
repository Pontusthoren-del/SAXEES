using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SAXEES.Models;

public partial class SaxessContext : DbContext
{
    public SaxessContext()
    {
    }

    public SaxessContext(DbContextOptions<SaxessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Treatment> Treatments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = localhost; Database = SAXESS; Integrated Security = true; Trust Server Certificate = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bookings__3214EC070CDBC380");

            entity.ToTable(tb => tb.HasTrigger("trg_PreventOverlappingBookings"));

            entity.Property(e => e.Time).HasColumnType("datetime");

            entity.HasOne(d => d.Customers).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomersId)
                .HasConstraintName("FK__Bookings__Custom__60A75C0F");

            entity.HasOne(d => d.Staff).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK__Bookings__StaffI__5EBF139D");

            entity.HasOne(d => d.Treatments).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.TreatmentsId)
                .HasConstraintName("FK__Bookings__Treatm__5FB337D6");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC076A7AAD32");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PersonNumber)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PhoneNR");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Position__3214EC072AFC71F4");

            entity.ToTable("Position");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Staff__3214EC07C4D9747B");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PersonNumber)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PhoneNR");
        });

        modelBuilder.Entity<Treatment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Treatmen__3214EC076AB5A4A5");

            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
