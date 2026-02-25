using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterestService.Repository.Migrations
{
    /// <inheritdoc />
    public partial class addcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ClosingBalance",
                table: "EmiSchedules",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OpeningBalance",
                table: "EmiSchedules",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingBalance",
                table: "EmiSchedules");

            migrationBuilder.DropColumn(
                name: "OpeningBalance",
                table: "EmiSchedules");
        }
    }
}
