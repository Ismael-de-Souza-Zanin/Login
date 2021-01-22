﻿// <auto-generated />
using Logins.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Logins.Migrations
{
    [DbContext(typeof(LoginsContext))]
    [Migration("20210122145723_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Logins.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfPages");

                    b.Property<double>("Price");

                    b.Property<string>("PublishingCompany");

                    b.HasKey("BookID");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
