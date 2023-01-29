using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class UpdateTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estates",
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
                    AirConditioner = table.Column<int>(type: "int", nullable: false),
                    Television = table.Column<int>(type: "int", nullable: false),
                    WetDry = table.Column<int>(type: "int", nullable: false),
                    Balcony = table.Column<int>(type: "int", nullable: false),
                    WashingMachine = table.Column<int>(type: "int", nullable: false),
                    WaterDispenser = table.Column<int>(type: "int", nullable: false),
                    Refrigerator = table.Column<int>(type: "int", nullable: false),
                    Lease = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstatePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstateVideo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.EstateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estates");
        }
    }
}
