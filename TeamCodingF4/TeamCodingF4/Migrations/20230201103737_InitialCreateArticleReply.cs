using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InitialCreateArticleReply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticlesReply",
                columns: table => new
                {
                    ArticleReplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    ReplyPublisher = table.Column<string>(type: "nvarchar(66)", maxLength: 66, nullable: false),
                    ReplyDate = table.Column<string>(type: "varchar(66)", maxLength: 66, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesReply", x => x.ArticleReplyId);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleCategory", "ArticleContent", "ArticleDate", "ArticlePublisher", "ArticleTitle" },
                values: new object[,]
                {
                    { 2, "發文解惑", "發文解惑~", "2022/01/10", "Jacky", "範例" },
                    { 3, "閒聊專區", "閒聊專區~", "2022/01/10", "Jacky", "範例" },
                    { 4, "抱怨專區", "抱怨專區~", "2022/01/10", "Jacky", "範例" },
                    { 5, "找尋室友", "找尋室友~", "2022/01/10", "Jacky", "範例" }
                });

            migrationBuilder.InsertData(
                table: "ArticlesReply",
                columns: new[] { "ArticleReplyId", "ReplyContent", "ReplyDate", "ReplyPublisher" },
                values: new object[,]
                {
                    { 1, "終於快寫好心得分享了~", "2022/01/10", "Sam" },
                    { 2, "終於快寫好發文解惑了~", "2022/01/10", "Sam" },
                    { 3, "終於快寫好閒聊專區了~", "2022/01/10", "Sam" },
                    { 4, "終於快寫好抱怨專區了~", "2022/01/10", "Sam" },
                    { 5, "終於快寫好找尋室友了~", "2022/01/10", "Sam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesReply");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5);
        }
    }
}
