using Microsoft.EntityFrameworkCore.Migrations;

namespace Meta.Migrations
{
    public partial class ISSubcribe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "İsSubscribe",
                table: "TvShow",
                newName: "IsSubscribe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSubscribe",
                table: "TvShow",
                newName: "İsSubscribe");
        }
    }
}
