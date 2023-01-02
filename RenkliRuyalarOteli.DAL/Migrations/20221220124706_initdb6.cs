using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RenkliRuyalarOteli.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initdb6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Roller",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Rezervasyonlar",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "RezervasyonDetaylari",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Odalar",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "OdaFiyatlari",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Musteriler",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Kullanicilar",
                newName: "UpdateDate");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Kullanicilar");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Roller",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Rezervasyonlar",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "RezervasyonDetaylari",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Odalar",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "OdaFiyatlari",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Musteriler",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Kullanicilar",
                newName: "UpdateTime");
        }
    }
}
