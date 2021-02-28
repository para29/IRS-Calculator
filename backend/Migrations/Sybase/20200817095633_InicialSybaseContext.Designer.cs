﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

namespace backend.Migrations.Sybase
{
  [DbContext(typeof(SybaseContext))]
  [Migration("20200817095633_InicialSybaseContext")]
  partial class InicialSybaseContext
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "3.1.6")
          .HasAnnotation("Relational:MaxIdentifierLength", 128)
          .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

      modelBuilder.Entity("backend.Models.Sybase_Colaborador_Nivel", b =>
          {
            b.HasNoKey();

            b.Property<decimal?>("colaboradorid")
                      .HasColumnType("numeric(10,0)");

            b.Property<decimal?>("abonos")
                      .HasColumnType("money");

            b.Property<DateTime?>("data_fim")
                      .HasColumnType("datetime");

            b.Property<DateTime?>("data_inicio")
                      .HasColumnType("datetime");

            b.Property<decimal?>("despesas")
                      .HasColumnType("money");

            b.Property<decimal?>("despesas_gasolina")
                      .HasColumnType("money");

            b.Property<decimal?>("despesas_viatura")
                      .HasColumnType("money");

            b.Property<string>("estado_colaborador")
                      .HasColumnType("varchar(20)");

            b.Property<string>("nivel")
                      .HasColumnType("varchar(100)");

            b.Property<string>("nivelactual")
                      .HasColumnType("varchar(3)");

            b.Property<string>("nome")
                      .HasColumnType("varchar(100)");

            b.Property<decimal?>("premio")
                      .HasColumnType("money");

            b.Property<decimal?>("subs_refeicao")
                      .HasColumnType("money");

            b.Property<decimal?>("variavel")
                      .HasColumnType("money");

            b.Property<decimal?>("vencimento")
                      .HasColumnType("money");

            b.Property<decimal?>("viatura")
                      .HasColumnType("money");

            b.ToTable("DW_COLABORADORNIVEL");
          });

      modelBuilder.Entity("backend.Models.Sybase_Nivel", b =>
          {
            b.Property<decimal>("nivelid")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("numeric(10,0)");

            b.Property<decimal?>("abonos")
                      .HasColumnType("money");

            b.Property<decimal?>("atribviatura")
                      .HasColumnType("money");

            b.Property<string>("desc")
                      .HasColumnType("varchar(100)");

            b.Property<decimal?>("despesas")
                      .HasColumnType("money");

            b.Property<decimal?>("despesasgasolina")
                      .HasColumnType("money");

            b.Property<decimal?>("despesasviatura")
                      .HasColumnType("money");

            b.Property<decimal?>("premio")
                      .HasColumnType("money");

            b.Property<string>("shortdesc")
                      .HasColumnType("varchar(30)");

            b.Property<decimal?>("subsrefeicao")
                      .HasColumnType("money");

            b.Property<decimal?>("variavel")
                      .HasColumnType("money");

            b.Property<decimal?>("vencimento")
                      .HasColumnType("money");

            b.HasKey("nivelid");

            b.ToTable("NIVEL");
          });
#pragma warning restore 612, 618
    }
  }
}
