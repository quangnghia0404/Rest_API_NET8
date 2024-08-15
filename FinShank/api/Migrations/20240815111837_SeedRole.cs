using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d58d8d8-c8a9-4621-9966-3f330e37e7f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75239755-0d5b-4597-ad56-27bd05974a8c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "274699d7-fe7f-4fcd-9a1f-83ab38d035e9", null, "User", "USER" },
                    { "b650f423-a21d-4eb2-92e3-b5b978291586", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "274699d7-fe7f-4fcd-9a1f-83ab38d035e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b650f423-a21d-4eb2-92e3-b5b978291586");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d58d8d8-c8a9-4621-9966-3f330e37e7f5", null, "Admin", "ADMIN" },
                    { "75239755-0d5b-4597-ad56-27bd05974a8c", null, "User", "USER" }
                });
        }
    }
}
