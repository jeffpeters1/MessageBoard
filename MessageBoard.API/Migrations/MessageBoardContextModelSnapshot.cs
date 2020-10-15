﻿// <auto-generated />
using System;
using MessageBoard.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.API.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    partial class MessageBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MessageBoard.API.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(280)")
                        .HasMaxLength(280);

                    b.HasKey("Id");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b5c3e2e2-beb2-4178-bb63-c0a749860fb1"),
                            Body = "It was a bright cold day in April, and the clocks were striking thirteen"
                        },
                        new
                        {
                            Id = new Guid("12d50335-25c5-422a-b010-fbfc7726ef9a"),
                            Body = "It was the best of times, it was the worst of times"
                        },
                        new
                        {
                            Id = new Guid("637eda53-dc77-4650-b390-3eefd42c75bf"),
                            Body = "I'll tell you what I want, what I really, really want"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
