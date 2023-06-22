﻿// <auto-generated />
using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20230622213650_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommerce.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Brand = "Funny Mugs, LOL",
                            Color = "Black",
                            Description = "Legendary Coffee Mug Level 110 - Large Ceramic Black Coffee Mug 15oz - Gaming, Gamer Cup.",
                            ImageURL = "/images/MMO Mug.jpg",
                            Name = "MMO Mug",
                            Price = 31m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 2,
                            Brand = "Bubble Hugs",
                            Color = "Black",
                            Description = "Gaming Progress - Video Game Funny Humor Sarcasm Saying 15oz Black.",
                            ImageURL = "/images/Bubble Hugs Mug.jpg",
                            Name = "Bubble Hugs Mug",
                            Price = 22m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 3,
                            Brand = "HEYTEE",
                            Color = "White",
                            Description = "LHEYTEE Funny Coffee Mugs for Dad Coffee Mug, 11oz Ceramic Dad Coffee Cup_009.",
                            ImageURL = "/images/HEYTEE Mug.jpg",
                            Name = "HEYTEE Mug",
                            Price = 27m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 4,
                            Brand = "LiqCool",
                            Color = "Purple",
                            Description = "Sometimes You Forget Youre Awesome Coffee Mug, Thank You Gifts, Gifts for Coworkers, Birthday Christmas Appreciation Gift for Employee Women Men (12 oz, Purple).",
                            ImageURL = "/images/LiqCool Mug.jpg",
                            Name = "LiqCool Mug",
                            Price = 35m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 5,
                            Brand = "Sodilly",
                            Color = "Black",
                            Description = "Gaming Mugs for Men - Gamer Gifts for Men - Gifts for Gamer Boyfriend - Boys Gaming Room Decor - Gamer Cup Insulated Stainless Steel 16 oz Black Funny Tumbler for Men.",
                            ImageURL = "/images/Sodilly Mug.jpg",
                            Name = "Sodilly Mug",
                            Price = 23m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 6,
                            Brand = "Onebttl",
                            Color = "Black/Green",
                            Description = "Gaming Mugs , Boys, Teen, 20oz Stainless Steel Tumbler, Gifts For Christmas, Birthday- I'd Rather Be Gaming.",
                            ImageURL = "/images/Onebttl Mug.jpg",
                            Name = "Onebttl Mug",
                            Price = 31m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 7,
                            Brand = "ECKOI",
                            Color = "Black Mesa",
                            Description = "Unique Black Mesa Research Facility Mug Gamer Gift Geek Gift Gaming Gift Half Life Portal Valve Birthday Gift For my mother funny humor cup gift coffee tea ceramic cup friends men 11oz.",
                            ImageURL = "/images/ECKOI Mug.jpg",
                            Name = "ECKOI Mug",
                            Price = 42m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 8,
                            Brand = "3dRose",
                            Color = "White/Black",
                            Description = "computer pro-gamer in black and purple Mug, 1 Count (Pack of 1).",
                            ImageURL = "/images/3dRose Mug.jpg",
                            Name = "3dRose Mug",
                            Price = 22m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 9,
                            Brand = "KrysDesigns",
                            Color = "White",
                            Description = "Can't Hear You I'm Gaming Mug - Gamer Coffee Mug - Video Game Player Gaming Mug - Coffee Mug 11oz, White.",
                            ImageURL = "/images/KrysDesigns Mug.jpg",
                            Name = "KrysDesigns Mug",
                            Price = 45m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 10,
                            Brand = "Vsitoo",
                            Color = "Black",
                            Description = "S3 Temperature Control Smart Mug 2 with Lid, Self Heating Coffee Mug 10 oz, LED Display, 90 Min Battery Life - App&Manual Controlled Heated Coffee Mug - Improved Design - Perfect Coffee Gifts.",
                            ImageURL = "/images/Vsitoo Mug.jpg",
                            Name = "Vsitoo Mug",
                            Price = 31m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 11,
                            Brand = "Paladone",
                            Color = "Black/White",
                            Description = "Playstation 5 Heat Change Mug -Officially Licensed Merchandise.",
                            ImageURL = "/images/Paladone Mug.jpg",
                            Name = "Paladone Mug",
                            Price = 37m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 12,
                            Brand = "Nofinis",
                            Color = "Black",
                            Description = "Heat Changing Sensitive Mug - Cool Coffee & Tea Magic Color Change Cup Battery Meter Charging Design Ceramic Mug Gift Idea for Mom Dad Women & Men.",
                            ImageURL = "/images/Nofinis Mug.jpg",
                            Name = "Nofinis Mug",
                            Price = 41m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 13,
                            Brand = "YHRJWN",
                            Color = "White/Pink",
                            Description = "Gifts for Women, Thank You Awesome Mug, Coworkers Leaving Gifts for Women, Thank You Gifts for Friends Employee Assistant, Administrative Professional Day Christmas Gifts with Keychain 11 Oz.",
                            ImageURL = "/images/YHRJWN Mug.jpg",
                            Name = "YHRJWN Mug",
                            Price = 31m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 14,
                            Brand = "MUGNIV",
                            Color = "White",
                            Description = "Game Over Controller Novelty Mug: Ceramic Coffee Mugs & Tea Cup , Unique & Fun Cool Mug for Gamers, Coffee Lovers Gifts, Video Game Decor Kitchen Cups - 12.4 Oz.",
                            ImageURL = "/images/MUGNIV Mug.jpg",
                            Name = "MUGNIV Mug",
                            Price = 36m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 15,
                            Brand = "HOOMUU",
                            Color = "White",
                            Description = "Gaming Coffee Mug Gift- Tears Of My Enemies - Funny Ceramic Coffee Mugs for Boyfriend Men Sisters - Novetly Wine Glasses for Fathers Day Birthday Valentines Gifts.",
                            ImageURL = "/images/HOOMUU Mug.jpg",
                            Name = "HOOMUU Mug",
                            Price = 29m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 16,
                            Brand = "Ember",
                            Color = "Rose Gold",
                            Description = "Temperature Control Smart Mug 2, 10 Oz, App-Controlled Heated Coffee Mug with 80 Min Battery Life and Improved Design, Rose Gold.",
                            ImageURL = "/images/Ember Mug.jpg",
                            Name = "Ember Mug",
                            Price = 33m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 17,
                            Brand = "Wampumtuk",
                            Color = "White",
                            Description = "Addicted to Pot 11 Ounces Funny Coffee Mug.",
                            ImageURL = "/images/Wampumtuk Mug.jpg",
                            Name = "Wampumtuk Mug",
                            Price = 46m,
                            Quantity = 1
                        },
                        new
                        {
                            ProductID = 18,
                            Brand = "KTOTKMOTA",
                            Color = "Dark Grey",
                            Description = "Nordic Viking Rune Mug Tankard Stainless Steel Wooden Resin 3D Norse Decor Coffee Cool Gothic Beer Tankard Stein Cup Mugs 20oz.",
                            ImageURL = "/images/KTOTKMOTA Mug.jpg",
                            Name = "KTOTKMOTA Mug",
                            Price = 56m,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("ECommerce.Data.UserModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
