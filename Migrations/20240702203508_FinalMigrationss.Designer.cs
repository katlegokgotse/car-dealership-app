﻿// <auto-generated />
using CarDealershipApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarDealershipApp.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240702203508_FinalMigrationss")]
    partial class FinalMigrationss
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarDealershipApp.Models.Administrator", b =>
                {
                    b.Property<int>("AdministratorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministratorID"));

                    b.Property<string>("AdministratorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdministratorPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdministratorUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministratorID");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Cars", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<int>("CarAdvertisementState")
                        .HasColumnType("int");

                    b.Property<string>("CarColour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarExtras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CarPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CarState")
                        .HasColumnType("int");

                    b.Property<int>("CarYear")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarDealershipApp.Models.InterestedPerson", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("CarAdvertId")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CarAdvertId");

                    b.ToTable("InterestedPeople");
                });

            modelBuilder.Entity("CarDealershipApp.Models.InterestedPerson", b =>
                {
                    b.HasOne("CarDealershipApp.Models.Cars", "Cars")
                        .WithMany("InterestedPersons")
                        .HasForeignKey("CarAdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarDealershipApp.Models.Cars", b =>
                {
                    b.Navigation("InterestedPersons");
                });
#pragma warning restore 612, 618
        }
    }
}
