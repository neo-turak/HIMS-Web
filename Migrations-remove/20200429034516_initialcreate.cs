using Microsoft.EntityFrameworkCore.Migrations;

namespace HIMS_Web.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    序号 = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    产品名 = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    产品类型 = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    位置 = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    店主 = table.Column<string>(type:"nvarchar(32)",nullable:false),
                    价格 = table.Column<double>(type: "float", nullable: false)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.序号);
                    
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
