using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InitialUpdateArticlContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articals",
                columns: new[] { "ArticalId", "AriticalDate", "ArticleCategory", "ArticleContent", "ArticlePublisher" },
                values: new object[] { 1, "2022/01/10", "心得分享", "加油!", "Jacky" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articals",
                keyColumn: "ArticalId",
                keyValue: 1);
        }
    }
}
