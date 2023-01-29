using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InsertArtical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AriticalDate",
                table: "Articals",
                newName: "ArticalDate");

            migrationBuilder.InsertData(
                table: "Articals",
                columns: new[] { "ArticalId", "ArticalDate", "ArticleCategory", "ArticleContent", "ArticlePublisher", "ArticleTitle" },
                values: new object[] { 1, "2022/01/10", "心得分享", "加油!", "Jacky", "範例" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articals",
                keyColumn: "ArticalId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "ArticalDate",
                table: "Articals",
                newName: "AriticalDate");
        }
    }
}
