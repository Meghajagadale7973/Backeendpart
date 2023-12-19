﻿// <auto-generated />
using COOKING_RECIPE_PORTAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace COOKING_RECIPE_PORTAL.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20231128052414_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("COOKING_RECIPE_PORTAL.Model.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Mobile_No")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("COOKING_RECIPE_PORTAL.Model.NonVeg_Recipe", b =>
                {
                    b.Property<int>("Recipe_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Recipe_Id"));

                    b.Property<string>("Recipe_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ingredient")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("procedure")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("recipeimages")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Recipe_Id");

                    b.ToTable("NonVeg_Recipe");
                });

            modelBuilder.Entity("COOKING_RECIPE_PORTAL.Model.Veg_Recipe", b =>
                {
                    b.Property<int>("Recipe_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Recipe_Id"));

                    b.Property<string>("Recipe_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ingredient")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("procedure")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("recipeimages")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Recipe_Id");

                    b.ToTable("Veg_Recipe");
                });
#pragma warning restore 612, 618
        }
    }
}
