using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumManagementService.Migrations
{
    /// <inheritdoc />
    public partial class AddActiveBoolean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ForumTopics",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "ForumTopics");
        }
    }
}
