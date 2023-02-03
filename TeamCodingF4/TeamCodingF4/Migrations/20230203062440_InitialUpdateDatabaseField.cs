using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamCodingF4.Migrations
{
    public partial class InitialUpdateDatabaseField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Account", "BirthDate", "Email", "Gender", "Identity", "Job", "Name", "Password", "PasswordHash", "Phone", "PicturePath", "Rate", "Role" },
                values: new object[,]
                {
                    { 1, "Admin001", new DateTime(1990, 3, 1, 7, 0, 1, 0, DateTimeKind.Unspecified), "admin001@gmail.com", 1, "A123456789", "工程師", "ken", "1111", "1111", "0900000001", "111", 5, "Admin" },
                    { 2, "User002", new DateTime(1991, 3, 1, 7, 0, 2, 0, DateTimeKind.Unspecified), "user002@gmail.com", 1, "A123456780", "老師", "jack", "2222", "2222", "0900000002", "222", 4, "User" },
                    { 3, "User003", new DateTime(1992, 3, 1, 7, 0, 3, 0, DateTimeKind.Unspecified), "user003@gmail.com", 1, "A123456781", "歌手", "mark", "3333", "3333", "0900000003", "333", 3, "User" },
                    { 4, "User004", new DateTime(1993, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified), "user004@gmail.com", 2, "A123456782", "銀行員", "rose", "4444", "4444", "0900000004", "444", 2, "User" },
                    { 5, "User005", new DateTime(1994, 3, 1, 7, 0, 5, 0, DateTimeKind.Unspecified), "user005@gmail.com", 2, "A123456783", "行政人員", "vivian", "5555", "5555", "0900000005", "555", 1, "User" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Category", "Content", "Date", "PublisherId", "Title", "ViewCount" },
                values: new object[,]
                {
                    { 1, "心得分享", "心得分享!", new DateTime(2008, 3, 1, 7, 0, 1, 0, DateTimeKind.Unspecified), 1, "範例", 0 },
                    { 2, "發文解惑", "發文解惑~", new DateTime(2008, 3, 1, 7, 0, 2, 0, DateTimeKind.Unspecified), 2, "範例", 0 },
                    { 3, "閒聊專區", "閒聊專區~", new DateTime(2008, 3, 1, 7, 0, 3, 0, DateTimeKind.Unspecified), 3, "範例", 0 },
                    { 4, "抱怨專區", "抱怨專區~", new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified), 4, "範例", 0 },
                    { 5, "找尋室友", "找尋室友~", new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified), 5, "範例", 0 }
                });

            migrationBuilder.InsertData(
                table: "ArticlesReply",
                columns: new[] { "Id", "ArticleId", "Content", "Date", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1, "終於快寫好心得分享了~", new DateTime(2008, 3, 1, 7, 0, 1, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, "終於快寫好發文解惑了~", new DateTime(2008, 3, 1, 7, 0, 2, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, "終於快寫好閒聊專區了~", new DateTime(2008, 3, 1, 7, 0, 3, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 4, "終於快寫好抱怨專區了~", new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 5, "終於快寫好找尋室友了~", new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified), 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticlesReply",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ArticlesReply",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ArticlesReply",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ArticlesReply",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ArticlesReply",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
