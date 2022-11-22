using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Api.Migrations
{
    public partial class Refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6178e5fb-fb8a-4364-b11e-6336d73283dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ad8fa1e-4c10-43fc-a463-8d7a09d7cae8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9757f40c-30b0-43d0-9617-eb3c015d4b52", "c5a226b6-aa9f-492e-856d-1009dae008df", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a25b0255-e4d8-489b-a048-cac8e6744f05", "d9bcdf40-4674-4f45-b538-2e696a02ca6d", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9757f40c-30b0-43d0-9617-eb3c015d4b52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25b0255-e4d8-489b-a048-cac8e6744f05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6178e5fb-fb8a-4364-b11e-6336d73283dc", "1dd592fe-1e8d-4917-97ea-c9cf8f2496d4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ad8fa1e-4c10-43fc-a463-8d7a09d7cae8", "d0a6d9a0-318e-4e76-9035-3c0bd4e9a9b2", "User", "USER" });
        }
    }
}
