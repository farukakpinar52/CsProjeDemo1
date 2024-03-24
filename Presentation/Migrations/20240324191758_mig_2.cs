using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentation.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Uyeler_UyeId",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "Kitaplar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Uyeler_UyeId",
                table: "Kitaplar",
                column: "UyeId",
                principalTable: "Uyeler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Uyeler_UyeId",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Uyeler_UyeId",
                table: "Kitaplar",
                column: "UyeId",
                principalTable: "Uyeler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
