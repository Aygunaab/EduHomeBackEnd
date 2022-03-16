using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreatedCourseFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Starts = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: false),
                    ClassDuration = table.Column<string>(nullable: false),
                    SkillLevel = table.Column<string>(nullable: false),
                    Language = table.Column<string>(nullable: false),
                    StudentsCount = table.Column<int>(nullable: false),
                    Assement = table.Column<string>(nullable: false),
                    CoursePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFeatures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseFeatures");
        }
    }
}
