﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantGuide.Models;

namespace RestaurantGuide.Migrations
{
    [DbContext(typeof(RestaurantGuideContext))]
    [Migration("20191029175613_moreSeeding")]
    partial class moreSeeding
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

                    b.Property<string>("Neighborhood");

                    b.Property<string>("Quadrant");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Address = "3808 N Williams Ave st 127, Portland, OR 97227",
                            Cuisine = "Thai BBQ",
                            Name = "Eem",
                            Neighborhood = "Boise",
                            Quadrant = "NE"
                        },
                        new
                        {
                            RestaurantId = 2,
                            Address = "304 SE 28th Ave, Portland, OR 97214",
                            Cuisine = "Pizza",
                            Name = "Ken's Artisan Pizza",
                            Neighborhood = "Kerns",
                            Quadrant = "SE"
                        },
                        new
                        {
                            RestaurantId = 3,
                            Address = "2112 NW Kearney St, Portland, OR 97210",
                            Cuisine = "Italian",
                            Name = "Serratto",
                            Neighborhood = "Nob Hill",
                            Quadrant = "NW"
                        },
                        new
                        {
                            RestaurantId = 4,
                            Address = "609 SE Ankeny St A, Portland, OR 97214",
                            Cuisine = "Japanese",
                            Name = "Marukin",
                            Neighborhood = "Buckman",
                            Quadrant = "SE"
                        },
                        new
                        {
                            RestaurantId = 5,
                            Address = "813 SW Alder St, Portland, OR 97205",
                            Cuisine = "American",
                            Name = "Bullard",
                            Neighborhood = "Downtown",
                            Quadrant = "SW"
                        },
                        new
                        {
                            RestaurantId = 6,
                            Address = "200 NE 28th Ave, Portland, OR 97232",
                            Cuisine = "Mexican",
                            Name = "Guero",
                            Neighborhood = "Kerns",
                            Quadrant = "NE"
                        },
                        new
                        {
                            RestaurantId = 7,
                            Address = "828 SE Ash St, Portland, OR 97214",
                            Cuisine = "Breakfast",
                            Name = "La Luna Cafe",
                            Neighborhood = "Buckman",
                            Quadrant = "SE"
                        },
                        new
                        {
                            RestaurantId = 8,
                            Address = "1401 SE Morrison St Ste. 101, Portland, OR 97214",
                            Cuisine = "Italian",
                            Name = "Nostrana",
                            Neighborhood = "Buckman",
                            Quadrant = "SE"
                        },
                        new
                        {
                            RestaurantId = 9,
                            Address = "210 SE Martin Luther King Jr Blvd, Portland, OR 97214",
                            Cuisine = "Korean",
                            Name = "Revelry",
                            Neighborhood = "Buckman",
                            Quadrant = "NW"
                        },
                        new
                        {
                            RestaurantId = 10,
                            Address = "4090 N Williams Ave, Portland, OR 97227",
                            Cuisine = "Chinese",
                            Name = "XLB",
                            Neighborhood = "Nob Hill",
                            Quadrant = "NE"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
