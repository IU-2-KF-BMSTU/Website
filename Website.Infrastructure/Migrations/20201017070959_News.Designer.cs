﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Website.Infrastructure;

namespace Website.Infrastructure.Migrations
{
    [DbContext(typeof(WebsiteDbContext))]
    [Migration("20201017070959_News")]
    partial class News
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Website.Domain.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("175f26be-6bbf-45be-932d-9b312f545c94"),
                            Description = "Описание кафедры",
                            Name = "ИУ-2 КФ"
                        });
                });

            modelBuilder.Entity("Website.Domain.Entities.MediaContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MediaContents");
                });

            modelBuilder.Entity("Website.Domain.Entities.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid[]>("ImagesIds")
                        .HasColumnType("uuid[]");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Website.Domain.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("QuestionerName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Website.Domain.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("text");

                    b.Property<string>("Degree")
                        .HasColumnType("text");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDepartmentHead")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<Guid?>("PictureId")
                        .HasColumnType("uuid");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeachingType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45434bf3-8778-4a9b-b209-ef7e28580f3f"),
                            Degree = "кандидат технических наук, доцент",
                            DepartmentId = new Guid("175f26be-6bbf-45be-932d-9b312f545c94"),
                            IsDepartmentHead = true,
                            Name = "Игорь",
                            Patronymic = "Владимирович",
                            Surname = "Чухраев",
                            TeachingType = 0
                        },
                        new
                        {
                            Id = new Guid("ef598232-6965-47b2-8982-5468fd02d394"),
                            Degree = "кандидат технических наук, доцент",
                            DepartmentId = new Guid("175f26be-6bbf-45be-932d-9b312f545c94"),
                            IsDepartmentHead = false,
                            Name = "Борсук",
                            Patronymic = "Александровна",
                            Surname = "Наталья",
                            TeachingType = 0
                        },
                        new
                        {
                            Id = new Guid("a989eeb9-51ee-4882-a028-c070ecb52e60"),
                            Degree = "кандидат технических наук, доцент",
                            DepartmentId = new Guid("175f26be-6bbf-45be-932d-9b312f545c94"),
                            IsDepartmentHead = false,
                            Name = "Дерюгина",
                            Patronymic = "Олеговна",
                            Surname = "Елена",
                            TeachingType = 0
                        });
                });

            modelBuilder.Entity("Website.Domain.Entities.Teacher", b =>
                {
                    b.HasOne("Website.Domain.Entities.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}