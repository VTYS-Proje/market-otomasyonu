using Microsoft.EntityFrameworkCore.Migrations;

namespace Market_otomasyon.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "MusteriAd",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "MusteriSoyad",
                table: "Borcs");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriID",
                table: "Borcs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BorcId",
                table: "Borcs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs",
                column: "BorcId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs");

            migrationBuilder.DropColumn(
                name: "BorcId",
                table: "Borcs");

            migrationBuilder.AlterColumn<int>(
                name: "MusteriID",
                table: "Borcs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "MusteriAd",
                table: "Borcs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusteriSoyad",
                table: "Borcs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Borcs",
                table: "Borcs",
                column: "MusteriID");
        }
    }
}
