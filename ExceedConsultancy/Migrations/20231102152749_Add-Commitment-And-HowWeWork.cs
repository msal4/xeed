using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExceedConsultancy.Migrations
{
    public partial class AddCommitmentAndHowWeWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumns: new[] { "Id", "RoleId" },
                keyValues: new object[] { 1, new Guid("69fc6ed9-54b0-45d8-a8d6-c9730ff11922") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("69fc6ed9-54b0-45d8-a8d6-c9730ff11922"));

            migrationBuilder.CreateTable(
                name: "AccordionThree",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    TitleAccordion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleAccordion_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccordionThree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccordionTwo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    TitleAccordion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleAccordion_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccordionTwo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commitment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commitment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HowWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description_Ar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HowWork", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("39dae577-0a01-41c5-91cb-ba12f4ab3b87"), "75c24071-1402-4874-8b63-a7bf7ae80f30", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("39dae577-0a01-41c5-91cb-ba12f4ab3b87"), "CanEdit", "CanEdit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccordionThree");

            migrationBuilder.DropTable(
                name: "AccordionTwo");

            migrationBuilder.DropTable(
                name: "Commitment");

            migrationBuilder.DropTable(
                name: "HowWork");

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
                values: new object[] { new Guid("69fc6ed9-54b0-45d8-a8d6-c9730ff11922"), "60cd523c-68aa-4039-af15-b2f71288914f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "RoleId", "ClaimType", "ClaimValue" },
                values: new object[] { 1, new Guid("69fc6ed9-54b0-45d8-a8d6-c9730ff11922"), "CanEdit", "CanEdit" });
        }
    }
}
