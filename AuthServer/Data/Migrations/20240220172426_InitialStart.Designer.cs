﻿// <auto-generated />
using AuthServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthServer.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240220172426_InitialStart")]
    partial class InitialStart
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthServer.Entities.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Ime")
                        .HasColumnType("text");

                    b.Property<byte[]>("LozinkaHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("LozinkaSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("Prezime")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Korisnici");
                });
#pragma warning restore 612, 618
        }
    }
}
