using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrenciMvcOdev.Migrations
{
    public partial class Ogrencidb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOgrenciler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Numara = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciler", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgrenciler");
        }
    }
}
