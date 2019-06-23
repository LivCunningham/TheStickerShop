﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using thestickershop;

namespace thestickershop.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190622221456_AddingTheStickerShop")]
    partial class AddingTheStickerShop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TheStickerShopApi.Models.StickerShopItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOrdered");

                    b.Property<string>("Description");

                    b.Property<bool>("InStock");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<string>("SKU");

                    b.HasKey("Id");

                    b.ToTable("StickerItems");
                });
#pragma warning restore 612, 618
        }
    }
}
