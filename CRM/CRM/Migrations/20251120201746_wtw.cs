using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.Migrations
{
    /// <inheritdoc />
    public partial class wtw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reports_ReportId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Reports_ReportId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ReportId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "RecentCustomersJson",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecentEmployeesJson",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecentCustomersJson",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "RecentEmployeesJson",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportId",
                table: "Employees",
                column: "ReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ReportId",
                table: "Customers",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Reports_ReportId",
                table: "Customers",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Reports_ReportId",
                table: "Employees",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id");
        }
    }
}
