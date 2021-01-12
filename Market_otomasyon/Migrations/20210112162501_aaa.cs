using Microsoft.EntityFrameworkCore.Migrations;

namespace Market_otomasyon.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "IrsaliyeNo",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "Odeme",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "TedarikciNo",
                table: "Borcs");

            migrationBuilder.AddColumn<int>(
                name: "MusteriID",
                table: "Borcs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "MusteriAd",
                table: "Borcs",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MusteriOdeme",
                table: "Borcs",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MusteriSoyad",
                table: "Borcs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SatinAlmaTarihi",
                table: "Borcs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Tutar",
                table: "Borcs",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs",
                column: "MusteriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "MusteriID",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "MusteriAd",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "MusteriOdeme",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "MusteriSoyad",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "SatinAlmaTarihi",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "Tutar",
                table: "Borcs");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Borcs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IrsaliyeNo",
                table: "Borcs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Odeme",
                table: "Borcs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tarih",
                table: "Borcs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TedarikciNo",
                table: "Borcs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs",
                column: "Id");
        }
    }
}
