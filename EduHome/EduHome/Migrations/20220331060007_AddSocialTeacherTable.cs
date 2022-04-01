using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class AddSocialTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Teachers_TeacherId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_SocialLinks_SocialId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "SocialLinks");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SocialId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Experiance",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SocialId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ProgressPersent",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Skills");

            migrationBuilder.AlterColumn<string>(
                name: "Skype",
                table: "Teachers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Teachers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Hobbies",
                table: "Teachers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Faculty",
                table: "Teachers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Degree",
                table: "Teachers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Teachers",
                type: "ntext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Teachers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Teachers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Teachers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Teachers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Teachers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Teachers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skills",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "SkillsToTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Progress = table.Column<int>(nullable: false),
                    SkillsId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsToTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsToTeachers_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillsToTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    Link = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialToTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(maxLength: 250, nullable: true),
                    SocialId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialToTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialToTeachers_Socials_SocialId",
                        column: x => x.SocialId,
                        principalTable: "Socials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocialToTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillsToTeachers_SkillsId",
                table: "SkillsToTeachers",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsToTeachers_TeacherId",
                table: "SkillsToTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialToTeachers_SocialId",
                table: "SocialToTeachers",
                column: "SocialId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialToTeachers_TeacherId",
                table: "SocialToTeachers",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillsToTeachers");

            migrationBuilder.DropTable(
                name: "SocialToTeachers");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropColumn(
                name: "About",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Teachers");

            migrationBuilder.AlterColumn<string>(
                name: "Skype",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hobbies",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Faculty",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Degree",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Teachers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Experiance",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "Teachers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SocialId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Teachers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ProgressPersent",
                table: "Skills",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SocialLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinterestLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VimeoLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialLinks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SocialId",
                table: "Teachers",
                column: "SocialId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Teachers_TeacherId",
                table: "Skills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_SocialLinks_SocialId",
                table: "Teachers",
                column: "SocialId",
                principalTable: "SocialLinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
