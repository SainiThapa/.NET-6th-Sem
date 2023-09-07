using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantWebOrder.Migrations
{
    /// <inheritdoc />
    public partial class SecondaryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item",
                table: "Orders",
                newName: "ItemType");

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ItemType",
                table: "Orders",
                newName: "Item");
        }
    }
}
