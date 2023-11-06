using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceedConsultancy.Migrations
{
    public partial class CreatAllTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("39dae577-0a01-41c5-91cb-ba12f4ab3b87") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("39dae577-0a01-41c5-91cb-ba12f4ab3b87"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("f29e13cb-8b7e-4fbb-aed4-4146e766cb40"), "4699cc3e-3efa-4267-bad7-d13b4a754c00", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("f29e13cb-8b7e-4fbb-aed4-4146e766cb40"), "CanEdit", "CanEdit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("f29e13cb-8b7e-4fbb-aed4-4146e766cb40") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f29e13cb-8b7e-4fbb-aed4-4146e766cb40"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("39dae577-0a01-41c5-91cb-ba12f4ab3b87"), "75c24071-1402-4874-8b63-a7bf7ae80f30", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("39dae577-0a01-41c5-91cb-ba12f4ab3b87"), "CanEdit", "CanEdit" });
        }
    }
}
