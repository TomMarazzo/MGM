using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MGM.Migrations
{
    /// <inheritdoc />
    public partial class packages3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Packages_PackageId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PackageId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Suppliers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PackageId",
                table: "Suppliers",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
