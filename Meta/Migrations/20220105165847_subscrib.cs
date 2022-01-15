using Microsoft.EntityFrameworkCore.Migrations;

namespace Meta.Migrations
{
    public partial class subscrib : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubscriperToPaket_Subscriber_SubscriberId",
                table: "SubscriperToPaket");

            migrationBuilder.DropColumn(
                name: "SubscriperID",
                table: "SubscriperToPaket");

            migrationBuilder.RenameColumn(
                name: "SubscriberId",
                table: "SubscriperToPaket",
                newName: "SubscriberID");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriperToPaket_SubscriberId",
                table: "SubscriperToPaket",
                newName: "IX_SubscriperToPaket_SubscriberID");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriberID",
                table: "SubscriperToPaket",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriperToPaket_Subscriber_SubscriberID",
                table: "SubscriperToPaket",
                column: "SubscriberID",
                principalTable: "Subscriber",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubscriperToPaket_Subscriber_SubscriberID",
                table: "SubscriperToPaket");

            migrationBuilder.RenameColumn(
                name: "SubscriberID",
                table: "SubscriperToPaket",
                newName: "SubscriberId");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriperToPaket_SubscriberID",
                table: "SubscriperToPaket",
                newName: "IX_SubscriperToPaket_SubscriberId");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriberId",
                table: "SubscriperToPaket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SubscriperID",
                table: "SubscriperToPaket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriperToPaket_Subscriber_SubscriberId",
                table: "SubscriperToPaket",
                column: "SubscriberId",
                principalTable: "Subscriber",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
