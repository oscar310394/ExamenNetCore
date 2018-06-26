using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Universidad.Models
{
    public partial class ParcialDBContext : DbContext
    {
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcialDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }*/

        public ParcialDBContext(DbContextOptions<ParcialDBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.Idalumno);

                entity.Property(e => e.Idalumno).HasColumnName("IDAlumno");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.Idmateria);

                entity.Property(e => e.Idmateria).HasColumnName("IDMateria");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Matricula>(entity =>
            {
                entity.HasKey(e => e.Idmatricula);

                entity.Property(e => e.Idmatricula).HasColumnName("IDMatricula");

                entity.Property(e => e.Idalumno).HasColumnName("IDAlumno");

                entity.Property(e => e.Idmateria).HasColumnName("IDMateria");

                entity.Property(e => e.Idprofesor).HasColumnName("IDProfesor");

                entity.HasOne(d => d.IdalumnoNavigation)
                    .WithMany(p => p.Matricula)
                    .HasForeignKey(d => d.Idalumno)
                    .HasConstraintName("fk_matricula_alumno");

                entity.HasOne(d => d.IdmateriaNavigation)
                    .WithMany(p => p.Matricula)
                    .HasForeignKey(d => d.Idmateria)
                    .HasConstraintName("fk_matricula_materia");

                entity.HasOne(d => d.IdprofesorNavigation)
                    .WithMany(p => p.Matricula)
                    .HasForeignKey(d => d.Idprofesor)
                    .HasConstraintName("fk_matricula_profesor");
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasKey(e => e.Idprofesor);

                entity.Property(e => e.Idprofesor).HasColumnName("IDProfesor");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
