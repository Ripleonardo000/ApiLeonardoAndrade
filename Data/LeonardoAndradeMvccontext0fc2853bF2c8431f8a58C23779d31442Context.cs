using System;
using System.Collections.Generic;
using ApiLeonardoAndrade.DataModels;
using Microsoft.EntityFrameworkCore;

namespace ApiLeonardoAndrade.Data;

public partial class LeonardoAndradeMvccontext0fc2853bF2c8431f8a58C23779d31442Context : DbContext
{
    public LeonardoAndradeMvccontext0fc2853bF2c8431f8a58C23779d31442Context()
    {
    }

    public LeonardoAndradeMvccontext0fc2853bF2c8431f8a58C23779d31442Context(DbContextOptions<LeonardoAndradeMvccontext0fc2853bF2c8431f8a58C23779d31442Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Burger> Burgers { get; set; }

    public virtual DbSet<Promo> Promos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LeonardoAndrade_MVCContext-0fc2853b-f2c8-431f-8a58-c23779d31442;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Burger>(entity =>
        {
            entity.ToTable("Burger");

            entity.Property(e => e.BurgerId).HasColumnName("BurgerID");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Promo>(entity =>
        {
            entity.ToTable("Promo");

            entity.HasIndex(e => e.BurgerId, "IX_Promo_BurgerID");

            entity.Property(e => e.PromoId).HasColumnName("PromoID");
            entity.Property(e => e.BurgerId).HasColumnName("BurgerID");

            entity.HasOne(d => d.Burger).WithMany(p => p.Promos).HasForeignKey(d => d.BurgerId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
