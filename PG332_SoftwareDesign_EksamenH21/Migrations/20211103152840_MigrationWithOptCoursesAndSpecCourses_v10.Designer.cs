﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PG332_SoftwareDesign_EksamenH21.Repository;

namespace PG332_SoftwareDesign_EksamenH21.Migrations
{
    [DbContext(typeof(TrackerContext))]
    [Migration("20211103152840_MigrationWithOptCoursesAndSpecCourses_v10")]
    partial class MigrationWithOptCoursesAndSpecCourses_v10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseCode")
                        .HasColumnType("TEXT");

                    b.Property<float>("CoursePoints")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExamType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Lecture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LectureDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.CourseInPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("SpecializationCoursesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SpecializationCoursesId");

                    b.ToTable("CourseInPlans");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.CoursesInSpecialization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SpecializationId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("mandatory")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SpecializationId")
                        .IsUnique();

                    b.ToTable("CoursesInSpecializations");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.Specialization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<long>("SpecializationId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserCoursePlanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SpecializationId");

                    b.HasIndex("UserCoursePlanId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.UserCoursePlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CourseInPlanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseInPlanId");

                    b.ToTable("UserCoursePlan");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Task", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<long?>("TaskSetId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskSetId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.TaskSet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("LectureId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LectureId")
                        .IsUnique();

                    b.ToTable("TaskSets");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Lecture", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Course", null)
                        .WithMany("Lectures")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.Address", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Model.User", null)
                        .WithOne("Address")
                        .HasForeignKey("PG332_SoftwareDesign_EksamenH21.Model.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.CourseInPlan", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Model.CoursesInSpecialization", "SpecializationCourses")
                        .WithMany()
                        .HasForeignKey("SpecializationCoursesId");

                    b.Navigation("SpecializationCourses");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.CoursesInSpecialization", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Model.Specialization", null)
                        .WithOne("SpecializationCourses")
                        .HasForeignKey("PG332_SoftwareDesign_EksamenH21.Model.CoursesInSpecialization", "SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.User", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Model.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Model.UserCoursePlan", "UserCoursePlan")
                        .WithMany()
                        .HasForeignKey("UserCoursePlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");

                    b.Navigation("UserCoursePlan");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.UserCoursePlan", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Model.CourseInPlan", "CourseInPlan")
                        .WithMany()
                        .HasForeignKey("CourseInPlanId");

                    b.Navigation("CourseInPlan");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Task", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.TaskSet", null)
                        .WithMany("Tasks")
                        .HasForeignKey("TaskSetId");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.TaskSet", b =>
                {
                    b.HasOne("PG332_SoftwareDesign_EksamenH21.Lecture", null)
                        .WithOne("TaskSet")
                        .HasForeignKey("PG332_SoftwareDesign_EksamenH21.TaskSet", "LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Course", b =>
                {
                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Lecture", b =>
                {
                    b.Navigation("TaskSet");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.Specialization", b =>
                {
                    b.Navigation("SpecializationCourses");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.Model.User", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("PG332_SoftwareDesign_EksamenH21.TaskSet", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
