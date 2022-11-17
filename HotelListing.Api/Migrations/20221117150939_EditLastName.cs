using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Api.Migrations
{
    public partial class EditLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42b00bc7-bfae-427d-90ae-d2fc45097e8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eed02afb-4710-4a1c-9b65-b22b6baa0942");

            migrationBuilder.RenameColumn(
                name: "LasrName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6178e5fb-fb8a-4364-b11e-6336d73283dc", "1dd592fe-1e8d-4917-97ea-c9cf8f2496d4", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ad8fa1e-4c10-43fc-a463-8d7a09d7cae8", "d0a6d9a0-318e-4e76-9035-3c0bd4e9a9b2", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6178e5fb-fb8a-4364-b11e-6336d73283dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ad8fa1e-4c10-43fc-a463-8d7a09d7cae8");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LasrName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42b00bc7-bfae-427d-90ae-d2fc45097e8f", "761c0dfd-bda2-4fc2-9795-9d9f851c180e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eed02afb-4710-4a1c-9b65-b22b6baa0942", "9c23209e-ee4a-41be-b832-08de19fd06c4", "Administrator", "ADMINISTRATOR" });
        }
    }
}
