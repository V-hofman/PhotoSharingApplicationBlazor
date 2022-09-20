﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoSharingApplication.WebServices.REST.Photos.Infrastructure.Data;

#nullable disable

namespace PhotoSharingApplication.WebServices.REST.Photos.Migrations
{
    [DbContext(typeof(PhotosDbContext))]
    [Migration("20220920114120_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("PhotoSharingApplication.Shared.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageMimeType")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PhotoFile")
                        .HasColumnType("BLOB");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
