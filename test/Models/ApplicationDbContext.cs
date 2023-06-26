using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<LeaveReport> LeaveReports { get; set; }

    public virtual DbSet<VacationRequestSubmission> VacationRequestSubmissions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-8DNDHD5;Database=Project; Trusted_Connection=True; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admins__3214EC27E3257C15");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DateOfAdmission).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC274C14A333");

            entity.ToTable("Department");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC2744D65944");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DateOfHire).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FatherName).HasMaxLength(50);
            entity.Property(e => e.Lastname).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<LeaveReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LeaveRep__3214EC276E685220");

            entity.ToTable("LeaveReport");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LeaveEndDate).HasColumnType("date");
            entity.Property(e => e.LeaveStartDate).HasColumnType("date");
            entity.Property(e => e.Reason).HasMaxLength(100);
        });

        modelBuilder.Entity<VacationRequestSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vacation__3214EC27169ABC0F");

            entity.ToTable("VacationRequestSubmission");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.LeaveStartDate).HasColumnType("date");
            entity.Property(e => e.Reason).HasMaxLength(100);
            entity.Property(e => e.VacationEndDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
