using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgretimElemanlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SicilNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimElemanlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersKontenjani = table.Column<int>(type: "int", nullable: false),
                    DersiVerenOgretimElemaniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dersler_OgretimElemanlari_DersiVerenOgretimElemaniId",
                        column: x => x.DersiVerenOgretimElemaniId,
                        principalTable: "OgretimElemanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersOgrenci",
                columns: table => new
                {
                    AldigiDerslerId = table.Column<int>(type: "int", nullable: false),
                    DersiAlanOgrencilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersOgrenci", x => new { x.AldigiDerslerId, x.DersiAlanOgrencilerId });
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Dersler_AldigiDerslerId",
                        column: x => x.AldigiDerslerId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersOgrenci_Ogrenciler_DersiAlanOgrencilerId",
                        column: x => x.DersiAlanOgrencilerId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_DersiVerenOgretimElemaniId",
                table: "Dersler",
                column: "DersiVerenOgretimElemaniId");

            migrationBuilder.CreateIndex(
                name: "IX_DersOgrenci_DersiAlanOgrencilerId",
                table: "DersOgrenci",
                column: "DersiAlanOgrencilerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersOgrenci");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "OgretimElemanlari");
        }
    }
}
