using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NygarnDemo.Migrations.UserDb
{
    /// <inheritdoc />
    public partial class UserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserName", "Address", "Email", "Id", "LastName", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { "admin", "En sej gade", "nem_hard@garn.dk", 1, "HARD", "NEM", "AQAAAAIAAYagAAAAEAAMeIGKJFk1yT6hmPGY7/rx+FmjwsH5VIsof66kohgEA3gt4j7X4+Q+yOCWTAjGig==", "69696969" },
                    { "EmmaStrikker123", "Vejgade 1", "emmastrikker@garn.dk", 2, "Hyttel", "Emma", "AQAAAAIAAYagAAAAEOzOU3S3D8nfS6dien7ag/g3Zums2dxOUOrCn31/sZgx6q5jqwwJ/v8aQily8oQ7Ew==", "12345678" },
                    { "MaiStrikker123", "Vejgade 2", "maistrikker@garn.dk", 3, "Dinh", "Mai", "AQAAAAIAAYagAAAAEB8pH++OUUonsZM33Ouy7UeIJmq/OPuki+HYMpECc2zdpDBnf8I8GkbuYIa3fk56Jg==", "23456789" },
                    { "NannaHækler123", "Vejgade 3", "nannahækler@garn.dk", 4, "Rister", "Nanna", "AQAAAAIAAYagAAAAELv+Dmug3b4JaOE/vf8pdY7laP6zMUlVLIegGK3DYqyDWD2HwLvRBBrvF4USFo3JuQ==", "34567891" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
