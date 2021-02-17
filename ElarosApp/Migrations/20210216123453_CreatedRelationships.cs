using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Migrations
{
    public partial class CreatedRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningQuestionId = table.Column<int>(type: "int", nullable: true),
                    ActivitiesId = table.Column<int>(type: "int", nullable: true),
                    AnxietyId = table.Column<int>(type: "int", nullable: true),
                    BreathlessnessId = table.Column<int>(type: "int", nullable: true),
                    CognitionId = table.Column<int>(type: "int", nullable: true),
                    CommunicationId = table.Column<int>(type: "int", nullable: true),
                    ConsumptionId = table.Column<int>(type: "int", nullable: true),
                    ContinenceId = table.Column<int>(type: "int", nullable: true),
                    DepressionId = table.Column<int>(type: "int", nullable: true),
                    FatigueId = table.Column<int>(type: "int", nullable: true),
                    MobilityId = table.Column<int>(type: "int", nullable: true),
                    PainId = table.Column<int>(type: "int", nullable: true),
                    PersonalCareId = table.Column<int>(type: "int", nullable: true),
                    PtsdId = table.Column<int>(type: "int", nullable: true),
                    SocialRoleId = table.Column<int>(type: "int", nullable: true),
                    VoiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivitiesId);
                    table.ForeignKey(
                        name: "FK_Activities_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anxiety",
                columns: table => new
                {
                    AnxietyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anxiety", x => x.AnxietyId);
                    table.ForeignKey(
                        name: "FK_Anxiety_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Breathlessness",
                columns: table => new
                {
                    BreathlessnessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecovidAtRest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecovidDressing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecovidWalkingUpStairs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostcovidAtRest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostcovidDressing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostcovidWalkingUpStairs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breathlessness", x => x.BreathlessnessId);
                    table.ForeignKey(
                        name: "FK_Breathlessness_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cognition",
                columns: table => new
                {
                    CognitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifficultyConcentrating = table.Column<bool>(type: "bit", nullable: true),
                    ShortTermMemoryEffected = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cognition", x => x.CognitionId);
                    table.ForeignKey(
                        name: "FK_Cognition_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Communication",
                columns: table => new
                {
                    CommunicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifficultyCommunicating = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication", x => x.CommunicationId);
                    table.ForeignKey(
                        name: "FK_Communication_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Consumption",
                columns: table => new
                {
                    ConsumptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifficultySwallowing = table.Column<bool>(type: "bit", nullable: true),
                    WeightlossConcern = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumption", x => x.ConsumptionId);
                    table.ForeignKey(
                        name: "FK_Consumption_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Continence",
                columns: table => new
                {
                    ContinenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BowelProblems = table.Column<bool>(type: "bit", nullable: true),
                    BladderProblems = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continence", x => x.ContinenceId);
                    table.ForeignKey(
                        name: "FK_Continence_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Depression",
                columns: table => new
                {
                    DepressionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depression", x => x.DepressionId);
                    table.ForeignKey(
                        name: "FK_Depression_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentBeforeLockdown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentPrecovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentNow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyOrCarerAdditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnmentionedProblemsPostCovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherClinicalNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.ActivitiesId);
                    table.ForeignKey(
                        name: "FK_Employment_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fatigue",
                columns: table => new
                {
                    FatigueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatigue", x => x.FatigueId);
                    table.ForeignKey(
                        name: "FK_Fatigue_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mobility",
                columns: table => new
                {
                    MobilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobility", x => x.MobilityId);
                    table.ForeignKey(
                        name: "FK_Mobility_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpeningQuestion",
                columns: table => new
                {
                    OpeningQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalProblems = table.Column<bool>(type: "bit", nullable: false),
                    MedicalProblemsDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthServicesUsed = table.Column<bool>(type: "bit", nullable: false),
                    HealthServicesDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningQuestion", x => x.OpeningQuestionId);
                    table.ForeignKey(
                        name: "FK_OpeningQuestion_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OverallHealth",
                columns: table => new
                {
                    OverallHealthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverallHealth", x => x.OverallHealthId);
                    table.ForeignKey(
                        name: "FK_OverallHealth_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pain",
                columns: table => new
                {
                    PainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewPain = table.Column<bool>(type: "bit", nullable: true),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pain", x => x.PainId);
                    table.ForeignKey(
                        name: "FK_Pain_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    FinishedQuestionniare = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalCare",
                columns: table => new
                {
                    PersonalCareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalCare", x => x.PersonalCareId);
                    table.ForeignKey(
                        name: "FK_PersonalCare_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ptsd",
                columns: table => new
                {
                    PtsdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnwantedMemoriesWhilstAwake = table.Column<bool>(type: "bit", nullable: true),
                    UnpleasantDreams = table.Column<bool>(type: "bit", nullable: true),
                    ThoughtOrFeelingAvoidance = table.Column<bool>(type: "bit", nullable: true),
                    SelfharmThoughts = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ptsd", x => x.PtsdId);
                    table.ForeignKey(
                        name: "FK_Ptsd_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SocialRole",
                columns: table => new
                {
                    SocialRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialRole", x => x.SocialRoleId);
                    table.ForeignKey(
                        name: "FK_SocialRole_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Voice",
                columns: table => new
                {
                    VoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoreThroat = table.Column<bool>(type: "bit", nullable: true),
                    VoiceChange = table.Column<bool>(type: "bit", nullable: true),
                    NoiseyBreathing = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voice", x => x.VoiceId);
                    table.ForeignKey(
                        name: "FK_Voice_Questions_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_QuestionModelQuestionId",
                table: "Activities",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Anxiety_QuestionModelQuestionId",
                table: "Anxiety",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Breathlessness_QuestionModelQuestionId",
                table: "Breathlessness",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cognition_QuestionModelQuestionId",
                table: "Cognition",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Communication_QuestionModelQuestionId",
                table: "Communication",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumption_QuestionModelQuestionId",
                table: "Consumption",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Continence_QuestionModelQuestionId",
                table: "Continence",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Depression_QuestionModelQuestionId",
                table: "Depression",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_QuestionModelQuestionId",
                table: "Employment",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Fatigue_QuestionModelQuestionId",
                table: "Fatigue",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobility_QuestionModelQuestionId",
                table: "Mobility",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningQuestion_QuestionModelQuestionId",
                table: "OpeningQuestion",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_OverallHealth_QuestionModelQuestionId",
                table: "OverallHealth",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pain_QuestionModelQuestionId",
                table: "Pain",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_QuestionId",
                table: "Patients",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalCare_QuestionModelQuestionId",
                table: "PersonalCare",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ptsd_QuestionModelQuestionId",
                table: "Ptsd",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialRole_QuestionModelQuestionId",
                table: "SocialRole",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Voice_QuestionModelQuestionId",
                table: "Voice",
                column: "QuestionModelQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Anxiety");

            migrationBuilder.DropTable(
                name: "Breathlessness");

            migrationBuilder.DropTable(
                name: "Cognition");

            migrationBuilder.DropTable(
                name: "Communication");

            migrationBuilder.DropTable(
                name: "Consumption");

            migrationBuilder.DropTable(
                name: "Continence");

            migrationBuilder.DropTable(
                name: "Depression");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "Fatigue");

            migrationBuilder.DropTable(
                name: "Mobility");

            migrationBuilder.DropTable(
                name: "OpeningQuestion");

            migrationBuilder.DropTable(
                name: "OverallHealth");

            migrationBuilder.DropTable(
                name: "Pain");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PersonalCare");

            migrationBuilder.DropTable(
                name: "Ptsd");

            migrationBuilder.DropTable(
                name: "SocialRole");

            migrationBuilder.DropTable(
                name: "Voice");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
