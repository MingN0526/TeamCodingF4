using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class addRegisterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AriticalDate",
                table: "Articals",
                newName: "ArticalDate");

            migrationBuilder.CreateTable(
                name: "EstateModel",
                columns: table => new
                {
                    EstateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateTittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EststePrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miscellaneous = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Car = table.Column<int>(type: "int", nullable: false),
                    Motorcycle = table.Column<int>(type: "int", nullable: false),
                    AirConditioner = table.Column<bool>(type: "bit", nullable: false),
                    Television = table.Column<bool>(type: "bit", nullable: false),
                    WetDry = table.Column<bool>(type: "bit", nullable: false),
                    Balcony = table.Column<bool>(type: "bit", nullable: false),
                    WashingMachine = table.Column<bool>(type: "bit", nullable: false),
                    WaterDispenser = table.Column<bool>(type: "bit", nullable: false),
                    Refrigerator = table.Column<bool>(type: "bit", nullable: false),
                    Lease = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstatePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstateVideo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateModel", x => x.EstateId);
                });

            migrationBuilder.InsertData(
                table: "Articals",
                columns: new[] { "ArticalId", "ArticalDate", "ArticleCategory", "ArticleContent", "ArticlePublisher", "ArticleTitle" },
                values: new object[] { 1, "2022/01/10", "心得分享", "加油!", "Jacky", "範例" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstateModel");

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
