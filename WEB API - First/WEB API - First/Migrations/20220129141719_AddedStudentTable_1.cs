using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_API___First.Migrations
{
    public partial class AddedStudentTable_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Isdeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Isdeleted", "Name", "Surname", "UpdateAt", "UpdateBy" },
                values: new object[] { 1, new DateTime(2022, 1, 29, 18, 17, 18, 961, DateTimeKind.Utc).AddTicks(6401), "System", null, null, false, "Huseyn", "Mammadov", null, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Isdeleted", "Name", "Surname", "UpdateAt", "UpdateBy" },
                values: new object[] { 2, new DateTime(2022, 1, 29, 18, 17, 18, 961, DateTimeKind.Utc).AddTicks(8784), "System", null, null, false, "Ali", "Aliyev", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
