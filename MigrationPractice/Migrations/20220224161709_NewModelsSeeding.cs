using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationPractice.Migrations
{
    public partial class NewModelsSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupsSubejects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupsSubejects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupsSubejects_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupsSubejects_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Math" },
                    { 2, "Physics" },
                    { 3, "Informatics" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "CardNumber", "Experience", "FullName" },
                values: new object[,]
                {
                    { 1, "6800101023233003", 20, "Abdusattor Ortiqov" },
                    { 2, "6800101023235005", 25, "Sardor Komilov" },
                    { 3, "6800101023234004", 28, "Jahongir Aripov" }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 1, "MAth group", 1 });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 2, "Physics group", 2 });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 3, "Informatics group", 3 });

            migrationBuilder.InsertData(
                table: "GroupsSubejects",
                columns: new[] { "Id", "GroupId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Age", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1, 20, "Alijon", 1, "Karimov" },
                    { 2, 25, "Javohir", 2, "Jorayev" },
                    { 3, 26, "Xurshid", 3, "Torayev" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_TeacherId",
                table: "Group",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsSubejects_GroupId",
                table: "GroupsSubejects",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupsSubejects_SubjectId",
                table: "GroupsSubejects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupId",
                table: "Student",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupsSubejects");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
