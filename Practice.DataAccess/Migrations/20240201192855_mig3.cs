using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice.DataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Group",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Lib",
                table: "S_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Press",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Theme",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lib",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lib", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Press",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Press", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Department = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Department_Id_Department",
                        column: x => x.Id_Department,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Faculty = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Faculty_Id_Faculty",
                        column: x => x.Id_Faculty,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Teacher = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Lib = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Card_Books_Id_Book",
                        column: x => x.Id_Book,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Card_Lib_Id_Lib",
                        column: x => x.Id_Lib,
                        principalTable: "Lib",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Card_Teacher_Id_Teacher",
                        column: x => x.Id_Teacher,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Id_Group",
                table: "Students",
                column: "Id_Group");

            migrationBuilder.CreateIndex(
                name: "IX_S_Cards_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Press",
                table: "Books",
                column: "Id_Press");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Id_Theme",
                table: "Books",
                column: "Id_Theme");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Id_Faculty",
                table: "Group",
                column: "Id_Faculty");

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Id_Book",
                table: "T_Card",
                column: "Id_Book");

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Id_Lib",
                table: "T_Card",
                column: "Id_Lib");

            migrationBuilder.CreateIndex(
                name: "IX_T_Card_Id_Teacher",
                table: "T_Card",
                column: "Id_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Id_Department",
                table: "Teacher",
                column: "Id_Department");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Press_Id_Press",
                table: "Books",
                column: "Id_Press",
                principalTable: "Press",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Theme_Id_Theme",
                table: "Books",
                column: "Id_Theme",
                principalTable: "Theme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_S_Cards_Lib_Id_Lib",
                table: "S_Cards",
                column: "Id_Lib",
                principalTable: "Lib",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Group_Id_Group",
                table: "Students",
                column: "Id_Group",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Press_Id_Press",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Theme_Id_Theme",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Cards_Lib_Id_Lib",
                table: "S_Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_Id_Group",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Press");

            migrationBuilder.DropTable(
                name: "T_Card");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Lib");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Students_Id_Group",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_S_Cards_Id_Lib",
                table: "S_Cards");

            migrationBuilder.DropIndex(
                name: "IX_Books_Id_Press",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Id_Theme",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Id_Group",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Id_Lib",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "Id_Press",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Id_Theme",
                table: "Books");
        }
    }
}
