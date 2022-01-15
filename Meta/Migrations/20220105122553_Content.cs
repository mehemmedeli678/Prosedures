using Microsoft.EntityFrameworkCore.Migrations;

namespace Meta.Migrations
{
    public partial class Content : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContentID",
                table: "TvShow",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TvShow_ContentID",
                table: "TvShow",
                column: "ContentID");

            migrationBuilder.AddForeignKey(
                name: "FK_TvShow_Content_ContentID",
                table: "TvShow",
                column: "ContentID",
                principalTable: "Content",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvShow_Content_ContentID",
                table: "TvShow");

            migrationBuilder.DropIndex(
                name: "IX_TvShow_ContentID",
                table: "TvShow");

            migrationBuilder.DropColumn(
                name: "ContentID",
                table: "TvShow");
        }
    }
}
