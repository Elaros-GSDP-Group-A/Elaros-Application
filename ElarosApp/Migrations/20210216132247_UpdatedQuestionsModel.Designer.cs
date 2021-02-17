﻿// <auto-generated />
using System;
using ElarosApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElarosApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210216132247_UpdatedQuestionsModel")]
    partial class UpdatedQuestionsModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ElarosApp.Models.Activities", b =>
                {
                    b.Property<int>("ActivitiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("ActivitiesId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("ElarosApp.Models.Anxiety", b =>
                {
                    b.Property<int>("AnxietyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnxietyId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Anxiety");
                });

            modelBuilder.Entity("ElarosApp.Models.Breathlessness", b =>
                {
                    b.Property<int>("BreathlessnessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PostcovidAtRest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostcovidDressing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostcovidWalkingUpStairs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecovidAtRest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecovidDressing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrecovidWalkingUpStairs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("BreathlessnessId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Breathlessness");
                });

            modelBuilder.Entity("ElarosApp.Models.Cognition", b =>
                {
                    b.Property<int>("CognitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("DifficultyConcentrating")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ShortTermMemoryEffected")
                        .HasColumnType("bit");

                    b.HasKey("CognitionId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Cognition");
                });

            modelBuilder.Entity("ElarosApp.Models.Communication", b =>
                {
                    b.Property<int>("CommunicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("DifficultyCommunicating")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommunicationId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Communication");
                });

            modelBuilder.Entity("ElarosApp.Models.Consumption", b =>
                {
                    b.Property<int>("ConsumptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("DifficultySwallowing")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("WeightlossConcern")
                        .HasColumnType("bit");

                    b.HasKey("ConsumptionId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Consumption");
                });

            modelBuilder.Entity("ElarosApp.Models.Continence", b =>
                {
                    b.Property<int>("ContinenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("BladderProblems")
                        .HasColumnType("bit");

                    b.Property<bool?>("BowelProblems")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContinenceId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Continence");
                });

            modelBuilder.Entity("ElarosApp.Models.Depression", b =>
                {
                    b.Property<int>("DepressionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("DepressionId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Depression");
                });

            modelBuilder.Entity("ElarosApp.Models.Employment", b =>
                {
                    b.Property<int>("ActivitiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmploymentBeforeLockdown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmploymentNow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmploymentPrecovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyOrCarerAdditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherClinicalNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("UnmentionedProblemsPostCovid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivitiesId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Employment");
                });

            modelBuilder.Entity("ElarosApp.Models.Fatigue", b =>
                {
                    b.Property<int>("FatigueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("FatigueId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Fatigue");
                });

            modelBuilder.Entity("ElarosApp.Models.Mobility", b =>
                {
                    b.Property<int>("MobilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("MobilityId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Mobility");
                });

            modelBuilder.Entity("ElarosApp.Models.OpeningQuestion", b =>
                {
                    b.Property<int>("OpeningQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HealthServicesDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HealthServicesUsed")
                        .HasColumnType("bit");

                    b.Property<bool>("MedicalProblems")
                        .HasColumnType("bit");

                    b.Property<string>("MedicalProblemsDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("OpeningQuestionId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("OpeningQuestion");
                });

            modelBuilder.Entity("ElarosApp.Models.OverallHealth", b =>
                {
                    b.Property<int>("OverallHealthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("OverallHealthId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("OverallHealth");
                });

            modelBuilder.Entity("ElarosApp.Models.Pain", b =>
                {
                    b.Property<int>("PainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("NewPain")
                        .HasColumnType("bit");

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("PainId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Pain");
                });

            modelBuilder.Entity("ElarosApp.Models.PatientModel", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("FinishedQuestionniare")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("ReferalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ElarosApp.Models.PersonalCare", b =>
                {
                    b.Property<int>("PersonalCareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("PersonalCareId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("PersonalCare");
                });

            modelBuilder.Entity("ElarosApp.Models.Ptsd", b =>
                {
                    b.Property<int>("PtsdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.Property<bool?>("SelfharmThoughts")
                        .HasColumnType("bit");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ThoughtOrFeelingAvoidance")
                        .HasColumnType("bit");

                    b.Property<bool?>("UnpleasantDreams")
                        .HasColumnType("bit");

                    b.Property<bool?>("UnwantedMemoriesWhilstAwake")
                        .HasColumnType("bit");

                    b.HasKey("PtsdId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Ptsd");
                });

            modelBuilder.Entity("ElarosApp.Models.QuestionModel", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ActivitiesId")
                        .HasColumnType("int");

                    b.Property<int?>("AnxietyId")
                        .HasColumnType("int");

                    b.Property<int?>("BreathlessnessId")
                        .HasColumnType("int");

                    b.Property<int?>("CognitionId")
                        .HasColumnType("int");

                    b.Property<int?>("CommunicationId")
                        .HasColumnType("int");

                    b.Property<int?>("ConsumptionId")
                        .HasColumnType("int");

                    b.Property<int?>("ContinenceId")
                        .HasColumnType("int");

                    b.Property<int?>("DepressionId")
                        .HasColumnType("int");

                    b.Property<int?>("EmploymentId")
                        .HasColumnType("int");

                    b.Property<int?>("FatigueId")
                        .HasColumnType("int");

                    b.Property<int?>("MobilityId")
                        .HasColumnType("int");

                    b.Property<int?>("OpeningQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("OverallHealthId")
                        .HasColumnType("int");

                    b.Property<int?>("PainId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonalCareId")
                        .HasColumnType("int");

                    b.Property<int?>("PtsdId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SocialRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("VoiceId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ElarosApp.Models.SocialRole", b =>
                {
                    b.Property<int>("SocialRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Postcovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precovid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.HasKey("SocialRoleId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("SocialRole");
                });

            modelBuilder.Entity("ElarosApp.Models.Voice", b =>
                {
                    b.Property<int>("VoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("NoiseyBreathing")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionModelQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SoreThroat")
                        .HasColumnType("bit");

                    b.Property<bool?>("VoiceChange")
                        .HasColumnType("bit");

                    b.HasKey("VoiceId");

                    b.HasIndex("QuestionModelQuestionId");

                    b.ToTable("Voice");
                });

            modelBuilder.Entity("ElarosApp.Models.Activities", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Activities")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Anxiety", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Anxiety")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Breathlessness", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Breathlessness")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Cognition", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Cognition")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Communication", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Communication")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Consumption", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Consumption")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Continence", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Continence")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Depression", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Depression")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Employment", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Employment")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Fatigue", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Fatigue")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Mobility", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Mobility")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.OpeningQuestion", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("OpeningQuestion")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.OverallHealth", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("OverallHealth")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Pain", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Pain")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.PatientModel", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ElarosApp.Models.PersonalCare", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("PersonalCare")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Ptsd", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Ptsd")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.SocialRole", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("SocialRole")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.Voice", b =>
                {
                    b.HasOne("ElarosApp.Models.QuestionModel", null)
                        .WithMany("Voice")
                        .HasForeignKey("QuestionModelQuestionId");
                });

            modelBuilder.Entity("ElarosApp.Models.QuestionModel", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Anxiety");

                    b.Navigation("Breathlessness");

                    b.Navigation("Cognition");

                    b.Navigation("Communication");

                    b.Navigation("Consumption");

                    b.Navigation("Continence");

                    b.Navigation("Depression");

                    b.Navigation("Employment");

                    b.Navigation("Fatigue");

                    b.Navigation("Mobility");

                    b.Navigation("OpeningQuestion");

                    b.Navigation("OverallHealth");

                    b.Navigation("Pain");

                    b.Navigation("PersonalCare");

                    b.Navigation("Ptsd");

                    b.Navigation("SocialRole");

                    b.Navigation("Voice");
                });
#pragma warning restore 612, 618
        }
    }
}
