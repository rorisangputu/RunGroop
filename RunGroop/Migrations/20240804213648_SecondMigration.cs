using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunGroop.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Races",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Clubs",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Clubs");
        }
    }
}
