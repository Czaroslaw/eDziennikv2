﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eDziennikv2.Data;

#nullable disable

namespace eDziennikv2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230605114312_Create Tables For Grades")]
    partial class CreateTablesForGrades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Identity")
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

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

                    b.ToTable("AspNetUsers", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Administracyjny",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "celina.piotrowska@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Celina",
                            LastName = "Piotrowska",
                            LockoutEnabled = false,
                            NormalizedEmail = "CELINA.PIOTROWSKA@TESTOWY.MAIL",
                            NormalizedUserName = "CELINA.PIOTROWSKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "celina.piotrowska"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sulisław.dudek@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Sulisław",
                            LastName = "Dudek",
                            LockoutEnabled = false,
                            NormalizedEmail = "SULISŁAW.DUDEK@TESTOWY.MAIL",
                            NormalizedUserName = "SULISŁAW.DUDEK",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "sulisław.dudek"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "maksym.dudek@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Maksym",
                            LastName = "Dudek",
                            LockoutEnabled = false,
                            NormalizedEmail = "MAKSYM.DUDEK@TESTOWY.MAIL",
                            NormalizedUserName = "MAKSYM.DUDEK",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "maksym.dudek"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mirosława.rutkowska@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Mirosława",
                            LastName = "Rutkowska",
                            LockoutEnabled = false,
                            NormalizedEmail = "MIROSŁAWA.RUTKOWSKA@TESTOWY.MAIL",
                            NormalizedUserName = "MIROSŁAWA.RUTKOWSKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "mirosława.rutkowska"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "henryka.jasińska@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Henryka",
                            LastName = "Jasińska",
                            LockoutEnabled = false,
                            NormalizedEmail = "HENRYKA.JASIŃSKA@TESTOWY.MAIL",
                            NormalizedUserName = "HENRYKA.JASIŃSKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "henryka.jasińska"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kazia.sawicka@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Kazia",
                            LastName = "Sawicka",
                            LockoutEnabled = false,
                            NormalizedEmail = "KAZIA.SAWICKA@TESTOWY.MAIL",
                            NormalizedUserName = "KAZIA.SAWICKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "kazia.sawicka"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jadwiga.piotrowska@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Jadwiga",
                            LastName = "Piotrowska",
                            LockoutEnabled = false,
                            NormalizedEmail = "JADWIGA.PIOTROWSKA@TESTOWY.MAIL",
                            NormalizedUserName = "JADWIGA.PIOTROWSKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "jadwiga.piotrowska"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "wielisław.czerwinski@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Wielisław",
                            LastName = "Czerwinski",
                            LockoutEnabled = false,
                            NormalizedEmail = "WIELISŁAW.CZERWINSKI@TESTOWY.MAIL",
                            NormalizedUserName = "WIELISŁAW.CZERWINSKI",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "wielisław.czerwinski"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "antoni.kalinowski@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Antoni",
                            LastName = "Kalinowski",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANTONI.KALINOWSKI@TESTOWY.MAIL",
                            NormalizedUserName = "ANTONI.KALINOWSKI",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "antoni.kalinowski"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dawid.kucharski@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Dawid",
                            LastName = "Kucharski",
                            LockoutEnabled = false,
                            NormalizedEmail = "DAWID.KUCHARSKI@TESTOWY.MAIL",
                            NormalizedUserName = "DAWID.KUCHARSKI",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "dawid.kucharski"
                        },
                        new
                        {
                            Id = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b607265e-828b-4343-a054-182a257f7e7c",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adrianna.zawadzka@testowy.mail",
                            EmailConfirmed = true,
                            FirstName = "Adrianna",
                            LastName = "Zawadzka",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADRIANNA.ZAWADZKA@TESTOWY.MAIL",
                            NormalizedUserName = "ADRIANNA.ZAWADZKA",
                            PasswordHash = "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ",
                            TwoFactorEnabled = false,
                            UserName = "adrianna.zawadzka"
                        });
                });

            modelBuilder.Entity("eDziennikv2.Data.ExampleUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExampleUser", "Identity");
                });

            modelBuilder.Entity("eDziennikv2.Models.Grades", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("IssuedById")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IssuedToId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IssuedById");

                    b.HasIndex("IssuedToId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Grades", "Identity");
                });

            modelBuilder.Entity("eDziennikv2.Models.Groups", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                            Name = "Klasa 1A"
                        },
                        new
                        {
                            Id = "50da648c-000c-4ebf-88e1-ae1688dfc57g",
                            Name = "Klasa 2B"
                        },
                        new
                        {
                            Id = "50da648c-000c-4ebf-88e1-ae1688dfc57h",
                            Name = "Klasa 3C"
                        });
                });

            modelBuilder.Entity("eDziennikv2.Models.Subjects", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "04938cb0-3200-4134-94ce-7388f182cfc3",
                            Name = "Matematyka"
                        },
                        new
                        {
                            Id = "da5548f9-10da-42e2-93ee-d8092fae914e",
                            Name = "Biologia"
                        },
                        new
                        {
                            Id = "626fbe3d-d5a9-4746-9852-3b76a8dcfa4f",
                            Name = "Geografia"
                        },
                        new
                        {
                            Id = "c864e25d-f4eb-4d3d-a285-7ec321a3e4b1",
                            Name = "Informatyka"
                        },
                        new
                        {
                            Id = "65b59c1e-cb11-4ecb-81aa-fef668f10e00",
                            Name = "Historia"
                        },
                        new
                        {
                            Id = "fa6a06d0-498a-4cf0-a449-ad60ee3f95a9",
                            Name = "Angielski"
                        },
                        new
                        {
                            Id = "ae0a9bb6-a319-46c2-82f3-70c07f180f1c",
                            Name = "Polski"
                        });
                });

            modelBuilder.Entity("eDziennikv2.Models.UserGroups", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserGroups", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "b9728f5c-e48b-4f26-8970-2fd49f0b37fa",
                            GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11"
                        },
                        new
                        {
                            Id = "fb3e50e3-57f0-4a04-9d9c-0e16b0657760",
                            GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15"
                        },
                        new
                        {
                            Id = "73214d76-d821-4e21-b9c0-ad3e5062b544",
                            GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10"
                        },
                        new
                        {
                            Id = "11e487d0-1ce4-49d1-857e-5bf8588fd159",
                            GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17"
                        },
                        new
                        {
                            Id = "3cf6fef9-44d0-4aea-ac40-c5c29bf80d27",
                            GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18"
                        },
                        new
                        {
                            Id = "6649b7be-aec9-4d2c-a5f9-2756db2f75e8",
                            GroupId = "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Role", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                            ConcurrencyStamp = "1",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        },
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895712",
                            ConcurrencyStamp = "2",
                            Name = "Nauczyciel",
                            NormalizedName = "Teacher"
                        },
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895713",
                            ConcurrencyStamp = "2",
                            Name = "Uczeń",
                            NormalizedName = "Student"
                        },
                        new
                        {
                            Id = "fab4fac1-c546-41de-aebc-a14da6895714",
                            ConcurrencyStamp = "2",
                            Name = "Rodzic",
                            NormalizedName = "Parent"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "Identity");

                    b.HasData(
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895712"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895713"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895712"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895714"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895714"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895713"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895714"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895713"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895713"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895713"
                        },
                        new
                        {
                            UserId = "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20",
                            RoleId = "fab4fac1-c546-41de-aebc-a14da6895712"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Identity");
                });

            modelBuilder.Entity("eDziennikv2.Models.Grades", b =>
                {
                    b.HasOne("ApplicationUser", "IssuedBy")
                        .WithMany()
                        .HasForeignKey("IssuedById");

                    b.HasOne("ApplicationUser", "IssuedTo")
                        .WithMany()
                        .HasForeignKey("IssuedToId");

                    b.HasOne("eDziennikv2.Models.Subjects", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("IssuedBy");

                    b.Navigation("IssuedTo");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
