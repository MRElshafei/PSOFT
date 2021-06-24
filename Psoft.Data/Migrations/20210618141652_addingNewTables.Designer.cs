﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Psoft.Data;

namespace Psoft.Data.Migrations
{
    [DbContext(typeof(PsoftDBContext))]
    [Migration("20210618141652_addingNewTables")]
    partial class addingNewTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Psoft.Domain.BOQ", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectsID")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<string>("unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("unit_price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProjectsID");

                    b.ToTable("BOQS");
                });

            modelBuilder.Entity("Psoft.Domain.Contractor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("Psoft.Domain.Owner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("Psoft.Domain.Projects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Consultant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContractorID")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerID")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContractorID");

                    b.HasIndex("OwnerID");

                    b.HasIndex("UsersID");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("Psoft.Domain.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Psoft.Domain.BOQ", b =>
                {
                    b.HasOne("Psoft.Domain.Projects", null)
                        .WithMany("BOQ")
                        .HasForeignKey("ProjectsID");
                });

            modelBuilder.Entity("Psoft.Domain.Projects", b =>
                {
                    b.HasOne("Psoft.Domain.Contractor", null)
                        .WithMany("projects")
                        .HasForeignKey("ContractorID");

                    b.HasOne("Psoft.Domain.Owner", null)
                        .WithMany("projects")
                        .HasForeignKey("OwnerID");

                    b.HasOne("Psoft.Domain.Users", null)
                        .WithMany("projects")
                        .HasForeignKey("UsersID");
                });
#pragma warning restore 612, 618
        }
    }
}
