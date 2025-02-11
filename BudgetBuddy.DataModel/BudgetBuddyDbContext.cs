using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BudgetBuddy.DataModel;

public partial class BudgetBuddyDbContext : DbContext
{
    public BudgetBuddyDbContext(DbContextOptions<BudgetBuddyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Accounts__3214EC07D94E4B0E");

            entity.Property(e => e.AccountId)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC071E819CDA");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Category)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Channel)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
