﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Landmark_Remark.Migrations
{
    [DbContext(typeof(Landmark_RemarkContext))]
    [Migration("20190721025743_AddedUserAndUpdatedLocationMarker")]
    partial class AddedUserAndUpdatedLocationMarker
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Landmark_Remark.Models.LocationMarker", b =>
                {
                    b.Property<int>("LocationMarkerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<double>("Lat");

                    b.Property<double>("Lng");

                    b.Property<string>("Title");

                    b.Property<string>("UserID");

                    b.Property<int?>("UserID1");

                    b.HasKey("LocationMarkerID");

                    b.HasIndex("UserID1");

                    b.ToTable("LocationMarker");
                });

            modelBuilder.Entity("Landmark_Remark.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Landmark_Remark.Models.LocationMarker", b =>
                {
                    b.HasOne("Landmark_Remark.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID1");
                });
#pragma warning restore 612, 618
        }
    }
}
