using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WP.Data.Migrations
{
    public partial class f1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Faculty = table.Column<string>(nullable: true),
                    FacultyNumber = table.Column<int>(nullable: false),
                    Lnch = table.Column<string>(nullable: true),
                    Egn = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Course = table.Column<string>(nullable: true),
                    TextField = table.Column<string>(nullable: true),
                    StartYear = table.Column<DateTime>(nullable: false),
                    LastYear = table.Column<DateTime>(nullable: false),
                    Term = table.Column<string>(nullable: true),
                    StudyForm = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    StudentType = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forms_UserId",
                table: "Forms",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");
        }
    }
}
