using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceedConsultancy.Migrations
{
    public partial class Updatefooteraddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("9775a702-e64d-49f5-9efc-c58e9677cd70") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9775a702-e64d-49f5-9efc-c58e9677cd70"));

            migrationBuilder.AddColumn<string>(
                name: "Description_Ar",
                table: "Footer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_Ar",
                table: "AddressInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("cd826f23-f6c6-48be-a728-71fb5db71781"), "6699316a-3d64-4d41-b330-a2d0a29de1f0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("cd826f23-f6c6-48be-a728-71fb5db71781"), "CanEdit", "CanEdit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("cd826f23-f6c6-48be-a728-71fb5db71781") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd826f23-f6c6-48be-a728-71fb5db71781"));

            migrationBuilder.DropColumn(
                name: "Description_Ar",
                table: "Footer");

            migrationBuilder.DropColumn(
                name: "Location_Ar",
                table: "AddressInfo");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("9775a702-e64d-49f5-9efc-c58e9677cd70"), "3eb80025-7e8d-4c0d-a525-beeaa5da3a25", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("9775a702-e64d-49f5-9efc-c58e9677cd70"), "CanEdit", "CanEdit" });
        }
    }
}
