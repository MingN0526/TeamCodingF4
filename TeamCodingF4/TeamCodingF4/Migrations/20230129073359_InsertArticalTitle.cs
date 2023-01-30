using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InsertArticalTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articals",
                keyColumn: "ArticalId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "ArticleTitle",
                table: "Articals",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleTitle",
                table: "Articals");

            migrationBuilder.InsertData(
                table: "Articals",
                columns: new[] { "ArticalId", "AriticalDate", "ArticleCategory", "ArticleContent", "ArticlePublisher" },
                values: new object[] { 1, "2022/01/10", "心得分享", "加油!", "Jacky" });
        }
    }
}
