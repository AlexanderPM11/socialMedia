using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMedia.Infrastructure.Persistence.Migrations
{
    public partial class AddedcolumnImageUrltableComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Comment");
        }
    }
}
