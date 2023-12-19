using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MGM.Migrations
{
    /// <inheritdoc />
    public partial class packages1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PackageId",
                table: "Suppliers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QtyofPackages = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalQty = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<float>(type: "real", nullable: false),
                    CurrentTotal = table.Column<float>(type: "real", nullable: false),
                    RemainingTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PackageId",
                table: "Suppliers",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Packages_PackageId",
                table: "Suppliers",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "PackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Packages_PackageId",
                table: "Suppliers");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PackageId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Suppliers");
        }
    }
}
