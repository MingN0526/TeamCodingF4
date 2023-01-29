using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InitialCreateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticalModel");

            migrationBuilder.CreateTable(
                name: "Articals",
                columns: table => new
                {
                    ArticalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AriticalDate = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ArticlePublisher = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ArticleCategory = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articals", x => x.ArticalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articals");

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
