using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMedia.Infrastructure.Persistence.Migrations
{
    public partial class AddedcolumnId_UserRelationintableFriends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_UserRelation",
                table: "Friends",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_UserRelation",
                table: "Friends");
        }
    }
}
