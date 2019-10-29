﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantGuide.Models;

namespace RestaurantGuide.Migrations
{
    [DbContext(typeof(RestaurantGuideContext))]
    [Migration("20191029170521_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RestaurantGuide.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Cuisine");

                    b.Property<string>("Name");

                    b.Property<int>("Neighborhood");

                    b.Property<string>("Quadrant");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
