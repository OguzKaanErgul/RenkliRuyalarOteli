using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RenkliRuyalarOteli.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initdb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Rezervasyonlar");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "RezervasyonDetaylari");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Odalar");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "OdaFiyatlari");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<string>(
                name: "KullaniciId",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciRole",
                columns: table => new
                {
                    KullanicilarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RollerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciRole", x => new { x.KullanicilarId, x.RollerId });
                    table.ForeignKey(
                        name: "FK_KullaniciRole_Kullanicilar_KullanicilarId",
                        column: x => x.KullanicilarId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciRole_Roller_RollerId",
                        column: x => x.RollerId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciRole_RollerId",
                table: "KullaniciRole",
                column: "RollerId");

            migrationBuilder.CreateIndex(
                name: "IX_Roller_RoleName",
                table: "Roller",
                column: "RoleName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciRole");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "Rezervasyonlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "RezervasyonDetaylari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "Odalar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "OdaFiyatlari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
