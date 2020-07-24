using Microsoft.EntityFrameworkCore.Migrations;

namespace WebUI.Migrations
{
    public partial class db_Set_Classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUser_Subjects_SubjectsSubject_Id",
                table: "SubjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUser_AspNetUsers_UserId",
                table: "SubjectUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectUser",
                table: "SubjectUser");

            migrationBuilder.RenameTable(
                name: "SubjectUser",
                newName: "SubjectUsers");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUser_UserId",
                table: "SubjectUsers",
                newName: "IX_SubjectUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUser_SubjectsSubject_Id",
                table: "SubjectUsers",
                newName: "IX_SubjectUsers_SubjectsSubject_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectUsers",
                table: "SubjectUsers",
                column: "SubjectId");

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Class_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_Year = table.Column<int>(nullable: false),
                    Class_Letter = table.Column<int>(nullable: false),
                    Class_UserId = table.Column<int>(nullable: false),
                    DbUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Class_Id);
                    table.ForeignKey(
                        name: "FK_Classes_AspNetUsers_DbUserId",
                        column: x => x.DbUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClasses",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClasses", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Class_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClasses_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_DbUserId",
                table: "Classes",
                column: "DbUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClasses_ClassId",
                table: "UserClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClasses_UserId1",
                table: "UserClasses",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUsers_Subjects_SubjectsSubject_Id",
                table: "SubjectUsers",
                column: "SubjectsSubject_Id",
                principalTable: "Subjects",
                principalColumn: "Subject_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUsers_AspNetUsers_UserId",
                table: "SubjectUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUsers_Subjects_SubjectsSubject_Id",
                table: "SubjectUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectUsers_AspNetUsers_UserId",
                table: "SubjectUsers");

            migrationBuilder.DropTable(
                name: "UserClasses");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectUsers",
                table: "SubjectUsers");

            migrationBuilder.RenameTable(
                name: "SubjectUsers",
                newName: "SubjectUser");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUsers_UserId",
                table: "SubjectUser",
                newName: "IX_SubjectUser_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectUsers_SubjectsSubject_Id",
                table: "SubjectUser",
                newName: "IX_SubjectUser_SubjectsSubject_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectUser",
                table: "SubjectUser",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUser_Subjects_SubjectsSubject_Id",
                table: "SubjectUser",
                column: "SubjectsSubject_Id",
                principalTable: "Subjects",
                principalColumn: "Subject_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectUser_AspNetUsers_UserId",
                table: "SubjectUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
