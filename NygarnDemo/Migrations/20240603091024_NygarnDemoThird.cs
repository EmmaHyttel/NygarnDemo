using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NygarnDemo.Migrations
{
    /// <inheritdoc />
    public partial class NygarnDemoThird : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Amount", "Brand", "Description", "Name", "Price" },
                values: new object[] { 1, "Sandnes garn", "100% merinould uden superwashbehandling \nKan maskinvaskes på 30 grader uldprogram", "Double Sunday", 57m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Amount", "Brand", "Description", "Name", "Price" },
                values: new object[] { 1, "Sandnes garn", "57% mohair, 15% uld og 28% silke \nKan maskinvaskes ved 30 grader (uldprogram)", "Tynn Silk Mohair", 75m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Brand", "Description", "Name", "Price" },
                values: new object[] { "Sandnes garn", "57% mohair, 15% uld og 28% silke \nKan maskinvaskes ved 30 grader (uldprogram)", "Tynn Silk Mohair", 75m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEKUPWVrqMiuCaNcKIefSFgJ+ywbnuTUKSQKcpeTY9ZpCuN6A3u8jl/hHlowqMIAP9A==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEKht3Yb0K8bFJppJItL5f5Ih9sKwMbV/yPFR/JGpUBm1HCKWpiEXLJgLkmllXZ8UIQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEDtSlkbI8lEG4fh5hRXxtMq70bbAOJIvZG5XsLlP/U6oLGjQyMwaYVgtEKBr4sMhkQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEEOG2J9hDiXRAOqEKiPU1SNrSLJ4MG15QJ340UERaB5UgFAUAYAnRlTc9Rip4WgcOQ==");

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Color", "KnittingTension", "MachineWash", "Material", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[] { 10, "21-22 masker = 10 cm", true, 7, 4, 50, "108 m" });

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Color", "KnittingTension", "MachineWash", "Material", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[] { 9, "24 m x 18 p = 10 x 10 cm", true, 2, 3, 25, "212 m" });

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Color", "KnittingTension", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[] { 5, "24 m x 18 p = 10 x 10 cm", 3, 25, "212 m" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Amount", "Brand", "Description", "Name", "Price" },
                values: new object[] { 10, "Sandnes", "Meget luksus garn, ikke egnet til påklædning.", "Luksus garn", 99m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Amount", "Brand", "Description", "Name", "Price" },
                values: new object[] { 10, "Sandne", "Meget luksus garn, ikke egnet til påklædning.", "Saga", 49m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Brand", "Description", "Name", "Price" },
                values: new object[] { "Sandnes", "Vildt lækkert mohair garn til din næste sweater", "MyHair", 79m });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEDIlBMEd7eZ1AHmECl290Po6H4LEnubdDP13OeRAen4BckQpg/yCvncpFYtVuEHSHQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAECRJ53KLBW+UXVC7gEbzoeDMbN6oVfS/q82m7RN500xAJ8iEvL8ImQvNGZuaKopRng==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAECOkL8UopYRtwKDxHmhpR9RF+nUwI2uqSG9vjh3MRLsjDNE6K77X4pff+An91bXZVw==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEHHnks1G9qcFEdYZbEg8gV55uaU/4zrcuDPWmIDXOu6mfjKZzwCoqZB71FoXFJ13BQ==");

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Color", "KnittingTension", "MachineWash", "Material", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[] { 0, "KnittingTension10mX10cm", false, 0, 2, 100, "Yardage400mPr50g" });

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Color", "KnittingTension", "MachineWash", "Material", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[] { 0, "KnittingTension10mX10cm", false, 0, 2, 100, "Yardage400mPr50g" });

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Color", "KnittingTension", "SuggestedNeedleSize", "Weight", "Yardage" },
                values: new object[] { 9, "knittingTension21mX10cm", 1, 50, "Yardage215mPr50g" });
        }
    }
}
