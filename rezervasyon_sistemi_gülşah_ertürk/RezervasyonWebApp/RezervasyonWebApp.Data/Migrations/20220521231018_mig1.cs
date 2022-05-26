using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervasyonWebApp.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guzergahs",
                columns: table => new
                {
                    GuzergahId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslangic = table.Column<string>(type: "TEXT", nullable: true),
                    guzergah1 = table.Column<string>(type: "TEXT", nullable: true),
                    guzergah2 = table.Column<string>(type: "TEXT", nullable: true),
                    guzergah3 = table.Column<string>(type: "TEXT", nullable: true),
                    Bitis = table.Column<string>(type: "TEXT", nullable: true),
                    Tarih = table.Column<string>(type: "TEXT", nullable: true),
                    Saat = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Fiyat = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guzergahs", x => x.GuzergahId);
                });

            migrationBuilder.CreateTable(
                name: "Sehirs",
                columns: table => new
                {
                    SehirId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SehirAd = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirs", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "Bilets",
                columns: table => new
                {
                    BiletId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    Soyad = table.Column<string>(type: "TEXT", nullable: true),
                    Mail = table.Column<string>(type: "TEXT", nullable: true),
                    Nereden = table.Column<string>(type: "TEXT", nullable: true),
                    Nereye = table.Column<string>(type: "TEXT", nullable: true),
                    KoltukNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Fiyat = table.Column<double>(type: "REAL", nullable: false),
                    GuzergahId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilets", x => x.BiletId);
                    table.ForeignKey(
                        name: "FK_Bilets_Guzergahs_GuzergahId",
                        column: x => x.GuzergahId,
                        principalTable: "Guzergahs",
                        principalColumn: "GuzergahId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_GuzergahId",
                table: "Bilets",
                column: "GuzergahId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilets");

            migrationBuilder.DropTable(
                name: "Sehirs");

            migrationBuilder.DropTable(
                name: "Guzergahs");
        }
    }
}
