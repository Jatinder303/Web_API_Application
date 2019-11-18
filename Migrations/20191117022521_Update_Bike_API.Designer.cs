﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_API_Application.Models;

namespace Web_API_Application.Migrations
{
    [DbContext(typeof(Bike_API_ApplicationContext))]
    [Migration("20191117022521_Update_Bike_API")]
    partial class Update_Bike_API
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web_API_Application.Model.Bike", b =>
                {
                    b.Property<int>("Bike_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Bike_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Maker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bike_Id");

                    b.ToTable("Bike");
                });
#pragma warning restore 612, 618
        }
    }
}
