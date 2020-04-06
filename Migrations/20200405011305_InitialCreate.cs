using Microsoft.EntityFrameworkCore.Migrations;

namespace restfull_net.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductCode = table.Column<string>(maxLength: 20, nullable: false),
                    ProductType = table.Column<string>(maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 150, nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    QtyStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
