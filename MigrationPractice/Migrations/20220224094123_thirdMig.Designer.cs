﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigrationPractice.Data;

namespace MigrationPractice.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220224094123_thirdMig")]
    partial class thirdMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MigrationPractice.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Uzbekistan",
                            ShortName = "UZB"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Russia",
                            ShortName = "RUS"
                        },
                        new
                        {
                            Id = 3,
                            Name = "England",
                            ShortName = "ENG"
                        });
                });

            modelBuilder.Entity("MigrationPractice.Data.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Internationa Uzb Hotel",
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "SuperContinental",
                            Rating = 3.5
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Internationa Uzb Hotel",
                            Rating = 4.0
                        });
                });

            modelBuilder.Entity("MigrationPractice.Data.Models.Hotel", b =>
                {
                    b.HasOne("MigrationPractice.Data.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
