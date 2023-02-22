using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapi.Migrations
{
    /// <inheritdoc />
    public partial class demo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient10 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingredient1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });
        }
    }
}
