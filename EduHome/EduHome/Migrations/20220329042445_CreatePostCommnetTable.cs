using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreatePostCommnetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentEntities_Posts_PostId",
                table: "CommentEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentEntities_AspNetUsers_UserId",
                table: "CommentEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentEntities",
                table: "CommentEntities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CommentEntities");

            migrationBuilder.RenameTable(
                name: "CommentEntities",
                newName: "BlogComments");

            migrationBuilder.RenameIndex(
                name: "IX_CommentEntities_UserId",
                table: "BlogComments",
                newName: "IX_BlogComments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentEntities_PostId",
                table: "BlogComments",
                newName: "IX_BlogComments_PostId");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "BlogComments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogComments",
                table: "BlogComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_Posts_PostId",
                table: "BlogComments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_AspNetUsers_UserId",
                table: "BlogComments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_Posts_PostId",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_AspNetUsers_UserId",
                table: "BlogComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogComments",
                table: "BlogComments");

            migrationBuilder.RenameTable(
                name: "BlogComments",
                newName: "CommentEntities");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_UserId",
                table: "CommentEntities",
                newName: "IX_CommentEntities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_PostId",
                table: "CommentEntities",
                newName: "IX_CommentEntities_PostId");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "CommentEntities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CommentEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentEntities",
                table: "CommentEntities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentEntities_Posts_PostId",
                table: "CommentEntities",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentEntities_AspNetUsers_UserId",
                table: "CommentEntities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
