using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class ChangeSocialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialLinks_Teachers_TeacherId",
                table: "SocialLinks");

            migrationBuilder.DropIndex(
                name: "IX_SocialLinks_TeacherId",
                table: "SocialLinks");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "SocialLinks");

            migrationBuilder.AddColumn<int>(
                name: "SocialId",
                table: "Teachers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SocialId",
                table: "Teachers",
                column: "SocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_SocialLinks_SocialId",
                table: "Teachers",
                column: "SocialId",
                principalTable: "SocialLinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_SocialLinks_SocialId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SocialId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SocialId",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "SocialLinks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SocialLinks_TeacherId",
                table: "SocialLinks",
                column: "TeacherId",
                unique: true,
                filter: "[TeacherId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialLinks_Teachers_TeacherId",
                table: "SocialLinks",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
