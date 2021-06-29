using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto.Context
{
    public partial class PROYECTOPOO1Context : DbContext
    {
        public PROYECTOPOO1Context()
        {
        }

        public PROYECTOPOO1Context(DbContextOptions<PROYECTOPOO1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<Citaxcabina> Citaxcabinas { get; set; }
        public virtual DbSet<Citaxefecto> Citaxefectos { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<EfectoSecundario> EfectoSecundarios { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Gestor> Gestors { get; set; }
        public virtual DbSet<HistorialLogin> HistorialLogins { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<TelefonoEmpleado> TelefonoEmpleados { get; set; }
        public virtual DbSet<Telefonocabina> Telefonocabinas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.HasKey(e => e.IdCabina)
                    .HasName("PK__CABINA__FAD33CFD5A025F94");

                entity.ToTable("CABINA");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Encargado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("encargado");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Cabinas)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_CABINA_EMPLEADO");
            });

            modelBuilder.Entity<Citaxcabina>(entity =>
            {
                entity.HasKey(e => e.IdCitaxcabina)
                    .HasName("PK__CITAXCAB__5F49D95303077DDE");

                entity.ToTable("CITAXCABINA");

                entity.Property(e => e.IdCitaxcabina).HasColumnName("id_citaxcabina");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Citaxcabinas)
                    .HasForeignKey(d => d.IdCabina)
                    .HasConstraintName("FK_CITAXCABINA_CABINA");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.Citaxcabinas)
                    .HasForeignKey(d => d.IdCita)
                    .HasConstraintName("FK_CITAXCABINA_CITA");
            });

            modelBuilder.Entity<Citaxefecto>(entity =>
            {
                entity.HasKey(e => e.IdCitaxefecto)
                    .HasName("PK__CITAXEFE__1B7CF37801EEDB0C");

                entity.ToTable("CITAXEFECTO");

                entity.Property(e => e.IdCitaxefecto).HasColumnName("id_citaxefecto");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.Property(e => e.IdEfecto).HasColumnName("id_efecto");

                entity.Property(e => e.Tiempo).HasColumnName("tiempo");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.Citaxefectos)
                    .HasForeignKey(d => d.IdCita)
                    .HasConstraintName("FK_CITAXEFECTO_CITA");

                entity.HasOne(d => d.IdEfectoNavigation)
                    .WithMany(p => p.Citaxefectos)
                    .HasForeignKey(d => d.IdEfecto)
                    .HasConstraintName("FK_CITAXEFECTO_EFECTO");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PK__CITA__6AEC3C0909EE6BED");

                entity.ToTable("CITA");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.Property(e => e.Consentimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("consentimiento");

                entity.Property(e => e.Dosis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dosis");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdCiudadano).HasColumnName("id_ciudadano");

                entity.Property(e => e.Lugar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lugar");

                entity.Property(e => e.TipoVacuna)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo_vacuna");

                entity.HasOne(d => d.IdCiudadanoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdCiudadano)
                    .HasConstraintName("FK_CITA_CIUDADANO");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.HasKey(e => e.IdCiudadano)
                    .HasName("PK__CIUDADAN__676FF54B95F38040");

                entity.ToTable("CIUDADANO");

                entity.Property(e => e.IdCiudadano).HasColumnName("id_ciudadano");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Dui)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Enfermedad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enfermedad");

                entity.Property(e => e.Etario).HasColumnName("etario");

                entity.Property(e => e.Institucion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institucion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<EfectoSecundario>(entity =>
            {
                entity.HasKey(e => e.IdEfecto)
                    .HasName("PK__EFECTO_S__010E34D3718CD71C");

                entity.ToTable("EFECTO_SECUNDARIO");

                entity.Property(e => e.IdEfecto).HasColumnName("id_efecto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__EMPLEADO__88B513948B7AC259");

                entity.ToTable("EMPLEADO");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdGestor)
                    .HasConstraintName("FK_EMPLEADO_GESTOR");
            });

            modelBuilder.Entity<Gestor>(entity =>
            {
                entity.HasKey(e => e.IdGestor)
                    .HasName("PK__GESTOR__2E072639B6419217");

                entity.ToTable("GESTOR");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Gestors)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK_GESTOR_ROL");
            });

            modelBuilder.Entity<HistorialLogin>(entity =>
            {
                entity.HasKey(e => e.IdHistorial)
                    .HasName("PK__HISTORIA__76E6C50268F000F4");

                entity.ToTable("HISTORIAL_LOGIN");

                entity.Property(e => e.IdHistorial).HasColumnName("id_historial");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Evento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EVENTO");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fecha_hora");

                entity.Property(e => e.Modulo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tabla)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TABLA");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__ROL__6ABCB5E04239B43D");

                entity.ToTable("ROL");

                entity.Property(e => e.IdRol)
                    .ValueGeneratedNever()
                    .HasColumnName("id_rol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<TelefonoEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdTelefonoempleado)
                    .HasName("PK__TELEFONO__830D0532FCB8325D");

                entity.ToTable("TELEFONO_EMPLEADO");

                entity.Property(e => e.IdTelefonoempleado).HasColumnName("id_telefonoempleado");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.TelefonoEmpleados)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_TELEFONOEMPLEADO_EMPLEADO");
            });

            modelBuilder.Entity<Telefonocabina>(entity =>
            {
                entity.HasKey(e => e.IdTelefonocabina)
                    .HasName("PK__TELEFONO__78071BAFA8ED9F49");

                entity.ToTable("TELEFONOCABINA");

                entity.Property(e => e.IdTelefonocabina).HasColumnName("id_telefonocabina");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Telefonocabinas)
                    .HasForeignKey(d => d.IdCabina)
                    .HasConstraintName("FK_TELEFONOCABINA_CABINA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
