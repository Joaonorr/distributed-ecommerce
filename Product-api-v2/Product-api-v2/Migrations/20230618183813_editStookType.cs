using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product_api_v2.Migrations
{
    public partial class editStookType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasStoock",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Stoock",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stoock",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "HasStoock",
                table: "Products",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
