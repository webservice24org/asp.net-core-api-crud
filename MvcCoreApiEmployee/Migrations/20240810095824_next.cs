using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCoreApiEmployee.Migrations
{
    /// <inheritdoc />
    public partial class next : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Employee",
                table: "Experience");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Employee",
                table: "Experience",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Employee",
                table: "Experience");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Employee",
                table: "Experience",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId");
        }
    }
}
