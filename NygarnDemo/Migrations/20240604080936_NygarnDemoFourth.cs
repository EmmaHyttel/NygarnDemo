using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NygarnDemo.Migrations
{
    /// <inheritdoc />
    public partial class NygarnDemoFourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "SuggestedNeedleSize",
                table: "Yarn",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEM6trogWXYuec4P3cd8F12neDc2kM1Nx7UDDn4vkGjoj3ELeusC8g31UTFc5Aa4J/w==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEC6W8MARafSPhTw3/usnnN18Iy9mKu96txHOtA2GcCYRwYymozCs6c0AUsq76oWzCQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEIBTkXa6inpu4hSnTWd1A4HY5emxcchTxQrYfp57wAdJzgC2QnjF0Fbe9I7+ACT/GQ==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEIt69IyF4ky8X/9xgT51x4Vxle+gIfa0Nf3ytwxh2jdR7jvqLxJcHis3qchhi1xtlw==");

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "SuggestedNeedleSize",
                value: "pind 3.5-4");

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "SuggestedNeedleSize",
                value: "pind 4-5");

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "SuggestedNeedleSize",
                value: "pind 3-5");

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "SuggestedNeedleSize",
                value: "pind 6-8");

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "SuggestedNeedleSize",
                value: "pind 4-5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SuggestedNeedleSize",
                table: "Yarn",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Amount",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Amount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Amount",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Amount",
                value: 1);

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
                column: "SuggestedNeedleSize",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "SuggestedNeedleSize",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "SuggestedNeedleSize",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "SuggestedNeedleSize",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Yarn",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "SuggestedNeedleSize",
                value: 5);
        }
    }
}
