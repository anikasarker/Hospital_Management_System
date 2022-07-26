using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalManagementSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Disease = table.Column<string>(nullable: true),
                    Symptoms = table.Column<string>(nullable: true),
                    Medicine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true),
                    Year_Of_Experience = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientInformation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Blood_Group = table.Column<string>(nullable: true),
                    Disease = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInformation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "PatientInformation");
        }
    }
}
