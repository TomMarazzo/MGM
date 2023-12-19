using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MGM.Migrations
{
    /// <inheritdoc />
    public partial class GrowMediaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_costQties_GrowMedias_GrowMediaId",
                table: "costQties");

            migrationBuilder.DropIndex(
                name: "IX_costQties_GrowMediaId",
                table: "costQties");

            migrationBuilder.DropColumn(
                name: "GrowMediaId",
                table: "costQties");

            migrationBuilder.AddColumn<float>(
                name: "CurrentTotal",
                table: "GrowMedias",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "NoOfBags",
                table: "GrowMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "GrowMedias",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<float>(
                name: "Qty",
                table: "GrowMedias",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "RemainingTotal",
                table: "GrowMedias",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Subtotal",
                table: "GrowMedias",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Volume",
                table: "GrowMedias",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentTotal",
                table: "GrowMedias");

            migrationBuilder.DropColumn(
                name: "NoOfBags",
                table: "GrowMedias");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "GrowMedias");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "GrowMedias");

            migrationBuilder.DropColumn(
                name: "RemainingTotal",
                table: "GrowMedias");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "GrowMedias");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "GrowMedias");

            migrationBuilder.AddColumn<Guid>(
                name: "GrowMediaId",
                table: "costQties",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_costQties_GrowMediaId",
                table: "costQties",
                column: "GrowMediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_costQties_GrowMedias_GrowMediaId",
                table: "costQties",
                column: "GrowMediaId",
                principalTable: "GrowMedias",
                principalColumn: "GrowMediaId");
        }
    }
}
