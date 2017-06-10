using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using QLHH.DAL;

namespace QLHH.Migrations
{
    [DbContext(typeof(HongLienContext))]
    [Migration("20170610140414_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QLHH.DAL.Model.Attribute", b =>
                {
                    b.Property<int>("AttributeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AttributeName")
                        .HasMaxLength(50);

                    b.Property<int>("AttributeTypeId");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DataSourceUrl")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsRequired");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("AttributeId");

                    b.HasIndex("AttributeTypeId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("QLHH.DAL.Model.AttributeType", b =>
                {
                    b.Property<int>("AttributeTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AttributeDefaultValue")
                        .HasMaxLength(50);

                    b.Property<string>("AttributeTypeName")
                        .HasMaxLength(50);

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("AttributeTypeId");

                    b.ToTable("AttributeTypes");
                });

            modelBuilder.Entity("QLHH.DAL.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50);

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Detail");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("QLHH.DAL.Model.CategoryDetail", b =>
                {
                    b.Property<int>("CategoryDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryDetailName");

                    b.Property<int>("CategoryId");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("CategoryDetailId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryDetails");
                });

            modelBuilder.Entity("QLHH.DAL.Model.CompanyBrand", b =>
                {
                    b.Property<int>("CompanyBrandId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(50);

                    b.Property<string>("CompanyBrandName")
                        .HasMaxLength(50);

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Fax")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("CompanyBrandId");

                    b.ToTable("CompanyBrands");
                });

            modelBuilder.Entity("QLHH.DAL.Model.Entity", b =>
                {
                    b.Property<int>("EntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EntityTypeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("EntityId");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Entitys");
                });

            modelBuilder.Entity("QLHH.DAL.Model.EntityAttribute", b =>
                {
                    b.Property<int>("EntityAttributeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeId");

                    b.Property<int>("Column");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("EntityAttributeValue")
                        .IsRequired();

                    b.Property<int>("EntityId");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Row");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("EntityAttributeId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityAttributes");
                });

            modelBuilder.Entity("QLHH.DAL.Model.EntityType", b =>
                {
                    b.Property<int>("EntityTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("EntityTypeName")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("EntityTypeId");

                    b.ToTable("EntityTypes");
                });

            modelBuilder.Entity("QLHH.DAL.Model.EntityTypeAttribute", b =>
                {
                    b.Property<int>("EntityTypeAttributeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeId");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EntityTypeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("EntityTypeAttributeId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("EntityTypeAttributes");
                });

            modelBuilder.Entity("QLHH.DAL.Model.Tax", b =>
                {
                    b.Property<int>("TaxId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("TaxName")
                        .HasMaxLength(50);

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("TaxId");

                    b.ToTable("Taxs");
                });

            modelBuilder.Entity("QLHH.DAL.Model.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("UpdatedByUserId");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("QLHH.DAL.Model.Attribute", b =>
                {
                    b.HasOne("QLHH.DAL.Model.AttributeType", "AttributeType")
                        .WithMany()
                        .HasForeignKey("AttributeTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QLHH.DAL.Model.CategoryDetail", b =>
                {
                    b.HasOne("QLHH.DAL.Model.Category", "Category")
                        .WithMany("CategoryDetails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QLHH.DAL.Model.Entity", b =>
                {
                    b.HasOne("QLHH.DAL.Model.EntityType", "EntityType")
                        .WithMany("Entities")
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QLHH.DAL.Model.EntityAttribute", b =>
                {
                    b.HasOne("QLHH.DAL.Model.Attribute", "Attribute")
                        .WithMany("EntityAttributes")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QLHH.DAL.Model.Entity", "Entity")
                        .WithMany("EntityAttributes")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QLHH.DAL.Model.EntityTypeAttribute", b =>
                {
                    b.HasOne("QLHH.DAL.Model.Attribute", "Attribute")
                        .WithMany("EntityTypeAttributes")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QLHH.DAL.Model.EntityType", "EntityType")
                        .WithMany("EntityTypeAttributes")
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
