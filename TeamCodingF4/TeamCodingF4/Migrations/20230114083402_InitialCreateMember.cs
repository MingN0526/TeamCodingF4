using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InitialCreateMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticalModel");

            migrationBuilder.CreateTable(
                name: "MemberModel",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberPhone = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberAccount = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberPassword = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberEmail = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberIdentity = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MemberBirth = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberSex = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberRate = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberJob = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberSeparate = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    MemberLike = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberModel", x => x.MemberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberModel");

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
