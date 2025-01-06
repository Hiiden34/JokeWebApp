using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokeWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewUserTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserCustom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCustom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRolesCustom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRolesCustom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRolesCustom_UserCustom_UserId",
                        column: x => x.UserId,
                        principalTable: "UserCustom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRolesCustom_UserId",
                table: "UserRolesCustom",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRolesCustom");

            migrationBuilder.DropTable(
                name: "UserCustom");
        }
    }
}
