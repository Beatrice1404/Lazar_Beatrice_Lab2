using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lazar_Beatrice_Lab2.Migrations
{
    public partial class Author : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Author",
                newName: "AuthorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Author",
                newName: "ID");
        }
    }
}
