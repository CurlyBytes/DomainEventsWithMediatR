﻿// <auto-generated />
using System;
using DomainEventsMediatR.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DomainEventsMediatR.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200103180518_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainEventsMediatR.Domain.BacklogItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAtUtc");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<Guid?>("SprintId");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.ToTable("BacklogItems");
                });

            modelBuilder.Entity("DomainEventsMediatR.Domain.Sprint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAtUtc");

                    b.Property<DateTime>("EndDateUtc");

                    b.Property<DateTime>("StartDateUtc");

                    b.HasKey("Id");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("DomainEventsMediatR.Domain.BacklogItem", b =>
                {
                    b.HasOne("DomainEventsMediatR.Domain.Sprint", "Sprint")
                        .WithMany("BackLogItems")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
