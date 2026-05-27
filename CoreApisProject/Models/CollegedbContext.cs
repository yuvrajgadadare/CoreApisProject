using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreApisProject.Models;

public partial class CollegedbContext : DbContext
{
    public CollegedbContext()
    {
    }

    public CollegedbContext(DbContextOptions<CollegedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-VRMFV23\\SQLEXPRESS;Database=Collegedb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Rno).HasName("PK__students__C2B7F59B6217C77B");

            entity.ToTable("students");

            entity.Property(e => e.Rno).HasColumnName("rno");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.Qualification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("qualification");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
