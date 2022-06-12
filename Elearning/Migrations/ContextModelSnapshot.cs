﻿// <auto-generated />
using System;
using Elearning.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elearning.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Elearning.Entity.Admin", b =>
                {
                    b.Property<string>("teacherId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("Subject")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("birthDay")
                        .HasColumnType("date");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool?>("gender")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("teacherId");

                    b.HasIndex("Position");

                    b.HasIndex("Subject");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Elearning.Entity.AdminAccount", b =>
                {
                    b.Property<string>("userName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Admin")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<bool?>("isLogin")
                        .HasColumnType("bit");

                    b.Property<string>("passWord")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("userName");

                    b.HasIndex("Admin");

                    b.ToTable("AdminAccount");
                });

            modelBuilder.Entity("Elearning.Entity.Class", b =>
                {
                    b.Property<string>("classId")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("classId");

                    b.HasIndex("Grade");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Elearning.Entity.Class_Course", b =>
                {
                    b.Property<int>("lassCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("lassCourseId"), 1L, 1);

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<int?>("Course")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("lession")
                        .HasColumnType("datetime2");

                    b.HasKey("lassCourseId");

                    b.HasIndex("Class");

                    b.HasIndex("Course");

                    b.ToTable("Class_Course");
                });

            modelBuilder.Entity("Elearning.Entity.Class_Test", b =>
                {
                    b.Property<int>("classTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classTestId"), 1L, 1);

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("Test")
                        .HasColumnType("int");

                    b.Property<int?>("isComplete")
                        .HasColumnType("int");

                    b.Property<DateTime?>("testDate")
                        .HasColumnType("date");

                    b.Property<int?>("testDuration")
                        .HasColumnType("int");

                    b.HasKey("classTestId");

                    b.HasIndex("Class");

                    b.HasIndex("Test");

                    b.ToTable("Class_Test");
                });

            modelBuilder.Entity("Elearning.Entity.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("courseId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("Subject")
                        .HasColumnType("int");

                    b.Property<DateTime?>("endDate")
                        .HasColumnType("date");

                    b.Property<string>("linkOnline")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("startDate")
                        .HasColumnType("date");

                    b.HasKey("courseId");

                    b.HasIndex("Subject");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Elearning.Entity.Document", b =>
                {
                    b.Property<int>("docId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("docId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("Subject")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("docPath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("docId");

                    b.HasIndex("Subject");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("Elearning.Entity.Grade", b =>
                {
                    b.Property<int>("gradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gradeId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("gradeName")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)");

                    b.HasKey("gradeId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("Elearning.Entity.LearningOutcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Semester")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("Student_Test")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Student");

                    b.HasIndex("Student_Test");

                    b.ToTable("LearningOutcomes");
                });

            modelBuilder.Entity("Elearning.Entity.Position", b =>
                {
                    b.Property<int>("positionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("positionId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("positionName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("positionId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("Elearning.Entity.Student", b =>
                {
                    b.Property<string>("studentId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("birthDay")
                        .HasColumnType("date");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool?>("gender")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("studentId");

                    b.HasIndex("Class");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Elearning.Entity.Student_Test", b =>
                {
                    b.Property<int>("studentTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentTestId"), 1L, 1);

                    b.Property<int?>("Class_Test")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("documentTest")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double?>("testMath")
                        .HasColumnType("float");

                    b.HasKey("studentTestId");

                    b.HasIndex("Class_Test");

                    b.HasIndex("Student");

                    b.ToTable("Student_Test");
                });

            modelBuilder.Entity("Elearning.Entity.StudentAccount", b =>
                {
                    b.Property<string>("userName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Student")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("isLogin")
                        .HasColumnType("bit");

                    b.Property<string>("passWord")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("userName");

                    b.HasIndex("Student");

                    b.ToTable("StudentAccount");
                });

            modelBuilder.Entity("Elearning.Entity.Subject", b =>
                {
                    b.Property<int>("subjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subjectId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("subjectName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("subjectId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Elearning.Entity.Test", b =>
                {
                    b.Property<int>("testId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("testId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TestCategory")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("testId");

                    b.HasIndex("TestCategory");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Elearning.Entity.TestCategory", b =>
                {
                    b.Property<int>("testCateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("testCateId"), 1L, 1);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("testCateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("testCateId");

                    b.ToTable("TestCategory");
                });

            modelBuilder.Entity("Elearning.Entity.Admin", b =>
                {
                    b.HasOne("Elearning.Entity.Position", "Position1")
                        .WithMany("Admins")
                        .HasForeignKey("Position");

                    b.HasOne("Elearning.Entity.Subject", "Subject1")
                        .WithMany("Admins")
                        .HasForeignKey("Subject");

                    b.Navigation("Position1");

                    b.Navigation("Subject1");
                });

            modelBuilder.Entity("Elearning.Entity.AdminAccount", b =>
                {
                    b.HasOne("Elearning.Entity.Admin", "Admin1")
                        .WithMany("AdminAccounts")
                        .HasForeignKey("Admin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin1");
                });

            modelBuilder.Entity("Elearning.Entity.Class", b =>
                {
                    b.HasOne("Elearning.Entity.Grade", "Grade1")
                        .WithMany("Classes")
                        .HasForeignKey("Grade");

                    b.Navigation("Grade1");
                });

            modelBuilder.Entity("Elearning.Entity.Class_Course", b =>
                {
                    b.HasOne("Elearning.Entity.Class", "Class1")
                        .WithMany("Class_Course")
                        .HasForeignKey("Class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elearning.Entity.Course", "Course1")
                        .WithMany("Class_Course")
                        .HasForeignKey("Course");

                    b.Navigation("Class1");

                    b.Navigation("Course1");
                });

            modelBuilder.Entity("Elearning.Entity.Class_Test", b =>
                {
                    b.HasOne("Elearning.Entity.Class", "Class1")
                        .WithMany("Class_Test")
                        .HasForeignKey("Class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elearning.Entity.Test", "Test1")
                        .WithMany("Class_Test")
                        .HasForeignKey("Test");

                    b.Navigation("Class1");

                    b.Navigation("Test1");
                });

            modelBuilder.Entity("Elearning.Entity.Course", b =>
                {
                    b.HasOne("Elearning.Entity.Subject", "Subject1")
                        .WithMany("Courses")
                        .HasForeignKey("Subject");

                    b.Navigation("Subject1");
                });

            modelBuilder.Entity("Elearning.Entity.Document", b =>
                {
                    b.HasOne("Elearning.Entity.Subject", "Subject1")
                        .WithMany("Documents")
                        .HasForeignKey("Subject");

                    b.Navigation("Subject1");
                });

            modelBuilder.Entity("Elearning.Entity.LearningOutcome", b =>
                {
                    b.HasOne("Elearning.Entity.Student", "Student1")
                        .WithMany("LearningOutcomes")
                        .HasForeignKey("Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elearning.Entity.Student_Test", "Student_Test1")
                        .WithMany("LearningOutcomes")
                        .HasForeignKey("Student_Test");

                    b.Navigation("Student1");

                    b.Navigation("Student_Test1");
                });

            modelBuilder.Entity("Elearning.Entity.Student", b =>
                {
                    b.HasOne("Elearning.Entity.Class", "Class1")
                        .WithMany("Students")
                        .HasForeignKey("Class")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class1");
                });

            modelBuilder.Entity("Elearning.Entity.Student_Test", b =>
                {
                    b.HasOne("Elearning.Entity.Class_Test", "Class_Test1")
                        .WithMany("Student_Test")
                        .HasForeignKey("Class_Test");

                    b.HasOne("Elearning.Entity.Student", "Student1")
                        .WithMany("Student_Test")
                        .HasForeignKey("Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class_Test1");

                    b.Navigation("Student1");
                });

            modelBuilder.Entity("Elearning.Entity.StudentAccount", b =>
                {
                    b.HasOne("Elearning.Entity.Student", "Student1")
                        .WithMany("StudentAccounts")
                        .HasForeignKey("Student")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student1");
                });

            modelBuilder.Entity("Elearning.Entity.Test", b =>
                {
                    b.HasOne("Elearning.Entity.TestCategory", "TestCategory1")
                        .WithMany("Tests")
                        .HasForeignKey("TestCategory");

                    b.Navigation("TestCategory1");
                });

            modelBuilder.Entity("Elearning.Entity.Admin", b =>
                {
                    b.Navigation("AdminAccounts");
                });

            modelBuilder.Entity("Elearning.Entity.Class", b =>
                {
                    b.Navigation("Class_Course");

                    b.Navigation("Class_Test");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Elearning.Entity.Class_Test", b =>
                {
                    b.Navigation("Student_Test");
                });

            modelBuilder.Entity("Elearning.Entity.Course", b =>
                {
                    b.Navigation("Class_Course");
                });

            modelBuilder.Entity("Elearning.Entity.Grade", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Elearning.Entity.Position", b =>
                {
                    b.Navigation("Admins");
                });

            modelBuilder.Entity("Elearning.Entity.Student", b =>
                {
                    b.Navigation("LearningOutcomes");

                    b.Navigation("StudentAccounts");

                    b.Navigation("Student_Test");
                });

            modelBuilder.Entity("Elearning.Entity.Student_Test", b =>
                {
                    b.Navigation("LearningOutcomes");
                });

            modelBuilder.Entity("Elearning.Entity.Subject", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Courses");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("Elearning.Entity.Test", b =>
                {
                    b.Navigation("Class_Test");
                });

            modelBuilder.Entity("Elearning.Entity.TestCategory", b =>
                {
                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
