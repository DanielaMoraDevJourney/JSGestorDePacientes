﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JSGestorDePacientes.Migrations
{
    [DbContext(typeof(JSGestorDePacientesContext))]
    [Migration("20240602184436_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JSGestorDePacientes.Models.JSCategoria", b =>
                {
                    b.Property<int>("JSIdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JSIdCategoria"));

                    b.Property<DateTime>("JSFechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("JSGravedad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JSPacienteJSIdPaciente")
                        .HasColumnType("int");

                    b.HasKey("JSIdCategoria");

                    b.HasIndex("JSPacienteJSIdPaciente");

                    b.ToTable("JSCategoria");
                });

            modelBuilder.Entity("JSGestorDePacientes.Models.JSPaciente", b =>
                {
                    b.Property<int>("JSIdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JSIdPaciente"));

                    b.Property<string>("JSApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JSCategoriaJSIdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("JSDNI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JSEnfermedad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JSIdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("JSNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JSIdPaciente");

                    b.HasIndex("JSCategoriaJSIdCategoria");

                    b.ToTable("JSPaciente");
                });

            modelBuilder.Entity("JSGestorDePacientes.Models.JSCategoria", b =>
                {
                    b.HasOne("JSGestorDePacientes.Models.JSPaciente", null)
                        .WithMany("Categorias")
                        .HasForeignKey("JSPacienteJSIdPaciente");
                });

            modelBuilder.Entity("JSGestorDePacientes.Models.JSPaciente", b =>
                {
                    b.HasOne("JSGestorDePacientes.Models.JSCategoria", "JSCategoria")
                        .WithMany()
                        .HasForeignKey("JSCategoriaJSIdCategoria");

                    b.Navigation("JSCategoria");
                });

            modelBuilder.Entity("JSGestorDePacientes.Models.JSPaciente", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
