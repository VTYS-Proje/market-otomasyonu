using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Market_otomasyon.Migrations
{
    public partial class deneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PesinSatis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(nullable: false),
                    MusteriID = table.Column<int>(nullable: false),
                    Tutar = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PesinSatis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Satis",
                columns: table => new
                {
                    SatisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(nullable: false),
                    MusteriID = table.Column<int>(nullable: false),
                    UrunID = table.Column<int>(nullable: false),
                    SatisTipi = table.Column<string>(nullable: true),
                    Miktar = table.Column<int>(nullable: false),
                    Tutar = table.Column<double>(nullable: false),
                    SatinAlmaTarihi = table.Column<DateTime>(nullable: false),
                    Barkod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satis", x => x.SatisId);
                });

            migrationBuilder.CreateTable(
                name: "Stok",
                columns: table => new
                {
                    StokId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunKodu = table.Column<int>(nullable: false),
                    Barkod = table.Column<int>(nullable: false),
                    Cesit = table.Column<string>(nullable: true),
                    StokMiktari = table.Column<int>(nullable: false),
                    UrunAdi = table.Column<string>(nullable: true),
                    BirimGirdiFiyat = table.Column<double>(nullable: false),
                    Miktar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stok", x => x.StokId);
                });

            migrationBuilder.CreateTable(
                name: "TedarikciBorcs",
                columns: table => new
                {
                    TedarikciBorcId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TedarikciID = table.Column<int>(nullable: false),
                    Tedarikcisim = table.Column<string>(nullable: true),
                    IrsaliyeNo = table.Column<int>(nullable: false),
                    TedarikBorc = table.Column<double>(nullable: false),
                    TedarikOdeme = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TedarikciBorcs", x => x.TedarikciBorcId);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikcis",
                columns: table => new
                {
                    TedarikciID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tedarikcisim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikcis", x => x.TedarikciID);
                });

            migrationBuilder.CreateTable(
                name: "VeresiyeSatis",
                columns: table => new
                {
                    VeresiyeSatisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(nullable: false),
                    MusteriAd = table.Column<string>(nullable: true),
                    MusteriSoyad = table.Column<string>(nullable: true),
                    SatinAlmaTarihi = table.Column<DateTime>(nullable: false),
                    Tutar = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeresiyeSatis", x => x.VeresiyeSatisID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PesinSatis");

            migrationBuilder.DropTable(
                name: "Satis");

            migrationBuilder.DropTable(
                name: "Stok");

            migrationBuilder.DropTable(
                name: "TedarikciBorcs");

            migrationBuilder.DropTable(
                name: "Tedarikcis");

            migrationBuilder.DropTable(
                name: "VeresiyeSatis");
        }
    }
}
