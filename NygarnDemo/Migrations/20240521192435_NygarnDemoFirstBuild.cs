using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NygarnDemo.Migrations
{
    /// <inheritdoc />
    public partial class NygarnDemoFirstBuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrochetHook",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Set = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrochetHook", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "KnittingNeedle",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Set = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnittingNeedle", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Tool",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tool", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yarn",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<int>(type: "int", nullable: false),
                    KnittingTension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yardage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    SuggestedNeedleSize = table.Column<int>(type: "int", nullable: false),
                    MachineWash = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yarn", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "CrochetHook",
                columns: new[] { "ProductId", "Amount", "Brand", "Description", "Material", "Name", "Price", "Set", "Size" },
                values: new object[,]
                {
                    { 12, 1, "PetitKnit", "Gode til alt", 0, "Knyt", 49m, true, 7 },
                    { 13, 2, "PetitKnit", "Gode til alt", 0, "KnitPro", 149m, false, 3 },
                    { 14, 1, "PetitKnit", "", 0, "NeedlePickled", 599m, false, 9 }
                });

            migrationBuilder.InsertData(
                table: "KnittingNeedle",
                columns: new[] { "ProductId", "Amount", "Brand", "Description", "Material", "Name", "Price", "Set", "Size", "Type" },
                values: new object[,]
                {
                    { 9, 1, "KnitPro", "Gode til alt", 0, "KnitPro", 149m, true, 3, 1 },
                    { 10, 1, "KnitPro", "Dejlig store", 2, "Hot", 499m, true, 5, 3 },
                    { 11, 1, "KnitPro", "Gode til alt", 0, "KnitPro", 140m, true, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tool",
                columns: new[] { "ProductId", "Amount", "Brand", "Description", "Name", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { 6, 12, "PetitKnit", "Rigtig fine små knapper, der passer perfekt til lukningen på en bodystocking", "Babyknap", 30m, "5 mm", "Knapper" },
                    { 7, 1, "PetitKnit", "Fuldstændig præcis målebånd", "Målebånd", 25m, "100 cm", "Målebånd" },
                    { 8, 1, "Sandnes", "Super blødt bamsefyld til dit næste hækleprojekt", "Bamsefyld", 40m, "100 gram", "Fyld" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Email", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[,]
                {
                    { 1, "En sej gade", "nem_hard@garn.dk", "HARD", "NEM", "AQAAAAIAAYagAAAAECQDyY6K24yv2ehULt1b5FWBlkE50XmD+tX+j5jUfGFUgjQRGGq1rlStlVKBsDq06w==", "69696969", "admin" },
                    { 2, "Vejgade 1", "emmastrikker@garn.dk", "Hyttel", "Emma", "AQAAAAIAAYagAAAAEF5MYMhayyKfLJSU1NsDG+ArABWm4SnHbdbyYQS6IKZZIKv/qw4W2z2L4JiBFMfByQ==", "12345678", "EmmaStrikker123" },
                    { 3, "Vejgade 2", "maistrikker@garn.dk", "Dinh", "Mai", "AQAAAAIAAYagAAAAELj0Us2slW5KmMlhxWSnxmmEV5yN8QI5IQPb5Vq70RSRLW8yVSJsZTtpCd4qpIpF5A==", "23456789", "MaiStrikker123" },
                    { 4, "Vejgade 3", "nannahækler@garn.dk", "Rister", "Nanna", "AQAAAAIAAYagAAAAEIW4C7h41bCXLt6ns8TzyjWn+UByAYynClbCBQH4Wo6uD1IYQ6zTZeDnf8AhntOYmQ==", "34567891", "NannaHækler123" }
                });

            migrationBuilder.InsertData(
                table: "Yarn",
                columns: new[] { "ProductId", "Amount", "Brand", "Color", "Description", "KnittingTension", "MachineWash", "Material", "Name", "Price", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[,]
                {
                    { 1, 10, "Sandnes", 0, "Meget luksus garn, ikke egnet til påklædning.", "KnittingTension10mX10cm", false, 0, "Luksus garn", 99m, 2, 100, "Yardage400mPr50g" },
                    { 2, 10, "Sandne", 0, "Meget luksus garn, ikke egnet til påklædning.", "KnittingTension10mX10cm", false, 0, "Saga", 49m, 2, 100, "Yardage400mPr50g" },
                    { 3, 1, "Sandnes", 9, "Vildt lækkert mohair garn til din næste sweater", "knittingTension21mX10cm", true, 2, "MyHair", 79m, 1, 50, "Yardage215mPr50g" },
                    { 4, 1, "Petitknit", 9, "Vildt lækkert alpakka garn til dit næste tørklæde", "knittingTension25mX10cm", true, 0, "MaLamaa", 69m, 3, 50, "Yardage300mPr50g" },
                    { 5, 1, "Petitknit", 0, "Vildt lækkert silke garn til dit næste hårbånd", "knittingTension30mX10cm", false, 1, "SlikkeSilke", 75m, 5, 50, "Yardage400mPr50g" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrochetHook");

            migrationBuilder.DropTable(
                name: "KnittingNeedle");

            migrationBuilder.DropTable(
                name: "Tool");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Yarn");
        }
    }
}
