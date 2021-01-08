using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class ChangeEngineer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfLicenseRenewal",
                table: "Engineers",
                newName: "EngineerDateOfLicenseRenewal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EngineerDateOfLicenseRenewal",
                table: "Engineers",
                newName: "DateOfLicenseRenewal");
        }
    }
}
