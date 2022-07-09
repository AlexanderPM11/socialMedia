using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMedia.Infrastructure.Persistence.Migrations
{
    public partial class IaddedcolumnImageUrlinthetableFriends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Friends");
        }
    }
}
