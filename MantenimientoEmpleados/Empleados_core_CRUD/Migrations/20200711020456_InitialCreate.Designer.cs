﻿// <auto-generated />
using Empleados_core_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Empleados_core_CRUD.Migrations
{
    [DbContext(typeof(Empleados_Context))]
    [Migration("20200711020456_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Empleados_core_CRUD.Models.Empleado", b =>
                {
                    b.Property<int>("Empleado_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Empleado_Apellido")
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Empleado_Cod")
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Empleado_Correo")
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("Empleado_Departamento");

                    b.Property<string>("Empleado_Nomvre")
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Empleado_ID");

                    b.ToTable("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
