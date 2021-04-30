using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CattyWebApp.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Cats");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Cats",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cats",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Cats");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cats");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Cats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
