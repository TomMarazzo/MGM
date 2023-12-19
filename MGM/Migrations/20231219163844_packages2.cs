using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MGM.Migrations
{
    /// <inheritdoc />
    public partial class packages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SupplierId",
                table: "Packages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Packages_SupplierId",
                table: "Packages",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Suppliers_SupplierId",
                table: "Packages",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Suppliers_SupplierId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_SupplierId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Packages");
        }
    }
}
