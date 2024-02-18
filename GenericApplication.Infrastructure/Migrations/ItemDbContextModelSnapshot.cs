﻿// <auto-generated />
using GenericApplication.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GenericApplication.Infrastructure.Migrations
{
    [DbContext(typeof(ItemDbContext))]
    partial class ItemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GenericApplication.Domain.Item.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("GenericApplication.Domain.Item.Item", b =>
                {
                    b.OwnsOne("GenericApplication.Domain.ItemAggregate.ItemProperty", "Property", b1 =>
                        {
                            b1.Property<int>("ItemId")
                                .HasColumnType("integer");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("ItemId");

                            b1.ToTable("Items");

                            b1.ToJson("Property");

                            b1.WithOwner()
                                .HasForeignKey("ItemId");

                            b1.OwnsMany("GenericApplication.Domain.ItemAggregate.ItemSubProperty", "Properties", b2 =>
                                {
                                    b2.Property<int>("ItemPropertyItemId")
                                        .HasColumnType("integer");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    b2.Property<decimal>("Price")
                                        .HasColumnType("numeric");

                                    b2.Property<string>("ShippingAddress")
                                        .IsRequired()
                                        .HasColumnType("text");

                                    b2.HasKey("ItemPropertyItemId", "Id");

                                    b2.ToTable("Items");

                                    b2.WithOwner()
                                        .HasForeignKey("ItemPropertyItemId");
                                });

                            b1.Navigation("Properties");
                        });

                    b.Navigation("Property");
                });
#pragma warning restore 612, 618
        }
    }
}
