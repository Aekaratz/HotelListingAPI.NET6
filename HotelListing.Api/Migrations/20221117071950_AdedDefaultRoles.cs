using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Api.Migrations
{
    public partial class AdedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42b00bc7-bfae-427d-90ae-d2fc45097e8f", "761c0dfd-bda2-4fc2-9795-9d9f851c180e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eed02afb-4710-4a1c-9b65-b22b6baa0942", "9c23209e-ee4a-41be-b832-08de19fd06c4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42b00bc7-bfae-427d-90ae-d2fc45097e8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eed02afb-4710-4a1c-9b65-b22b6baa0942");
        }
    }
}
