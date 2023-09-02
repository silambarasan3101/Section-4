using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _1._12.Models;

public partial class AssisstedContext : DbContext
{
    public AssisstedContext()
    {
    }

    public AssisstedContext(DbContextOptions<AssisstedContext> options)
        : base(options)
    {
    }

    public virtual DbSet<School> Schools { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-R52GF1S;database=Assissted;trusted_connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<School>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__School__3214EC079D62C261");

            entity.ToTable("School");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Class).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
