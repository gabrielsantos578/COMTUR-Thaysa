﻿// <auto-generated />
using System;
using COMTUR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace COMTUR.Migrations
{
    [DbContext(typeof(ComturDBContext))]
    partial class ComturDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("COMTUR.Models.AdministradorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("administradorid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CargoAdministrador")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cargoadministrador");

                    b.Property<string>("CpfAdministrador")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cpfadministrador");

                    b.Property<string>("EmailAdministrador")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emailadministrador");

                    b.Property<string>("ImagemPerfilAdministrador")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagemperfiladministrador");

                    b.Property<string>("NomeAdministrador")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nomeadministrador");

                    b.Property<string>("SenhaAdministrador")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senhaadministrador");

                    b.Property<string>("TelefoneAdministrador")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("telefoneadministrador");

                    b.HasKey("Id");

                    b.ToTable("administrador");
                });

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("atracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.Property<int>("IdTipoAtracao")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("qrcode");

                    b.Property<int?>("TipoAtracaoModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoAtracao");

                    b.HasIndex("TipoAtracaoModelId");

                    b.ToTable("atracao");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("empresaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint")
                        .HasColumnName("cnpj");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<int?>("EmpresarioModelId")
                        .HasColumnType("integer");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<int>("IdEmpresario")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("EmpresarioModelId");

                    b.HasIndex("IdEmpresario");

                    b.ToTable("empresa");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("empresarioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailEmpresario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emailempresario");

                    b.Property<string>("ImagemPerfilEmpresario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagemperfilempresario");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<string>("SenhaEmpresario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senhaempresario");

                    b.Property<string>("TelefoneEmpresario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("telefoneempresario");

                    b.HasKey("Id");

                    b.ToTable("empresario");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemNoticiaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("imagemnoticiaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdNoticia")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<int?>("NoticiaModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdNoticia");

                    b.HasIndex("NoticiaModelId");

                    b.ToTable("imagemnoticia");
                });

            modelBuilder.Entity("COMTUR.Models.NoticiaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("noticiaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ArquivoImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("arquivoImagem");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("conteudo");

                    b.Property<DateOnly>("DataPublicacao")
                        .HasColumnType("date")
                        .HasColumnName("datapublicacao");

                    b.Property<string>("HoraPublicacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("horaPublicacao");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.Property<string>("Subtitulo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("subtitulo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.ToTable("noticia");
                });

            modelBuilder.Entity("COMTUR.Models.TipoAtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoatracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipoatracao");
                });

            modelBuilder.Entity("COMTUR.Models.TipoTurismoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoturismoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipoturismo");
                });

            modelBuilder.Entity("COMTUR.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Usuarioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emailUsuario");

                    b.Property<string>("ImagemPerfilUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagemPerfilUsuario");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senhaUsuario");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.HasOne("COMTUR.Models.TipoAtracaoModel", "TipoAtracaoModel")
                        .WithMany()
                        .HasForeignKey("IdTipoAtracao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMTUR.Models.TipoAtracaoModel", null)
                        .WithMany("Atracao")
                        .HasForeignKey("TipoAtracaoModelId");

                    b.Navigation("TipoAtracaoModel");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresaModel", b =>
                {
                    b.HasOne("COMTUR.Models.EmpresarioModel", null)
                        .WithMany("Empresa")
                        .HasForeignKey("EmpresarioModelId");

                    b.HasOne("COMTUR.Models.EmpresarioModel", "EmpresarioModel")
                        .WithMany()
                        .HasForeignKey("IdEmpresario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresarioModel");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemNoticiaModel", b =>
                {
                    b.HasOne("COMTUR.Models.NoticiaModel", "NoticiaModel")
                        .WithMany()
                        .HasForeignKey("IdNoticia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMTUR.Models.NoticiaModel", null)
                        .WithMany("ImagemNoticia")
                        .HasForeignKey("NoticiaModelId");

                    b.Navigation("NoticiaModel");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresarioModel", b =>
                {
                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("COMTUR.Models.NoticiaModel", b =>
                {
                    b.Navigation("ImagemNoticia");
                });

            modelBuilder.Entity("COMTUR.Models.TipoAtracaoModel", b =>
                {
                    b.Navigation("Atracao");
                });
#pragma warning restore 612, 618
        }
    }
}
