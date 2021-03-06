// <auto-generated />
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
    [Migration("20220322014732_add fk usuarios 2")]
    partial class addfkusuarios2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DeusVivo.Domain.Entitys.CargoEO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("AlteracaoDataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("AlteracaoUsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanhiaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CriacaoDataHora")
                        .HasColumnType("datetime(6)");

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

            modelBuilder.Entity("DeusVivo.Domain.Entitys.CompanhiaEO", b =>
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

            modelBuilder.Entity("DeusVivo.Domain.Entitys.UsuarioEO", b =>
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

            modelBuilder.Entity("DeusVivo.Domain.Entitys.CargoEO", b =>
                {
                    b.HasOne("DeusVivo.Domain.Entitys.UsuarioEO", "AlteracaoUsuario")
                        .WithMany()
                        .HasForeignKey("AlteracaoUsuarioId");

                    b.HasOne("DeusVivo.Domain.Entitys.CompanhiaEO", "Companhia")
                        .WithMany()
                        .HasForeignKey("CompanhiaId");

                    b.HasOne("DeusVivo.Domain.Entitys.UsuarioEO", "CriacaoUsuario")
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
