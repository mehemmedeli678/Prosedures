using Microsoft.EntityFrameworkCore.Migrations;

namespace Meta.Migrations
{
    public partial class subs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriperToPaket_Subscriber_SubscriberId",
                table: "SubscriperToPaket",
                column: "SubscriberId",
                principalTable: "Subscriber",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubscriperToPaket_Subscriber_SubscriberId",
                table: "SubscriperToPaket");

            migrationBuilder.RenameColumn(
                name: "SubscriberId",
                table: "SubscriperToPaket",
                newName: "SubscriberID");

            migrationBuilder.RenameIndex(
                name: "IX_SubscriperToPaket_SubscriberId",
                table: "SubscriperToPaket",
                newName: "IX_SubscriperToPaket_SubscriberID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriperToPaket_Subscriber_SubscriberID",
                table: "SubscriperToPaket",
                column: "SubscriberID",
                principalTable: "Subscriber",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
