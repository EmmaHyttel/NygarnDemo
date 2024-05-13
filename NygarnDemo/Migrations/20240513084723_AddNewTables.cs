using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NygarnDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YarnProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<int>(type: "int", nullable: false),
                    KnittingTension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yardage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    MachineWash = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YarnProducts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "YarnProducts",
                columns: new[] { "Id", "Amount", "Brand", "Color", "Description", "KnittingTension", "MachineWash", "Material", "Name", "Price", "Size", "Weight", "Yardage" },
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
                name: "YarnProducts");
        }
    }
}
