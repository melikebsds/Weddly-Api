using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeddingPlanner.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskStatusAndNewCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "WeddingTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            // Mevcut IsCompleted verisini kaybetmeden Status'a taşı: true -> Bought (1), false -> ToBuy (0).
            migrationBuilder.Sql(
                """UPDATE "WeddingTasks" SET "Status" = CASE WHEN "IsCompleted" THEN 1 ELSE 0 END""");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "WeddingTasks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "WeddingTasks");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "WeddingTasks",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
