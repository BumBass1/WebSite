using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite11.Migrations
{
    public partial class _initial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6FF66B6D-FDEC-4825-A115-56836471C40F",
                column: "ConcurrencyStamp",
                value: "c0ee24e7-78aa-4bb9-9c0a-daecce20ec20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D25C0E94-A64A-4537-B56E-8840E806F971",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "671bd115-1bf4-4441-9280-81714477fbef", "AQAAAAEAACcQAAAAEBEcf+nnl4zB85uZ3LlhsGRQJx22Z3pOY8FGgCqF0sSy/1DwYTOyQiXcYIMxpI9mYQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("329043fd-7bf9-4bfe-9040-59b4f8c600bf"),
                column: "DateAdded",
                value: new DateTime(2022, 7, 5, 10, 41, 57, 426, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d64793a6-40ba-4d23-a1c3-2ea4761b8fe3"),
                column: "DateAdded",
                value: new DateTime(2022, 7, 5, 10, 41, 57, 425, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("e5001545-08c4-40a8-99b0-2f906f4420e4"),
                column: "DateAdded",
                value: new DateTime(2022, 7, 5, 10, 41, 57, 426, DateTimeKind.Utc).AddTicks(783));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6FF66B6D-FDEC-4825-A115-56836471C40F",
                column: "ConcurrencyStamp",
                value: "588299b7-e873-4ecc-901a-531e96ed3291");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D25C0E94-A64A-4537-B56E-8840E806F971",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8fdaca6-b7a2-4cb6-a963-8d1a80f542e0", "AQAAAAEAACcQAAAAEP19NVobAg4pbEy1wWIW5BckyJdKnENWjjM7QvdOx5zzgf2dtu7t0jnfPb8WeOogpQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("329043fd-7bf9-4bfe-9040-59b4f8c600bf"),
                column: "DateAdded",
                value: new DateTime(2022, 7, 5, 10, 33, 46, 555, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d64793a6-40ba-4d23-a1c3-2ea4761b8fe3"),
                column: "DateAdded",
                value: new DateTime(2022, 7, 5, 10, 33, 46, 555, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("e5001545-08c4-40a8-99b0-2f906f4420e4"),
                column: "DateAdded",
                value: new DateTime(2022, 7, 5, 10, 33, 46, 555, DateTimeKind.Utc).AddTicks(5822));
        }
    }
}
