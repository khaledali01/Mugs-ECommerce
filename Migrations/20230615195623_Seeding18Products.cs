﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Migrations
{
    /// <inheritdoc />
    public partial class Seeding18Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Products",
                newName: "Color");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Brand", "Color", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Funny Mugs, LOL", "Black", "Legendary Coffee Mug Level 110 - Large Ceramic Black Coffee Mug 15oz - Gaming, Gamer Cup.", "/images/MMO Mug.jpg", "MMO Mug", 31m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Brand", "Color", "Description", "ImageURL", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 2, "Bubble Hugs", "Black", "Gaming Progress - Video Game Funny Humor Sarcasm Saying 15oz Black.", "/images/Bubble Hugs Mug.jpg", "Bubble Hugs Mug", 22m, 1 },
                    { 3, "HEYTEE", "White", "LHEYTEE Funny Coffee Mugs for Dad Coffee Mug, 11oz Ceramic Dad Coffee Cup_009.", "/images/HEYTEE Mug.jpg", "HEYTEE Mug", 27m, 1 },
                    { 4, "LiqCool", "Purple", "Sometimes You Forget Youre Awesome Coffee Mug, Thank You Gifts, Gifts for Coworkers, Birthday Christmas Appreciation Gift for Employee Women Men (12 oz, Purple).", "/images/LiqCool Mug.jpg", "LiqCool Mug", 35m, 1 },
                    { 5, "Sodilly", "Black", "Gaming Mugs for Men - Gamer Gifts for Men - Gifts for Gamer Boyfriend - Boys Gaming Room Decor - Gamer Cup Insulated Stainless Steel 16 oz Black Funny Tumbler for Men.", "/images/Sodilly Mug.jpg", "Sodilly Mug", 23m, 1 },
                    { 6, "Onebttl", "Black/Green", "Gaming Mugs , Boys, Teen, 20oz Stainless Steel Tumbler, Gifts For Christmas, Birthday- I'd Rather Be Gaming.", "/images/Onebttl Mug.jpg", "Onebttl Mug", 31m, 1 },
                    { 7, "ECKOI", "Black Mesa", "Unique Black Mesa Research Facility Mug Gamer Gift Geek Gift Gaming Gift Half Life Portal Valve Birthday Gift For my mother funny humor cup gift coffee tea ceramic cup friends men 11oz.", "/images/ECKOI Mug.jpg", "ECKOI Mug", 42m, 1 },
                    { 8, "3dRose", "White/Black", "computer pro-gamer in black and purple Mug, 1 Count (Pack of 1).", "/images/3dRose Mug.jpg", "3dRose Mug", 22m, 1 },
                    { 9, "KrysDesigns", "White", "Can't Hear You I'm Gaming Mug - Gamer Coffee Mug - Video Game Player Gaming Mug - Coffee Mug 11oz, White.", "/images/KrysDesigns Mug.jpg", "KrysDesigns Mug", 45m, 1 },
                    { 10, "Vsitoo", "Black", "S3 Temperature Control Smart Mug 2 with Lid, Self Heating Coffee Mug 10 oz, LED Display, 90 Min Battery Life - App&Manual Controlled Heated Coffee Mug - Improved Design - Perfect Coffee Gifts.", "/images/Vsitoo Mug.jpg", "Vsitoo Mug", 31m, 1 },
                    { 11, "Paladone", "Black/White", "Playstation 5 Heat Change Mug -Officially Licensed Merchandise.", "/images/Paladone Mug.jpg", "Paladone Mug", 37m, 1 },
                    { 12, "Nofinis", "Black", "Heat Changing Sensitive Mug - Cool Coffee & Tea Magic Color Change Cup Battery Meter Charging Design Ceramic Mug Gift Idea for Mom Dad Women & Men.", "/images/Nofinis Mug.jpg", "Nofinis Mug", 41m, 1 },
                    { 13, "YHRJWN", "White/Pink", "Gifts for Women, Thank You Awesome Mug, Coworkers Leaving Gifts for Women, Thank You Gifts for Friends Employee Assistant, Administrative Professional Day Christmas Gifts with Keychain 11 Oz.", "/images/YHRJWN Mug.jpg", "YHRJWN Mug", 31m, 1 },
                    { 14, "MUGNIV", "White", "Game Over Controller Novelty Mug: Ceramic Coffee Mugs & Tea Cup , Unique & Fun Cool Mug for Gamers, Coffee Lovers Gifts, Video Game Decor Kitchen Cups - 12.4 Oz.", "/images/MUGNIV Mug.jpg", "MUGNIV Mug", 36m, 1 },
                    { 15, "HOOMUU", "White", "Gaming Coffee Mug Gift- Tears Of My Enemies - Funny Ceramic Coffee Mugs for Boyfriend Men Sisters - Novetly Wine Glasses for Fathers Day Birthday Valentines Gifts.", "/images/HOOMUU Mug.jpg", "HOOMUU Mug", 29m, 1 },
                    { 16, "Ember", "Rose Gold", "Temperature Control Smart Mug 2, 10 Oz, App-Controlled Heated Coffee Mug with 80 Min Battery Life and Improved Design, Rose Gold.", "/images/Ember Mug.jpg", "Ember Mug", 33m, 1 },
                    { 17, "Wampumtuk", "White", "Addicted to Pot 11 Ounces Funny Coffee Mug.", "/images/Wampumtuk Mug.jpg", "Wampumtuk Mug", 46m, 1 },
                    { 18, "KTOTKMOTA", "Dark Grey", "Nordic Viking Rune Mug Tankard Stainless Steel Wooden Resin 3D Norse Decor Coffee Cool Gothic Beer Tankard Stein Cup Mugs 20oz.", "/images/KTOTKMOTA Mug.jpg", "KTOTKMOTA Mug", 56m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Products",
                newName: "Category");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Category", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Diagnostic Equipment", "Accurately measures your oxygen saturation levels and pulse rate.", "/images/pulse-oximeter.jpg", "Pulse Oximeter", 29m });
        }
    }
}
