﻿// <auto-generated />
using System;
using ElarosApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElarosApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ElarosApp.Models.AnswerModel", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Answer1")
                        .HasColumnType("int");

                    b.Property<int?>("Answer2")
                        .HasColumnType("int");

                    b.Property<int?>("Answer3")
                        .HasColumnType("int");

                    b.Property<int?>("Answer4")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ElarosApp.Models.PatientModel", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CurrentQuestionQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("ReferalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.HasIndex("CurrentQuestionQuestionId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ElarosApp.Models.QuestionModel", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfAnswers")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ElarosApp.Models.AnswerModel", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.PatientModel", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", "CurrentQuestion")
                        .WithMany()
                        .HasForeignKey("CurrentQuestionQuestionId");

                    b.Navigation("CurrentQuestion");
                });

            modelBuilder.Entity("ElarosApp.Models.QuestionModel", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
