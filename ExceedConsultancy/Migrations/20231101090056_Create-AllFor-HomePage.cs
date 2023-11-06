using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceedConsultancy.Migrations
{
    public partial class CreateAllForHomePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("cd826f23-f6c6-48be-a728-71fb5db71781") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cd826f23-f6c6-48be-a728-71fb5db71781"));

            migrationBuilder.CreateTable(
                name: "AboutCompany",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mission_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vision_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhyUsHome",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhyUsHome", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("cf768e9a-871b-492a-badb-94a5bde811b2"), "44c50756-4228-4b6a-a659-b3ccb64326a0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("cf768e9a-871b-492a-badb-94a5bde811b2"), "CanEdit", "CanEdit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCompany");

            migrationBuilder.DropTable(
                name: "WhyUsHome");

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("cf768e9a-871b-492a-badb-94a5bde811b2") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cf768e9a-871b-492a-badb-94a5bde811b2"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("cd826f23-f6c6-48be-a728-71fb5db71781"), "6699316a-3d64-4d41-b330-a2d0a29de1f0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("cd826f23-f6c6-48be-a728-71fb5db71781"), "CanEdit", "CanEdit" });
        }
    }
}
