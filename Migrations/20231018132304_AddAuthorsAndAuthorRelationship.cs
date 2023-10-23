using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lazar_Beatrice_Lab2.Migrations
{
    public partial class AddAuthorsAndAuthorRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "book");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_AuthorID",
                table: "book",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_book_Authors_AuthorID",
                table: "book",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_Authors_AuthorID",
                table: "book");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_book_AuthorID",
                table: "book");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "book");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
