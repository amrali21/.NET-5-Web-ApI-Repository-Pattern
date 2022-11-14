using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27d9e6c6-cb68-43c5-86c8-49453a921ed0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29951b12-6e00-4c51-b54a-dcdd128dce0c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6db1897a-8f97-4f8b-8e22-f0afe2b8616d", "5fef8e33-358d-4894-8599-b321a2e61b3b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8372868a-7787-44be-a4ee-ba7cc50fee7c", "7e76408f-8ade-46b8-8cd3-fa5cddf7b682", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6db1897a-8f97-4f8b-8e22-f0afe2b8616d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8372868a-7787-44be-a4ee-ba7cc50fee7c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27d9e6c6-cb68-43c5-86c8-49453a921ed0", "a118c19c-f8d1-4cc8-b328-2fd26a5ed74e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29951b12-6e00-4c51-b54a-dcdd128dce0c", "fd17fd1c-6fa5-4f2b-aa71-7edd567ac8e8", "Administrator", "ADMINISTRATOR" });
        }
    }
}
