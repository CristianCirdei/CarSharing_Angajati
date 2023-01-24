using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSharing_Angajati.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    EmpBirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EmpIDNP = table.Column<int>(type: "Nvarchar(50)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    EmpEmail = table.Column<string>(type: "Nvarchar(50)", nullable: true),
                    EmpAdress = table.Column<string>(type: "Nvarchar(150)", nullable: false),
                    EmpPhoneNumber = table.Column<string>(type: "Nvarchar(18)", nullable: false),
                    EmpDriverLicense = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    EmpPosition = table.Column<string>(type: "Nvarchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
