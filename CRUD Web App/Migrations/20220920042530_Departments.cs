using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Web_App.Migrations
{
    public partial class Departments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Users",
                newName: "DepartmentID");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Users",
                newName: "DeptId");
        }
    }
}
