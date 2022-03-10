﻿// <auto-generated />
using System;
using caminhoes.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace caminhoes.Infrastructure.Data.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20210305181003_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("socialmente")
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("caminhoes.Domain.Entities.Pergunta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Pergunta");
                });

            modelBuilder.Entity("caminhoes.Domain.Entities.Resposta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdPergunta")
                        .HasColumnType("int");

                    b.Property<Guid?>("PerguntaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PerguntaId");

                    b.ToTable("Resposta");
                });

            modelBuilder.Entity("caminhoes.Domain.Entities.Resposta", b =>
                {
                    b.HasOne("caminhoes.Domain.Entities.Pergunta", "Pergunta")
                        .WithMany()
                        .HasForeignKey("PerguntaId");
                });
#pragma warning restore 612, 618
        }
    }
}
