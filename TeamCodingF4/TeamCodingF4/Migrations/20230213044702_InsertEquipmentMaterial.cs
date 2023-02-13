using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InsertEquipmentMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { 1, "冷氣", "\\Picture\\C231702674-SP-10837585.jpg" },
                    { 2, "電視", "\\Picture\\4acd260998f15b994caa60ef32d7891e-1000x675.jpg" },
                    { 3, "乾溼分離", "\\Picture\\12323323232-4.jpg" },
                    { 4, "陽台", "\\Picture\\large-glass-enclosed-balcony-picture-id1344082102.jpg" },
                    { 5, "洗衣機", "\\Picture\\TAW-R1208DB.jpg" },
                    { 6, "飲水機", "\\Picture\\m_ed93aaa626b305bdc2f1c6b2aa269905-fbQg0.jpg" },
                    { 7, "冰箱", "\\Picture\\87021356646430.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
