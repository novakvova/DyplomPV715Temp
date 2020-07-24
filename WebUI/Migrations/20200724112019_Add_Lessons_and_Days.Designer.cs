﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebUI.Entities;

namespace WebUI.Migrations
{
    [DbContext(typeof(DBApplicationContext))]
    [Migration("20200724112019_Add_Lessons_and_Days")]
    partial class Add_Lessons_and_Days
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebUI.Entities.Class", b =>
                {
                    b.Property<int>("Class_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Class_Letter")
                        .HasColumnType("int");

                    b.Property<int>("Class_UserId")
                        .HasColumnType("int");

                    b.Property<int>("Class_Year")
                        .HasColumnType("int");

                    b.Property<int?>("DbUserId")
                        .HasColumnType("int");

                    b.HasKey("Class_Id");

                    b.HasIndex("DbUserId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("WebUI.Entities.Days", b =>
                {
                    b.Property<int>("Day_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Day_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Day_Id");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("WebUI.Entities.DbRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("WebUI.Entities.DbUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("User_ClassId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WebUI.Entities.DbUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("WebUI.Entities.Lessons", b =>
                {
                    b.Property<int>("Lesson_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Day_Id1")
                        .HasColumnType("int");

                    b.Property<int>("Lesson_Day_Id")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Lesson_Id");

                    b.HasIndex("Day_Id1");

                    b.HasIndex("SubjectId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("WebUI.Entities.Mark", b =>
                {
                    b.Property<int>("MarkTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DbUserId")
                        .HasColumnType("int");

                    b.Property<int>("MarkType_Id")
                        .HasColumnType("int");

                    b.Property<int>("PupilId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MarkTypeId");

                    b.HasIndex("DbUserId");

                    b.HasIndex("MarkType_Id");

                    b.HasIndex("PupilId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("WebUI.Entities.MarkType", b =>
                {
                    b.Property<int>("MarkType_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarkType_Number")
                        .HasColumnType("int");

                    b.Property<string>("MarkType_Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarkType_Id");

                    b.ToTable("MarkTypes");
                });

            modelBuilder.Entity("WebUI.Entities.Pupil", b =>
                {
                    b.Property<int>("Pupil_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Class_Id")
                        .HasColumnType("int");

                    b.Property<int?>("DbRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Pupil_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Pupil_Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pupil_ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Pupil_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pupil_FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pupil_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pupil_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pupil_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pupil_Role_Id")
                        .HasColumnType("int");

                    b.Property<bool>("Pupil_Sex")
                        .HasColumnType("bit");

                    b.HasKey("Pupil_Id");

                    b.HasIndex("Class_Id");

                    b.HasIndex("DbRoleId");

                    b.ToTable("Pupils");
                });

            modelBuilder.Entity("WebUI.Entities.SubjectUser", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SubjectsSubject_Id")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SubjectId");

                    b.HasIndex("SubjectsSubject_Id");

                    b.HasIndex("UserId");

                    b.ToTable("SubjectUsers");
                });

            modelBuilder.Entity("WebUI.Entities.Subjects", b =>
                {
                    b.Property<int>("Subject_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Subject_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Subject_Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("WebUI.Entities.UserClasses", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId1");

                    b.ToTable("UserClasses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("WebUI.Entities.DbRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("WebUI.Entities.DbUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("WebUI.Entities.DbUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("WebUI.Entities.DbUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebUI.Entities.Class", b =>
                {
                    b.HasOne("WebUI.Entities.DbUser", "DbUser")
                        .WithMany()
                        .HasForeignKey("DbUserId");
                });

            modelBuilder.Entity("WebUI.Entities.DbUserRole", b =>
                {
                    b.HasOne("WebUI.Entities.DbRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebUI.Entities.DbUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebUI.Entities.Lessons", b =>
                {
                    b.HasOne("WebUI.Entities.Days", "Day_Id")
                        .WithMany()
                        .HasForeignKey("Day_Id1");

                    b.HasOne("WebUI.Entities.Subjects", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebUI.Entities.Mark", b =>
                {
                    b.HasOne("WebUI.Entities.DbUser", "DbUser")
                        .WithMany()
                        .HasForeignKey("DbUserId");

                    b.HasOne("WebUI.Entities.MarkType", "MarkType")
                        .WithMany()
                        .HasForeignKey("MarkType_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebUI.Entities.Pupil", "Pupil")
                        .WithMany()
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebUI.Entities.Subjects", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebUI.Entities.Pupil", b =>
                {
                    b.HasOne("WebUI.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("Class_Id");

                    b.HasOne("WebUI.Entities.DbRole", "DbRole")
                        .WithMany()
                        .HasForeignKey("DbRoleId");
                });

            modelBuilder.Entity("WebUI.Entities.SubjectUser", b =>
                {
                    b.HasOne("WebUI.Entities.Subjects", "Subjects")
                        .WithMany("SubjectUsers")
                        .HasForeignKey("SubjectsSubject_Id");

                    b.HasOne("WebUI.Entities.DbUser", "User")
                        .WithMany("UserSubjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebUI.Entities.UserClasses", b =>
                {
                    b.HasOne("WebUI.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebUI.Entities.DbUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
