using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyDtls",
                columns: table => new
                {
                    BuyID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PdID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BDtlQty = table.Column<double>(type: "float", nullable: true),
                    BDtlPrice = table.Column<double>(type: "float", nullable: true),
                    BDtlMoney = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyDtl", x => new { x.BuyID, x.PdID });
                });

            migrationBuilder.CreateTable(
                name: "Buying",
                columns: table => new
                {
                    BuyId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BuyDate = table.Column<DateOnly>(type: "date", nullable: true),
                    StfID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BuyDocID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Saleman = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BuyQty = table.Column<double>(type: "float", nullable: true),
                    BuyMoney = table.Column<double>(type: "float", nullable: true),
                    BuyRemark = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buying", x => x.BuyId);
                });

            migrationBuilder.CreateTable(
                name: "CartDtls",
                columns: table => new
                {
                    CartID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PdID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CDtlQty = table.Column<double>(type: "float", nullable: true),
                    CDtlPrice = table.Column<double>(type: "float", nullable: true),
                    CDtlMoney = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDtl", x => new { x.CartID, x.PdID });
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CusID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CartMoney = table.Column<double>(type: "float", nullable: true),
                    CartQty = table.Column<double>(type: "float", nullable: true),
                    CartCF = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true, defaultValue: "N"),
                    CartPay = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true, defaultValue: "N"),
                    CartSend = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true, defaultValue: "N"),
                    CartVoid = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: true, defaultValue: "N")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CusID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CusLogin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CusPass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CusEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CusAdd = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    LastLogin = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CusID);
                });

            migrationBuilder.CreateTable(
                name: "Devs",
                columns: table => new
                {
                    BrandID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Duty",
                columns: table => new
                {
                    DutyID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DutyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duty", x => x.DutyID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    PdID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PdtID = table.Column<byte>(type: "tinyint", nullable: true),
                    BrandID = table.Column<byte>(type: "tinyint", nullable: true),
                    PdPrice = table.Column<double>(type: "float", nullable: true),
                    PdCost = table.Column<double>(type: "float", nullable: true),
                    PdStk = table.Column<double>(type: "float", nullable: true),
                    PdLastBuy = table.Column<DateOnly>(type: "date", nullable: true),
                    PdLastSale = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.PdID);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    PdtID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PdtName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.PdtID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StfID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StfName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StfPass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DutyID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    QuitDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.StfID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SupContact = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SupTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupAdd = table.Column<string>(type: "text", nullable: true),
                    SupRemark = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    StfId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkDate = table.Column<DateOnly>(type: "date", nullable: true),
                    WorkIn = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    WorkOut = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyDtls");

            migrationBuilder.DropTable(
                name: "Buying");

            migrationBuilder.DropTable(
                name: "CartDtls");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Devs");

            migrationBuilder.DropTable(
                name: "Duty");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Works");
        }
    }
}
