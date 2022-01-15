using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Meta.Migrations
{
    public partial class IS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayDate",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "İsSubscribe",
                table: "TvShow",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribe",
                table: "Film",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "İsSubscribe",
                table: "TvShow");

            migrationBuilder.DropColumn(
                name: "IsSubscribe",
                table: "Film");

            migrationBuilder.AddColumn<DateTime>(
                name: "PayDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
