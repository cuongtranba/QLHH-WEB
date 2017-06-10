using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLHH.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttributeTypes",
                columns: table => new
                {
                    AttributeTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeDefaultValue = table.Column<string>(maxLength: 50, nullable: true),
                    AttributeTypeName = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeTypes", x => x.AttributeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Detail = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBrands",
                columns: table => new
                {
                    CompanyBrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    CompanyBrandName = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Fax = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBrands", x => x.CompanyBrandId);
                });

            migrationBuilder.CreateTable(
                name: "EntityTypeAttributes",
                columns: table => new
                {
                    EntityTypeAttributeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTypeAttributes", x => x.EntityTypeAttributeId);
                });

            migrationBuilder.CreateTable(
                name: "Taxs",
                columns: table => new
                {
                    TaxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TaxName = table.Column<string>(maxLength: 50, nullable: true),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxs", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDetails",
                columns: table => new
                {
                    CategoryDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryDetailName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDetails", x => x.CategoryDetailId);
                    table.ForeignKey(
                        name: "FK_CategoryDetails_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    AttributeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeName = table.Column<string>(maxLength: 50, nullable: true),
                    AttributeTypeId = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DataSourceUrl = table.Column<string>(maxLength: 50, nullable: true),
                    EntityTypeAttributeId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsRequired = table.Column<bool>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.AttributeId);
                    table.ForeignKey(
                        name: "FK_Attributes_AttributeTypes_AttributeTypeId",
                        column: x => x.AttributeTypeId,
                        principalTable: "AttributeTypes",
                        principalColumn: "AttributeTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attributes_EntityTypeAttributes_EntityTypeAttributeId",
                        column: x => x.EntityTypeAttributeId,
                        principalTable: "EntityTypeAttributes",
                        principalColumn: "EntityTypeAttributeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntityTypes",
                columns: table => new
                {
                    EntityTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EntityTypeAttributeId = table.Column<int>(nullable: true),
                    EntityTypeName = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTypes", x => x.EntityTypeId);
                    table.ForeignKey(
                        name: "FK_EntityTypes_EntityTypeAttributes_EntityTypeAttributeId",
                        column: x => x.EntityTypeAttributeId,
                        principalTable: "EntityTypeAttributes",
                        principalColumn: "EntityTypeAttributeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entitys",
                columns: table => new
                {
                    EntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EntityTypeId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Entitys_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "EntityTypes",
                        principalColumn: "EntityTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityAttributes",
                columns: table => new
                {
                    EntityAttributeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeId = table.Column<int>(nullable: false),
                    Column = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EntityAttributeValue = table.Column<string>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Row = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityAttributes", x => x.EntityAttributeId);
                    table.ForeignKey(
                        name: "FK_EntityAttributes_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityAttributes_Entitys_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entitys",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_AttributeTypeId",
                table: "Attributes",
                column: "AttributeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_EntityTypeAttributeId",
                table: "Attributes",
                column: "EntityTypeAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDetails_CategoryId",
                table: "CategoryDetails",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_EntityTypeId",
                table: "Entitys",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAttributes_AttributeId",
                table: "EntityAttributes",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAttributes_EntityId",
                table: "EntityAttributes",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_EntityTypeAttributeId",
                table: "EntityTypes",
                column: "EntityTypeAttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDetails");

            migrationBuilder.DropTable(
                name: "CompanyBrands");

            migrationBuilder.DropTable(
                name: "EntityAttributes");

            migrationBuilder.DropTable(
                name: "Taxs");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Entitys");

            migrationBuilder.DropTable(
                name: "AttributeTypes");

            migrationBuilder.DropTable(
                name: "EntityTypes");

            migrationBuilder.DropTable(
                name: "EntityTypeAttributes");
        }
    }
}
