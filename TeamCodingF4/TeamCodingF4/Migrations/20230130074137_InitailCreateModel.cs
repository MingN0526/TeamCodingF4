using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InitailCreateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticalModel");

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleDate = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ArticlePublisher = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ArticleCategory = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ArticleContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    ArticleTitle = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleCategory", "ArticleContent", "ArticleDate", "ArticlePublisher", "ArticleTitle" },
                values: new object[] { 1, "心得分享", "加油!", "2022/01/10", "Jacky", "範例" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.CreateTable(
                name: "ArticalModel",
                columns: table => new
                {
                    ArticalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AriticalDate = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ArticleCategory = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ArticlePublisher = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticalModel", x => x.ArticalId);
                });
        }
    }
}
