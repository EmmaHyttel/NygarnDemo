using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NygarnDemo.Migrations.ToolDb
{
    /// <inheritdoc />
    public partial class AddToolsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Tools", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "Amount", "Brand", "Description", "Name", "Price", "Size", "Type" },
                values: new object[,]
                {
                    { 1, 12, "PetitKnit", "Rigtig fine små knapper, der passer perfekt til lukningen på en bodystocking", "Babyknap", 30m, "5 mm", "Knapper" },
                    { 2, 1, "PetitKnit", "Fuldstændig præcis målebånd", "Målebånd", 25m, "100 cm", "Målebånd" },
                    { 3, 1, "Sandnes", "Super blødt bamsefyld til dit næste hækleprojekt", "Bamsefyld", 40m, "100 gram", "Fyld" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tools");
        }
    }
}
