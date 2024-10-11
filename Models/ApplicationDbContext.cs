using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Prospect_System.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<Evaluacion> Evaluacions { get; set; }

    public virtual DbSet<Prospecto> Prospectos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Tu cadena de conexion");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3213E83F3A8AFCED");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContenidoArchivo).HasColumnName("contenido_archivo");
            entity.Property(e => e.FechaCaptura)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_captura");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_archivo");
            entity.Property(e => e.ProspectoId).HasColumnName("prospecto_id");

            entity.HasOne(d => d.Prospecto).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.ProspectoId)
                .HasConstraintName("FK__Documento__prosp__5FB337D6");
        });

        modelBuilder.Entity<Evaluacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Evaluaci__3213E83F1B6F2616");

            entity.ToTable("Evaluacion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaEvaluacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_evaluacion");
            entity.Property(e => e.ObservacionesRechazo)
                .HasColumnType("text")
                .HasColumnName("observaciones_rechazo");
            entity.Property(e => e.ProspectoId).HasColumnName("prospecto_id");

            entity.HasOne(d => d.Prospecto).WithMany(p => p.Evaluacions)
                .HasForeignKey(d => d.ProspectoId)
                .HasConstraintName("FK__Evaluacio__prosp__6477ECF3");
        });

        modelBuilder.Entity<Prospecto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prospect__3213E83FABE0A586");

            entity.ToTable("Prospecto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo_postal");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Estatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Enviado")
                .HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("primer_apellido");
            entity.Property(e => e.Rfc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("segundo_apellido");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
