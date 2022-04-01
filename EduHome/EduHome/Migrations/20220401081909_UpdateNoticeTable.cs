using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class UpdateNoticeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Notices");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Notices",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Notices");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Notices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Notices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Notices",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
