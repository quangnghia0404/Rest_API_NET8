using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CommentOnToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22e6bdfd-86f0-4b22-8fc9-c4c4b7cee38b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "581f54ac-a53b-4069-980f-f6dcee9b4f29");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6cf57a86-e51e-40ff-81fe-c093020997de", null, "User", "USER" },
                    { "8f191a4a-08c7-4a5d-a750-c7dee855696b", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cf57a86-e51e-40ff-81fe-c093020997de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f191a4a-08c7-4a5d-a750-c7dee855696b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22e6bdfd-86f0-4b22-8fc9-c4c4b7cee38b", null, "User", "USER" },
                    { "581f54ac-a53b-4069-980f-f6dcee9b4f29", null, "Admin", "ADMIN" }
                });
        }
    }
}
