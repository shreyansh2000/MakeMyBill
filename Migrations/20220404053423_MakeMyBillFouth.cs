using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeMyBill.Migrations
{
    public partial class MakeMyBillFouth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cartMasters",
                columns: table => new
                {
                    Cartid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customerid = table.Column<int>(type: "int", nullable: false),
                    Scid = table.Column<int>(type: "int", nullable: false),
                    ScQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartMasters", x => x.Cartid);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceDetailNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<int>(type: "int", nullable: false),
                    Productid = table.Column<int>(type: "int", nullable: false),
                    ProductQty = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.InvoiceDetailNo);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceMaster",
                columns: table => new
                {
                    InvoiceNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<string>(type: "varchar(25)", nullable: false),
                    Branchid = table.Column<int>(type: "int", nullable: false),
                    Customerid = table.Column<int>(type: "int", nullable: false),
                    FinalTotal = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceMaster", x => x.InvoiceNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartMasters");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "InvoiceMaster");
        }
    }
}
