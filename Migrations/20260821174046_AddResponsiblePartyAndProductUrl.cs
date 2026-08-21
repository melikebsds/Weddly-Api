using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeddingPlanner.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddResponsiblePartyAndProductUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductUrl",
                table: "WeddingTasks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsibleParty",
                table: "WeddingTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductUrl",
                table: "WeddingTasks");

            migrationBuilder.DropColumn(
                name: "ResponsibleParty",
                table: "WeddingTasks");
        }
    }
}
