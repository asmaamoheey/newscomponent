﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using compents.Models;

namespace compents.Migrations
{
    [DbContext(typeof(newscontext))]
    partial class newscontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("compents.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("newid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("newid");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("compents.Models.News", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("publichdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("sourseid")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("news");
                });

            modelBuilder.Entity("compents.Models.Source", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("newid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("newid")
                        .IsUnique();

                    b.ToTable("sourses");
                });

            modelBuilder.Entity("compents.Models.Category", b =>
                {
                    b.HasOne("compents.Models.News", "news")
                        .WithMany("categories")
                        .HasForeignKey("newid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("news");
                });

            modelBuilder.Entity("compents.Models.Source", b =>
                {
                    b.HasOne("compents.Models.News", "news")
                        .WithOne("sources")
                        .HasForeignKey("compents.Models.Source", "newid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("news");
                });

            modelBuilder.Entity("compents.Models.News", b =>
                {
                    b.Navigation("categories");

                    b.Navigation("sources");
                });
#pragma warning restore 612, 618
        }
    }
}
