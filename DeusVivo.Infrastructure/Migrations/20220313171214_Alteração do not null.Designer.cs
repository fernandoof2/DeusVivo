﻿// <auto-generated />
using System;
using DeusVivo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeusVivo.Infrastructure.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20220313171214_Alteração do not null")]
    partial class Alteraçãodonotnull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DeusVivo.Domain.Entitys.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("AlteracaoDataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("AlteracaoId")
                        .HasColumnType("int");

                    b.Property<int?>("AlteracaoUsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanhiaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CriacaoDataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("CriacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("CriacaoUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AlteracaoUsuarioId");

                    b.HasIndex("CompanhiaId");

                    b.HasIndex("CriacaoUsuarioId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("DeusVivo.Domain.Entitys.Companhia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Companhias");
                });

            modelBuilder.Entity("DeusVivo.Domain.Entitys.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DeusVivo.Domain.Entitys.Cargo", b =>
                {
                    b.HasOne("DeusVivo.Domain.Entitys.Usuario", "AlteracaoUsuario")
                        .WithMany()
                        .HasForeignKey("AlteracaoUsuarioId");

                    b.HasOne("DeusVivo.Domain.Entitys.Companhia", "Companhia")
                        .WithMany()
                        .HasForeignKey("CompanhiaId");

                    b.HasOne("DeusVivo.Domain.Entitys.Usuario", "CriacaoUsuario")
                        .WithMany()
                        .HasForeignKey("CriacaoUsuarioId");

                    b.Navigation("AlteracaoUsuario");

                    b.Navigation("Companhia");

                    b.Navigation("CriacaoUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
