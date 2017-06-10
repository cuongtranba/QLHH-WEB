using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHH.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_EntityTypeAttributes_EntityTypeAttributeId",
                table: "Attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypes_EntityTypeAttributes_EntityTypeAttributeId",
                table: "EntityTypes");

            migrationBuilder.DropIndex(
                name: "IX_EntityTypes_EntityTypeAttributeId",
                table: "EntityTypes");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_EntityTypeAttributeId",
                table: "Attributes");

            migrationBuilder.DropColumn(
                name: "EntityTypeAttributeId",
                table: "EntityTypes");

            migrationBuilder.DropColumn(
                name: "EntityTypeAttributeId",
                table: "Attributes");

            migrationBuilder.AddColumn<int>(
                name: "AttributeId",
                table: "EntityTypeAttributes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityTypeId",
                table: "EntityTypeAttributes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypeAttributes_AttributeId",
                table: "EntityTypeAttributes",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypeAttributes_EntityTypeId",
                table: "EntityTypeAttributes",
                column: "EntityTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypeAttributes_Attributes_AttributeId",
                table: "EntityTypeAttributes",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "AttributeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypeAttributes_EntityTypes_EntityTypeId",
                table: "EntityTypeAttributes",
                column: "EntityTypeId",
                principalTable: "EntityTypes",
                principalColumn: "EntityTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypeAttributes_Attributes_AttributeId",
                table: "EntityTypeAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityTypeAttributes_EntityTypes_EntityTypeId",
                table: "EntityTypeAttributes");

            migrationBuilder.DropIndex(
                name: "IX_EntityTypeAttributes_AttributeId",
                table: "EntityTypeAttributes");

            migrationBuilder.DropIndex(
                name: "IX_EntityTypeAttributes_EntityTypeId",
                table: "EntityTypeAttributes");

            migrationBuilder.DropColumn(
                name: "AttributeId",
                table: "EntityTypeAttributes");

            migrationBuilder.DropColumn(
                name: "EntityTypeId",
                table: "EntityTypeAttributes");

            migrationBuilder.AddColumn<int>(
                name: "EntityTypeAttributeId",
                table: "EntityTypes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntityTypeAttributeId",
                table: "Attributes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_EntityTypeAttributeId",
                table: "EntityTypes",
                column: "EntityTypeAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_EntityTypeAttributeId",
                table: "Attributes",
                column: "EntityTypeAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_EntityTypeAttributes_EntityTypeAttributeId",
                table: "Attributes",
                column: "EntityTypeAttributeId",
                principalTable: "EntityTypeAttributes",
                principalColumn: "EntityTypeAttributeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityTypes_EntityTypeAttributes_EntityTypeAttributeId",
                table: "EntityTypes",
                column: "EntityTypeAttributeId",
                principalTable: "EntityTypeAttributes",
                principalColumn: "EntityTypeAttributeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
