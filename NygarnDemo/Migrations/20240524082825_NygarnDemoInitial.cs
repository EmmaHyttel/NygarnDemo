using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NygarnDemo.Migrations
{
    /// <inheritdoc />
    public partial class NygarnDemoInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
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
                name: "CrochetHook",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Set = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrochetHook", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_CrochetHook_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnittingNeedle",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Set = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnittingNeedle", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_KnittingNeedle_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tool",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tool", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Tool_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yarn",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    KnittingTension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yardage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    SuggestedNeedleSize = table.Column<int>(type: "int", nullable: false),
                    MachineWash = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yarn", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Yarn_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartLine_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartLine_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Amount", "Brand", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 10, "Sandnes", "Meget luksus garn, ikke egnet til påklædning.", "Luksus garn", 99m },
                    { 2, 10, "Sandne", "Meget luksus garn, ikke egnet til påklædning.", "Saga", 49m },
                    { 3, 1, "Sandnes", "Vildt lækkert mohair garn til din næste sweater", "MyHair", 79m },
                    { 4, 1, "Petitknit", "Vildt lækkert alpakka garn til dit næste tørklæde", "MaLamaa", 69m },
                    { 5, 1, "Petitknit", "Vildt lækkert silke garn til dit næste hårbånd", "SlikkeSilke", 75m },
                    { 6, 12, "PetitKnit", "Rigtig fine små knapper, der passer perfekt til lukningen på en bodystocking", "Babyknap", 30m },
                    { 7, 1, "PetitKnit", "Fuldstændig præcis målebånd", "Målebånd", 25m },
                    { 8, 1, "Sandnes", "Super blødt bamsefyld til dit næste hækleprojekt", "Bamsefyld", 40m },
                    { 9, 1, "KnitPro", "Gode til alt", "KnitPro", 149m },
                    { 10, 1, "KnitPro", "Dejlig store", "Hot", 499m },
                    { 11, 1, "KnitPro", "Gode til alt", "KnitPro", 140m },
                    { 12, 1, "PetitKnit", "Gode til alt", "Knyt", 49m },
                    { 13, 2, "PetitKnit", "Gode til alt", "KnitPro", 149m },
                    { 14, 1, "PetitKnit", "", "NeedlePickled", 599m }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Email", "LastName", "Name", "Password", "Phone", "UserName" },
                values: new object[,]
                {
                    { 1, "En sej gade", "nem_hard@garn.dk", "HARD", "NEM", "AQAAAAIAAYagAAAAEEGcMi0jwI3VAOdvQbDRdfkrBWT6+LFY7EEOd/OIt4dT1cMPSZcFdNHmcyzOqkJIaQ==", "69696969", "admin" },
                    { 2, "Vejgade 1", "emmastrikker@garn.dk", "Hyttel", "Emma", "AQAAAAIAAYagAAAAEJ9dViV3CjJcj4oSkYRdOqfjKIJpv7h8ozU0tmOy9uxtB6UWUDAiN7EXFoMXXO7TgA==", "12345678", "EmmaStrikker123" },
                    { 3, "Vejgade 2", "maistrikker@garn.dk", "Dinh", "Mai", "AQAAAAIAAYagAAAAEPixrPm2apbSGBGRVQOHX2cKbJqqEsFLRx1IlwAGfxj/XrbS8s68zh1XA5ZS6+4Frg==", "23456789", "MaiStrikker123" },
                    { 4, "Vejgade 3", "nannahækler@garn.dk", "Rister", "Nanna", "AQAAAAIAAYagAAAAEIc5asf8/zgQNJgkatMvEi4JA2Sqq/R60bqEFG879VqBqiMxE6r24LdqhMqmXkrI6g==", "34567891", "NannaHækler123" }
                });

            migrationBuilder.InsertData(
                table: "CrochetHook",
                columns: new[] { "ProductId", "Material", "Set", "Size" },
                values: new object[,]
                {
                    { 12, 0, true, 7 },
                    { 13, 0, false, 3 },
                    { 14, 0, false, 9 }
                });

            migrationBuilder.InsertData(
                table: "KnittingNeedle",
                columns: new[] { "ProductId", "Material", "Set", "Size", "Type" },
                values: new object[,]
                {
                    { 9, 0, true, 3, 1 },
                    { 10, 2, true, 5, 3 },
                    { 11, 0, true, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tool",
                columns: new[] { "ProductId", "Size", "Type" },
                values: new object[,]
                {
                    { 6, "5 mm", "Knapper" },
                    { 7, "100 cm", "Målebånd" },
                    { 8, "100 gram", "Fyld" }
                });

            migrationBuilder.InsertData(
                table: "Yarn",
                columns: new[] { "ProductId", "Color", "KnittingTension", "MachineWash", "Material", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[,]
                {
                    { 1, 0, "KnittingTension10mX10cm", false, 0, 2, 100, "Yardage400mPr50g" },
                    { 2, 0, "KnittingTension10mX10cm", false, 0, 2, 100, "Yardage400mPr50g" },
                    { 3, 9, "knittingTension21mX10cm", true, 2, 1, 50, "Yardage215mPr50g" },
                    { 4, 9, "knittingTension25mX10cm", true, 0, 3, 50, "Yardage300mPr50g" },
                    { 5, 0, "knittingTension30mX10cm", false, 1, 5, 50, "Yardage400mPr50g" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartLine_ProductId",
                table: "ShoppingCartLine",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartLine_UserId",
                table: "ShoppingCartLine",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrochetHook");

            migrationBuilder.DropTable(
                name: "KnittingNeedle");

            migrationBuilder.DropTable(
                name: "ShoppingCartLine");

            migrationBuilder.DropTable(
                name: "Tool");

            migrationBuilder.DropTable(
                name: "Yarn");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
