﻿// <auto-generated />
using System;
using AnoraRFID.DataAccess.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnoraRFID.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.RoleClaimEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "3b62dea4-4f10-4d15-a2ad-afc66399dd72",
                            IsDeleted = false,
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "511ec17b-4b37-4416-be77-5ed1464c30e4",
                            IsDeleted = false,
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserClaimEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserLoginEntity", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserRoleEntity", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserTokenEntity", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.InventoryDetailEntity", b =>
                {
                    b.Property<int>("DTL_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("COMPLETE_USER")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("INVENTORY_ID")
                        .HasColumnType("int");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<int>("PRODUCT_ID")
                        .HasColumnType("int");

                    b.Property<int>("STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái xử lý: 1 - Tìm thấy; 2 - Không tìm thấy");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.HasKey("DTL_ID");

                    b.ToTable("INVENTORY_DTL");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.InventoryEntity", b =>
                {
                    b.Property<int>("IVENTORY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("COMPLETE_USER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("INVENTORY_NAME")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("INVENTORY_STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái xử lý: 1 - chờ xử lý; 2 - đã hoàn thành");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IVENTORY_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("IVENTORY_SEQ")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("REF_DOC_NO")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.HasKey("IVENTORY_ID");

                    b.ToTable("INVENTORY");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.LogEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExceptionDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExceptionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("LogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("OperationSystemVersion")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RequestBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestIpAddress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RequestUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RequestUserId")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.Property<string>("UserAgent")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.ModelEntity", b =>
                {
                    b.Property<int>("MODEL_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<string>("MODEL_NAME")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.HasKey("MODEL_ID");

                    b.ToTable("MODEL");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.ProductAlertEntity", b =>
                {
                    b.Property<int>("ALERT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ALERT_CONF_REASON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ALERT_CONF_STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái xử lý: 1 - chưa xử lý; 2 - đã xử lý");

                    b.Property<DateTime>("ALERT_CONF_TIME")
                        .HasColumnType("datetime2");

                    b.Property<string>("ALERT_CONF_USER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ALERT_FREQ")
                        .HasColumnType("int");

                    b.Property<string>("ALERT_IP")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("ALERT_TIME")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("EPC")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<int>("PRODUCT_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.HasKey("ALERT_ID");

                    b.ToTable("PRODUCT_ALTER");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.ProductEntity", b =>
                {
                    b.Property<int>("PRODUCT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("COLOR_NAME")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("COMPLETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("DEV_NAME")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DEV_TEAM")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EPC")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("INPUT_DATE")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<int>("LAST_ID")
                        .HasColumnType("int");

                    b.Property<int>("LR")
                        .HasColumnType("int")
                        .HasComment("Bên của giầy: 1 - Left; 2 - Right");

                    b.Property<int>("MODEL_ID")
                        .HasColumnType("int");

                    b.Property<string>("OUTSOLE_MATERIAL")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PAIR_CODE")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_ARTICLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRODUCT_CODE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PRODUCT_CUSTODIAN")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRODUCT_GENDER")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_LOCATION")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PRODUCT_MSMATERIAL")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_NAME")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PRODUCT_PATTERN")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_SEASON")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_SIZE")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("PRODUCT_STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái của giầy: 1 - Available; 2 - NotAvailable; 3 - OnHold");

                    b.Property<string>("PRODUCT_STLFILE")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_TDCODE")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PRODUCT_WHQDEVELOPER")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("REF_DOC_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("REF_DOC_NO")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SAMPLE_NO")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SAMPLE_REQUEST")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SAMPLE_SIZE")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.Property<string>("UPPER_MATERIAL")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PRODUCT_ID");

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.ProductInoutDetailEntity", b =>
                {
                    b.Property<int>("IO_DTL_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("IO_DTL_EXT")
                        .HasColumnType("int");

                    b.Property<string>("IO_GET_NOTE")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("IO_GET_STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái giầy lấy: 1 - Ok; 2 - không ok");

                    b.Property<DateTime>("IO_GET_TIME")
                        .HasColumnType("datetime2");

                    b.Property<string>("IO_GET_USER")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IO_ID")
                        .HasColumnType("int");

                    b.Property<string>("IO_RET_NOTE")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("IO_RET_STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái giầy trả: 1 - Ok; 2 - không ok");

                    b.Property<DateTime>("IO_RET_TIME")
                        .HasColumnType("datetime2");

                    b.Property<string>("IO_RET_USER")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<int>("PRODUCT_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.HasKey("IO_DTL_ID");

                    b.ToTable("PRODUCT_IO_DTL");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.ProductInoutEntity", b =>
                {
                    b.Property<int>("IO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IO_DEPART")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("IO_REASON")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("IO_STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái của inout: 1 - chưa trả; 2 - đã trả");

                    b.Property<DateTime>("REF_DOC_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("REF_DOC_NO")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("IO_ID");

                    b.ToTable("PRODUCT_IO");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.RFIDTagEntity", b =>
                {
                    b.Property<int>("RFID_TAG_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("CREATED_USER_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DELETED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("EPC")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<int>("TAG_STATUS")
                        .HasColumnType("int")
                        .HasComment("Trạng thái xử lý: 1 - Sẵn sàng; 2 - Bị hủy");

                    b.Property<DateTime>("UPDATED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("UPDATETED_USER_ID")
                        .HasColumnType("int");

                    b.HasKey("RFID_TAG_ID");

                    b.ToTable("RFID_TAG");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Shared.ConfigurationEntity", b =>
                {
                    b.Property<int>("CONFIG_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IS_DELETED")
                        .HasColumnType("bit");

                    b.Property<string>("KEY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VALUE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CONFIG_ID");

                    b.ToTable("CONFIG");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.RoleClaimEntity", b =>
                {
                    b.HasOne("AnoraRFID.DataAccess.DAL.Entities.Identity.RoleEntity", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserClaimEntity", b =>
                {
                    b.HasOne("AnoraRFID.DataAccess.DAL.Entities.Identity.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserLoginEntity", b =>
                {
                    b.HasOne("AnoraRFID.DataAccess.DAL.Entities.Identity.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserRoleEntity", b =>
                {
                    b.HasOne("AnoraRFID.DataAccess.DAL.Entities.Identity.RoleEntity", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnoraRFID.DataAccess.DAL.Entities.Identity.UserEntity", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserTokenEntity", b =>
                {
                    b.HasOne("AnoraRFID.DataAccess.DAL.Entities.Identity.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.RoleEntity", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AnoraRFID.DataAccess.DAL.Entities.Identity.UserEntity", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}