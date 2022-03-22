using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreateFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    ClassDuration = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    SkillLevel = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    StudentsCount = table.Column<int>(nullable: false),
                    Assements = table.Column<string>(nullable: true),
                    CoursePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_Courses_Id",
                        column: x => x.Id,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
