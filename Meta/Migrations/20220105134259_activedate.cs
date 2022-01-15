using Microsoft.EntityFrameworkCore.Migrations;

namespace Meta.Migrations
{
    public partial class activedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveDate",
                table: "Paket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActiveDate",
                table: "Paket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
