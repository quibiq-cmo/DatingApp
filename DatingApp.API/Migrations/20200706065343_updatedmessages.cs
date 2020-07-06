using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class updatedmessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientDelete",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderDelete",
                table: "Messages");

            migrationBuilder.AddColumn<bool>(
                name: "RecipientDeleted",
                table: "Messages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SenderDeleted",
                table: "Messages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientDeleted",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderDeleted",
                table: "Messages");

            migrationBuilder.AddColumn<bool>(
                name: "RecipientDelete",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SenderDelete",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
