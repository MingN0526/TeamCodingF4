using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InsertArticleReplyId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReplyId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReplyId",
                table: "Articles");
        }
    }
}
