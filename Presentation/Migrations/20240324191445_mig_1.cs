using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinYili = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false),
                    UyeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Uyeler_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uyeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_UyeId",
                table: "Kitaplar",
                column: "UyeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Uyeler");
        }
    }
}
