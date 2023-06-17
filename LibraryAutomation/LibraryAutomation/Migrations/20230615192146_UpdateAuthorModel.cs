using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAutomation.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthorModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Authors",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Authors",
                newName: "UserName");
        }
    }
}
