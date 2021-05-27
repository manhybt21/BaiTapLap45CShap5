using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiTap.Data.Migrations
{
    public partial class manhDbv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    IdClass = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.IdClass);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStudent = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Mark = table.Column<double>(type: "float", nullable: false),
                    EmailStudent = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IdClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IdStudent);
                    table.ForeignKey(
                        name: "FK_Student_Class_IdClass",
                        column: x => x.IdClass,
                        principalTable: "Class",
                        principalColumn: "IdClass",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "IdClass", "ClassName" },
                values: new object[] { 1, "IT" });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "IdClass", "ClassName" },
                values: new object[] { 2, "Du Lịch" });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "IdClass", "ClassName" },
                values: new object[] { 3, "Thiết Kế Đồ Hoạ" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "IdStudent", "EmailStudent", "IdClass", "Mark", "NameStudent" },
                values: new object[] { 1, "manhldph10164@fpt.edu.vn", 1, 8.0, "Mạnh" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "IdStudent", "EmailStudent", "IdClass", "Mark", "NameStudent" },
                values: new object[] { 2, "luongtuan@gmail.com", 1, 9.0, "Tuấn" });

            migrationBuilder.CreateIndex(
                name: "IX_Student_IdClass",
                table: "Student",
                column: "IdClass");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Class");
        }
    }
}
