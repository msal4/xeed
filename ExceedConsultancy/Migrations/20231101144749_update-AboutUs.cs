using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceedConsultancy.Migrations
{
    public partial class updateAboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs1");

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("cf768e9a-871b-492a-badb-94a5bde811b2") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cf768e9a-871b-492a-badb-94a5bde811b2"));

            migrationBuilder.CreateTable(
                name: "AboutUs",
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
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b"), "30e6b09f-3455-483f-9c68-821596f86d2b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b"), "CanEdit", "CanEdit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d458a2d-4734-42c3-acb4-1b3380d3d75b"));

            migrationBuilder.CreateTable(
                name: "AboutUs1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description3_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mission_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vision_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs1", x => x.Id);
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
    }
}
