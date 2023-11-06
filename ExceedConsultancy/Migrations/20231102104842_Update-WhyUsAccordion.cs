using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceedConsultancy.Migrations
{
    public partial class UpdateWhyUsAccordion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b"));

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "WhyUsAccordion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b1989f2d-616d-4b46-91d6-598031da4b3d"), "f43b0949-7fa8-456e-b13f-37ce276d3292", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("b1989f2d-616d-4b46-91d6-598031da4b3d"), "CanEdit", "CanEdit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("b1989f2d-616d-4b46-91d6-598031da4b3d") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b1989f2d-616d-4b46-91d6-598031da4b3d"));

            migrationBuilder.DropColumn(
                name: "Order",
                table: "WhyUsAccordion");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b"), "30e6b09f-3455-483f-9c68-821596f86d2b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b"), "CanEdit", "CanEdit" });
        }
    }
}
