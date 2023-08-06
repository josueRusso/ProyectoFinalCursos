﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoCursos.Server.DAL;

#nullable disable

namespace ProyectoCursos.Server.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("ProyectoCursos.Shared.Categorias", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoriaNombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Nivel")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProyectoCursos.Shared.Compras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompraId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("ProyectoCursos.Shared.Cursos", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Categorias")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaBaja")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCurso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Programa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RutaImagen")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ProyectoCursos.Shared.Niveles", b =>
                {
                    b.Property<int>("NivelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nivelnombre")
                        .HasColumnType("TEXT");

                    b.HasKey("NivelId");

                    b.ToTable("Niveles");

                    b.HasData(
                        new
                        {
                            NivelId = 1,
                            Nivelnombre = "Principiante"
                        },
                        new
                        {
                            NivelId = 2,
                            Nivelnombre = "Medio"
                        },
                        new
                        {
                            NivelId = 3,
                            Nivelnombre = "Avanzado"
                        });
                });

            modelBuilder.Entity("ProyectoCursos.Shared.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreRol")
                        .HasColumnType("TEXT");

                    b.HasKey("RolId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RolId = 1,
                            NombreRol = "Administrador"
                        },
                        new
                        {
                            RolId = 2,
                            NombreRol = "Profesor"
                        },
                        new
                        {
                            RolId = 3,
                            NombreRol = "Estudiante"
                        });
                });

            modelBuilder.Entity("ProyectoCursos.Shared.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Email = "Eladmin@gmail.com",
                            FechaNacimiento = new DateTime(2001, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NombreCompleto = "Josue Russo",
                            NombreUsuario = "Admin",
                            Password = "Admin#123",
                            Rol = 1
                        });
                });

            modelBuilder.Entity("ProyectoCursos.Shared.Compras", b =>
                {
                    b.HasOne("ProyectoCursos.Shared.Usuarios", null)
                        .WithMany("Compras")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoCursos.Shared.Usuarios", b =>
                {
                    b.Navigation("Compras");
                });
#pragma warning restore 612, 618
        }
    }
}
