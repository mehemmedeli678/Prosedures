using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Meta.Migrations
{
    public partial class con : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "TvShow");

            migrationBuilder.DropColumn(
                name: "ContentDate",
                table: "TvShow");

            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "ContentDate",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "IMDB",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "CinemaLab");

            migrationBuilder.DropColumn(
                name: "ContentDate",
                table: "CinemaLab");

            migrationBuilder.AddColumn<decimal>(
                name: "Imdb",
                table: "TvShow",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Imdb",
                table: "Film",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Content",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ContentDate",
                table: "Content",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imdb",
                table: "TvShow");

            migrationBuilder.DropColumn(
                name: "Imdb",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Content");

            migrationBuilder.DropColumn(
                name: "ContentDate",
                table: "Content");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "TvShow",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ContentDate",
                table: "TvShow",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Film",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ContentDate",
                table: "Film",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "IMDB",
                table: "Content",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "CinemaLab",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ContentDate",
                table: "CinemaLab",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
