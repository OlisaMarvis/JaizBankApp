using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JaizBankPersistence.Migrations
{
    public partial class Initialise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MerchantId = table.Column<int>(type: "int", nullable: false),
                    MerchantName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STAN = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    DebitCardNo = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseCode = table.Column<int>(type: "int", nullable: false),
                    AID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RRN = table.Column<int>(type: "int", nullable: false),
                    PTAD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "AID", "Amount", "AuthorizationCode", "DateTime", "DebitCardNo", "ExpiryDate", "Location", "MerchantId", "MerchantName", "PTAD", "RRN", "ResponseCode", "STAN", "TerminalID" },
                values: new object[] { new Guid("f4c4c875-f854-44ab-8048-bf5fde41a482"), "A0000000041010", 0.01m, "000000", new DateTime(2022, 8, 30, 13, 45, 0, 0, DateTimeKind.Unspecified), "539941******3369", "11/24", "NO, 174 NTA/MBUORA RD, PORTHARCOURT", 0, "LIZPEE GLOBAL RESOURCES", "Global Accelerex", 210002450, 91, 3862, "23011845" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
