using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NygarnDemo.Migrations.NeedleDb
{
    /// <inheritdoc />
    public partial class NeedleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KnittingNeedles",
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
                    table.PrimaryKey("PK_KnittingNeedles", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "KnittingNeedles",
                columns: new[] { "ProductId", "Amount", "Brand", "Description", "Material", "Name", "Price", "Set", "Size", "Type" },
                values: new object[,]
                {
                    { 1, 2, "PetitKnit", "Gode til alt", 0, "KnitPro", 149m, true, 3, 1 },
                    { 2, 2, "PetitKnit", "Dejlig store", 2, "Hot", 499m, true, 5, 3 },
                    { 3, 2, "PetitKnit", "Gode til alt", 0, "KnitPro", 140m, true, 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnittingNeedles");
        }
    }
}
