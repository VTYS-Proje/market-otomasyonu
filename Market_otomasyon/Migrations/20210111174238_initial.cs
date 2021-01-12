using Microsoft.EntityFrameworkCore.Migrations;

namespace Market_otomasyon.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borcs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IrsaliyeNo = table.Column<int>(nullable: false),
                    TedarikciNo = table.Column<int>(nullable: false),
                    Odeme = table.Column<int>(nullable: false),
                    Tarih = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borcs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    MusteriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAd = table.Column<string>(nullable: true),
                    MusteriSoyad = table.Column<string>(nullable: true),
                    TelefonNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "Satıcıs",
                columns: table => new
                {
                    SaticiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satıcıs", x => x.SaticiID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borcs");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Satıcıs");
        }
    }
}
