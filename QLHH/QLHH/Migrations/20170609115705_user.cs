using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHH.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Warehouses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Warehouses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Taxs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Taxs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "EntityAttributes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "EntityAttributes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Entitys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Entitys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "CompanyBrands",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "CompanyBrands",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "CategoryDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "CategoryDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "AttributeTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "AttributeTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Attributes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedByUserId",
                table: "Attributes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Taxs");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Taxs");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "EntityAttributes");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "EntityAttributes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Entitys");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Entitys");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "CompanyBrands");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "CompanyBrands");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "CategoryDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "CategoryDetails");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "AttributeTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "AttributeTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "Attributes");
        }
    }
}
