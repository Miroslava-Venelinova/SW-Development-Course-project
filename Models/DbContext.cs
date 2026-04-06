using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UniSystem.Models;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Major> Majors { get; set; }

    public virtual DbSet<MajorsFee> MajorsFees { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentsSubject> StudentsSubjects { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeachersSubject> TeachersSubjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DB; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Addresse__CAA247C8FAEE034F");

            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.Street)
                .HasMaxLength(30)
                .HasColumnName("street");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PK__Grades__3A8F732CC4F1357A");

            entity.ToTable(tb => tb.HasTrigger("tr_AddGradeCalculateAverage"));

            entity.Property(e => e.GradeId).HasColumnName("grade_id");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entry_date");
            entity.Property(e => e.GradeValue)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("grade_value");
            entity.Property(e => e.StudentId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("student_id");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

            entity.HasOne(d => d.Student).WithMany(p => p.Grades)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grades__student___4AB81AF0");

            entity.HasOne(d => d.Subject).WithMany(p => p.Grades)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grades__subject___4CA06362");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Grades)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grades__teacher___4BAC3F29");
        });

        modelBuilder.Entity<Major>(entity =>
        {
            entity.HasKey(e => e.MajorId).HasName("PK__Majors__DC7AC3C458EDD836");

            entity.Property(e => e.MajorId).HasColumnName("major_id");
            entity.Property(e => e.MajorName)
                .HasMaxLength(30)
                .HasColumnName("major_name");
        });

        modelBuilder.Entity<MajorsFee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Majors_Fees");

            entity.Property(e => e.Major).HasColumnName("major");
            entity.Property(e => e.MajorFee)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("major_fee");

            entity.HasOne(d => d.MajorNavigation).WithMany()
                .HasForeignKey(d => d.Major)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Majors_Fe__major__3A81B327");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.FacultyNumber).HasName("PK__Students__ADCD8C7F7C25344A");

            entity.Property(e => e.FacultyNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("faculty_number");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.AverageGrade)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("average_grade");
            entity.Property(e => e.DegreeType)
                .HasMaxLength(10)
                .HasColumnName("degree_type");
            entity.Property(e => e.EnrollmentDate)
                .HasColumnType("datetime")
                .HasColumnName("enrollment_date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("first_name");
            entity.Property(e => e.Group).HasColumnName("group");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("last_name");
            entity.Property(e => e.Major).HasColumnName("major");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(30)
                .HasColumnName("middle_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.Stream).HasColumnName("stream");
            entity.Property(e => e.UnpaidFees)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("unpaid_fees");

            entity.HasOne(d => d.AddressNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.Address)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Students__addres__3D5E1FD2");

            entity.HasOne(d => d.MajorNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.Major)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Students__major__3E52440B");
        });

        modelBuilder.Entity<StudentsSubject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Students_Subjects");

            entity.Property(e => e.Student)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("student");
            entity.Property(e => e.Subject).HasColumnName("subject");

            entity.HasOne(d => d.StudentNavigation).WithMany()
                .HasForeignKey(d => d.Student)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Students___stude__4222D4EF");

            entity.HasOne(d => d.SubjectNavigation).WithMany()
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Students___subje__4316F928");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subjects__5004F660899FAB6F");

            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(30)
                .HasColumnName("subject_name");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teachers__03AE777E3F801549");

            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("last_name");
        });

        modelBuilder.Entity<TeachersSubject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Teachers_Subjects");

            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Teacher).HasColumnName("teacher");

            entity.HasOne(d => d.SubjectNavigation).WithMany()
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Teachers___subje__47DBAE45");

            entity.HasOne(d => d.TeacherNavigation).WithMany()
                .HasForeignKey(d => d.Teacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Teachers___teach__46E78A0C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
