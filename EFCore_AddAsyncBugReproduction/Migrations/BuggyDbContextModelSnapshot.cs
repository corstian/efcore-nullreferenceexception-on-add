﻿// <auto-generated />
using System;
using EFCore_AddAsyncBugReproduction;
using GeoAPI.Geometries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore_AddAsyncBugReproduction.Migrations
{
    [DbContext(typeof(BuggyDbContext))]
    partial class BuggyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore_AddAsyncBugReproduction.Bug", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<IPoint>("Point");

                    b.Property<DateTime>("Smashed");

                    b.HasKey("Id");

                    b.ToTable("Bugs");
                });
#pragma warning restore 612, 618
        }
    }
}