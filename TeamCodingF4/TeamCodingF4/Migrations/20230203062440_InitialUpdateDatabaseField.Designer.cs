﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamCodingF4.Data;

#nullable disable

namespace TeamCodingF4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230203062440_InitialUpdateDatabaseField")]
    partial class InitialUpdateDatabaseField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConditionEstate", b =>
                {
                    b.Property<int>("ConditionsId")
                        .HasColumnType("int");

                    b.Property<int>("EstateId")
                        .HasColumnType("int");

                    b.HasKey("ConditionsId", "EstateId");

                    b.HasIndex("EstateId");

                    b.ToTable("ConditionEstate");
                });

            modelBuilder.Entity("EquipmentEstate", b =>
                {
                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("EstateId")
                        .HasColumnType("int");

                    b.HasKey("EquipmentId", "EstateId");

                    b.HasIndex("EstateId");

                    b.ToTable("EquipmentEstate");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.ArticleLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("ArticleLikes");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.ArticleReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("PublisherId");

                    b.ToTable("ArticlesReply");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            Content = "終於快寫好心得分享了~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 1, 0, DateTimeKind.Unspecified),
                            PublisherId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            Content = "終於快寫好發文解惑了~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 2, 0, DateTimeKind.Unspecified),
                            PublisherId = 2
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            Content = "終於快寫好閒聊專區了~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 3, 0, DateTimeKind.Unspecified),
                            PublisherId = 3
                        },
                        new
                        {
                            Id = 4,
                            ArticleId = 4,
                            Content = "終於快寫好抱怨專區了~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified),
                            PublisherId = 4
                        },
                        new
                        {
                            Id = 5,
                            ArticleId = 5,
                            Content = "終於快寫好找尋室友了~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified),
                            PublisherId = 5
                        });
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Articles", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleId"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("ArticleId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            Category = "心得分享",
                            Content = "心得分享!",
                            Date = new DateTime(2008, 3, 1, 7, 0, 1, 0, DateTimeKind.Unspecified),
                            PublisherId = 1,
                            Title = "範例",
                            ViewCount = 0
                        },
                        new
                        {
                            ArticleId = 2,
                            Category = "發文解惑",
                            Content = "發文解惑~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 2, 0, DateTimeKind.Unspecified),
                            PublisherId = 2,
                            Title = "範例",
                            ViewCount = 0
                        },
                        new
                        {
                            ArticleId = 3,
                            Category = "閒聊專區",
                            Content = "閒聊專區~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 3, 0, DateTimeKind.Unspecified),
                            PublisherId = 3,
                            Title = "範例",
                            ViewCount = 0
                        },
                        new
                        {
                            ArticleId = 4,
                            Category = "抱怨專區",
                            Content = "抱怨專區~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified),
                            PublisherId = 4,
                            Title = "範例",
                            ViewCount = 0
                        },
                        new
                        {
                            ArticleId = 5,
                            Category = "找尋室友",
                            Content = "找尋室友~",
                            Date = new DateTime(2008, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified),
                            PublisherId = 5,
                            Title = "範例",
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Estate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Car")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstateVideoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lease")
                        .HasColumnType("int");

                    b.Property<float>("Meters")
                        .HasColumnType("real");

                    b.Property<decimal>("Miscellaneous")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Motorcycle")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Estates");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.EstateImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<int>("EstateId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("EstateId");

                    b.ToTable("EstateImages");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.EstateLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EstateLikes");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Account = "Admin001",
                            BirthDate = new DateTime(1990, 3, 1, 7, 0, 1, 0, DateTimeKind.Unspecified),
                            Email = "admin001@gmail.com",
                            Gender = 1,
                            Identity = "A123456789",
                            Job = "工程師",
                            Name = "ken",
                            Password = "1111",
                            PasswordHash = "1111",
                            Phone = "0900000001",
                            PicturePath = "111",
                            Rate = 5,
                            Role = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Account = "User002",
                            BirthDate = new DateTime(1991, 3, 1, 7, 0, 2, 0, DateTimeKind.Unspecified),
                            Email = "user002@gmail.com",
                            Gender = 1,
                            Identity = "A123456780",
                            Job = "老師",
                            Name = "jack",
                            Password = "2222",
                            PasswordHash = "2222",
                            Phone = "0900000002",
                            PicturePath = "222",
                            Rate = 4,
                            Role = "User"
                        },
                        new
                        {
                            Id = 3,
                            Account = "User003",
                            BirthDate = new DateTime(1992, 3, 1, 7, 0, 3, 0, DateTimeKind.Unspecified),
                            Email = "user003@gmail.com",
                            Gender = 1,
                            Identity = "A123456781",
                            Job = "歌手",
                            Name = "mark",
                            Password = "3333",
                            PasswordHash = "3333",
                            Phone = "0900000003",
                            PicturePath = "333",
                            Rate = 3,
                            Role = "User"
                        },
                        new
                        {
                            Id = 4,
                            Account = "User004",
                            BirthDate = new DateTime(1993, 3, 1, 7, 0, 4, 0, DateTimeKind.Unspecified),
                            Email = "user004@gmail.com",
                            Gender = 2,
                            Identity = "A123456782",
                            Job = "銀行員",
                            Name = "rose",
                            Password = "4444",
                            PasswordHash = "4444",
                            Phone = "0900000004",
                            PicturePath = "444",
                            Rate = 2,
                            Role = "User"
                        },
                        new
                        {
                            Id = 5,
                            Account = "User005",
                            BirthDate = new DateTime(1994, 3, 1, 7, 0, 5, 0, DateTimeKind.Unspecified),
                            Email = "user005@gmail.com",
                            Gender = 2,
                            Identity = "A123456783",
                            Job = "行政人員",
                            Name = "vivian",
                            Password = "5555",
                            PasswordHash = "5555",
                            Phone = "0900000005",
                            PicturePath = "555",
                            Rate = 1,
                            Role = "User"
                        });
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("ConditionEstate", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.Condition", null)
                        .WithMany()
                        .HasForeignKey("ConditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamCodingF4.Data.Entity.Estate", null)
                        .WithMany()
                        .HasForeignKey("EstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EquipmentEstate", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.Equipment", null)
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamCodingF4.Data.Entity.Estate", null)
                        .WithMany()
                        .HasForeignKey("EstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.ArticleLike", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.Articles", "Articles")
                        .WithMany("ArticleLikes")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamCodingF4.Data.Entity.Member", "Member")
                        .WithMany("ArticleLikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articles");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.ArticleReply", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.Articles", "Article")
                        .WithMany("ArticleReplies")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamCodingF4.Data.Entity.Member", "Member")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Articles", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.Member", "Member")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Estate", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.RoomType", "RoomType")
                        .WithMany("Estate")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.EstateImage", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.Estate", "Estate")
                        .WithMany("EstateImage")
                        .HasForeignKey("EstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estate");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.EstateLike", b =>
                {
                    b.HasOne("TeamCodingF4.Data.Entity.Member", "Member")
                        .WithMany("EstateLikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Articles", b =>
                {
                    b.Navigation("ArticleLikes");

                    b.Navigation("ArticleReplies");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Estate", b =>
                {
                    b.Navigation("EstateImage");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.Member", b =>
                {
                    b.Navigation("ArticleLikes");

                    b.Navigation("EstateLikes");
                });

            modelBuilder.Entity("TeamCodingF4.Data.Entity.RoomType", b =>
                {
                    b.Navigation("Estate");
                });
#pragma warning restore 612, 618
        }
    }
}
