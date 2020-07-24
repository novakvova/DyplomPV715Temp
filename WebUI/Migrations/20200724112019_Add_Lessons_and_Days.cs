using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebUI.Migrations
{
    public partial class Add_Lessons_and_Days : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Day_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Day_Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkTypes",
                columns: table => new
                {
                    MarkType_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkType_Number = table.Column<int>(nullable: false),
                    MarkType_Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkTypes", x => x.MarkType_Id);
                });

            migrationBuilder.CreateTable(
                name: "Pupils",
                columns: table => new
                {
                    Pupil_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pupil_FirstName = table.Column<string>(nullable: true),
                    Pupil_LastName = table.Column<string>(nullable: true),
                    Pupil_Birthday = table.Column<DateTime>(nullable: false),
                    Pupil_Sex = table.Column<bool>(nullable: false),
                    Pupil_Address = table.Column<string>(nullable: true),
                    Pupil_Phone = table.Column<string>(nullable: true),
                    Pupil_ClassId = table.Column<int>(nullable: false),
                    Pupil_Email = table.Column<string>(nullable: true),
                    Pupil_Password = table.Column<string>(nullable: true),
                    Pupil_Role_Id = table.Column<int>(nullable: false),
                    DbRoleId = table.Column<int>(nullable: true),
                    Class_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pupils", x => x.Pupil_Id);
                    table.ForeignKey(
                        name: "FK_Pupils_Classes_Class_Id",
                        column: x => x.Class_Id,
                        principalTable: "Classes",
                        principalColumn: "Class_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pupils_AspNetRoles_DbRoleId",
                        column: x => x.DbRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Lesson_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(nullable: false),
                    Lesson_Day_Id = table.Column<int>(nullable: false),
                    Day_Id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Lesson_Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Days_Day_Id1",
                        column: x => x.Day_Id1,
                        principalTable: "Days",
                        principalColumn: "Day_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Subject_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    MarkTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PupilId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DbUserId = table.Column<int>(nullable: true),
                    MarkType_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.MarkTypeId);
                    table.ForeignKey(
                        name: "FK_Marks_AspNetUsers_DbUserId",
                        column: x => x.DbUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marks_MarkTypes_MarkType_Id",
                        column: x => x.MarkType_Id,
                        principalTable: "MarkTypes",
                        principalColumn: "MarkType_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marks_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "Pupil_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marks_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Subject_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_Day_Id1",
                table: "Lessons",
                column: "Day_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_SubjectId",
                table: "Lessons",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_DbUserId",
                table: "Marks",
                column: "DbUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_MarkType_Id",
                table: "Marks",
                column: "MarkType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_PupilId",
                table: "Marks",
                column: "PupilId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_SubjectId",
                table: "Marks",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Pupils_Class_Id",
                table: "Pupils",
                column: "Class_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pupils_DbRoleId",
                table: "Pupils",
                column: "DbRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "MarkTypes");

            migrationBuilder.DropTable(
                name: "Pupils");
        }
    }
}
