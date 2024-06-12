using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NygarnDemo.Migrations
{
    /// <inheritdoc />
    public partial class NygarnDemoFifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ProductPrice",
                table: "ShoppingCartLine",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAECRLU8ujstE0u2/++eeXDCkzRWdMutap+cSD5l0kkKI8uFxfvPLTNJq4PKY8GZUjXg==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEBkTranZcOUfbK1auOEB3QBkKD7//o7+tux+7aRFyNQGiuH0DCle0IfG+mcLr41QVA==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEMsM2Zu6xAQp5LOZ1/lwUE999ogvFcBYoQG6nGlG8GTpvRXtvqHHglD4ZwNtxkCzag==");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEBuvbDYrGuSmKNZOSMdQn6GZJsd88RggEcb6UMnI0/cQyFT9IpNcIvadyf5pirs/BA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "ShoppingCartLine");

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
        }
    }
}
