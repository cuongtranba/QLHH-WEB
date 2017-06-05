using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using QLHH.DAL;

namespace QLHH.Migrations
{
    [DbContext(typeof(HongLienContext))]
    partial class HongLienContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("DataSourceUrl")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsRequired");

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

                    b.Property<bool>("IsDeleted");

                    b.HasKey("AttributeTypeId");

                    b.ToTable("AttributeTypes");
                });

            modelBuilder.Entity("QLHH.DAL.Model.Entity", b =>
                {
                    b.Property<int>("EntityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EntityName")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted");

                    b.HasKey("EntityId");

                    b.ToTable("Entitys");
                });

            modelBuilder.Entity("QLHH.DAL.Model.EntityAttribute", b =>
                {
                    b.Property<int>("EntityAttributeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttributeId");

                    b.Property<int>("Column");

                    b.Property<string>("EntityAttributeValue")
                        .IsRequired();

                    b.Property<int>("EntityId");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Row");

                    b.HasKey("EntityAttributeId");

                    b.HasIndex("AttributeId");

                    b.HasIndex("EntityId");

                    b.ToTable("EntityAttributes");
                });

            modelBuilder.Entity("QLHH.DAL.Model.Attribute", b =>
                {
                    b.HasOne("QLHH.DAL.Model.AttributeType", "AttributeType")
                        .WithMany()
                        .HasForeignKey("AttributeTypeId")
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
        }
    }
}
