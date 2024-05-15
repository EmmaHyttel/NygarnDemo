using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NygarnDemo.Migrations.HookDb
{
    /// <inheritdoc />
    public partial class AddHookDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Hook", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hook",
                columns: new[] { "Id", "Amount", "Brand", "Description", "Material", "Name", "Price", "Set", "Size" },
                values: new object[,]
                {
                    { 1, 1, "PetitKnit", "Gode til alt", 0, "Knyt", 49m, true, 7 },
                    { 2, 2, "PetitKnit", "Gode til alt", 0, "KnitPro", 149m, false, 3 },
                    { 3, 1, "PetitKnit", "Den bedste hækle nål", 0, "KnitPro", 599m, false, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hook");
        }
    }
}
