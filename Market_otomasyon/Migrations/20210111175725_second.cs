using Microsoft.EntityFrameworkCore.Migrations;

namespace Market_otomasyon.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SaticiAd",
                table: "Satıcıs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaticiSoyad",
                table: "Satıcıs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaticiAd",
                table: "Satıcıs");

            migrationBuilder.DropColumn(
                name: "SaticiSoyad",
                table: "Satıcıs");
        }
    }
}
