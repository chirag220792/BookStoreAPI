using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreAPI.Migrations
{
    public partial class nameCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Books",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Books",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Books",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "id");
        }
    }
}
