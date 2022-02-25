using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationPractice.Migrations
{
    public partial class correctedBugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Subject");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubjectId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubjectId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubjectId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SubjectId",
                table: "Teacher",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Subject_SubjectId",
                table: "Teacher",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Subject_SubjectId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_SubjectId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Teacher");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeacherId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeacherId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeacherId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
