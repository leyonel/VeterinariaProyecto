﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VeterinariaApi.Migrations
{
    [DbContext(typeof(VeterinariaContext))]
    partial class VeterinariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VeterinariaAPI.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("VeterinariaAPI.Models.HistorialMedico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaConsulta")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Tratamiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("HistorialMedico");
                });

            modelBuilder.Entity("VeterinariaAPI.Models.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaLote")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inventario");
                });

            modelBuilder.Entity("VeterinariaAPI.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<int>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("VeterinariaAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Correo")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("VeterinariaAPI.Models.Cita", b =>
                {
                    b.HasOne("VeterinariaAPI.Models.Usuario", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VeterinariaAPI.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("VeterinariaAPI.Models.HistorialMedico", b =>
                {
                    b.HasOne("VeterinariaAPI.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("VeterinariaAPI.Models.Paciente", b =>
                {
                    b.HasOne("VeterinariaAPI.Models.Usuario", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propietario");
                });
#pragma warning restore 612, 618
        }
    }
}
