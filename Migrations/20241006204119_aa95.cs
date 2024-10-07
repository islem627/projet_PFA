using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_back_.Migrations
{
    /// <inheritdoc />
    public partial class aa95 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    IdClient = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horaire = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NumTel = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.IdClient);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
