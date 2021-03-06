// <auto-generated />
using System;
using Asp.net_Core_WebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.net_Core_WebApplication.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20210427185736_ShopCart")]
    partial class ShopCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.net_Core_WebApplication.Data.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("available");

                    b.Property<int>("categoryId");

                    b.Property<string>("img");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("longDesc");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesc");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Asp.net_Core_WebApplication.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("desc");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Asp.net_Core_WebApplication.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId");

                    b.Property<int?>("carid");

                    b.Property<int>("price");

                    b.HasKey("Id");

                    b.HasIndex("carid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("Asp.net_Core_WebApplication.Data.Models.Car", b =>
                {
                    b.HasOne("Asp.net_Core_WebApplication.Data.Models.Category", "Category")
                        .WithMany("cars")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Asp.net_Core_WebApplication.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("Asp.net_Core_WebApplication.Data.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carid");
                });
#pragma warning restore 612, 618
        }
    }
}
