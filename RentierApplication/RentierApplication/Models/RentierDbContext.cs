using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RentierApplication.Models;

namespace RentierApplication.Models;

public partial class RentierDbContext : DbContext
{
    public RentierDbContext()
    {
    }

    public RentierDbContext(DbContextOptions<RentierDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserRealEstate> UserRealEstates { get; set; }
    public virtual DbSet<UserRealEstate> User  { get; set; }
    public virtual DbSet<UserRealEstate> ExpenceType { get; set; }
    public virtual DbSet<UserRealEstate> URealEstate { get; set; }
    public virtual DbSet<UserRealEstate> RealEstateExpences { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserRealEstate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserRealEstate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<RentierApplication.Models.RealEstate> RealEstate { get; set; }
}
