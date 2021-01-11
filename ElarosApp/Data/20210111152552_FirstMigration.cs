using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Data
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivitiesId);
                });

            migrationBuilder.CreateTable(
                name: "Anxiety",
                columns: table => new
                {
                    AnxietyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anxiety", x => x.AnxietyId);
                });

            migrationBuilder.CreateTable(
                name: "Cognition",
                columns: table => new
                {
                    CognitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifficultyConcentrating = table.Column<bool>(type: "bit", nullable: true),
                    ShortTermMemoryEffected = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cognition", x => x.CognitionId);
                });

            migrationBuilder.CreateTable(
                name: "Communication",
                columns: table => new
                {
                    CommunicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifficultyCommunicating = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication", x => x.CommunicationId);
                });

            migrationBuilder.CreateTable(
                name: "Consumption",
                columns: table => new
                {
                    ConsumptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DifficultySwallowing = table.Column<bool>(type: "bit", nullable: true),
                    WeightlossConcern = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumption", x => x.ConsumptionId);
                });

            migrationBuilder.CreateTable(
                name: "Continence",
                columns: table => new
                {
                    ContinenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BowelProblems = table.Column<bool>(type: "bit", nullable: true),
                    BladderProblems = table.Column<bool>(type: "bit", nullable: true),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continence", x => x.ContinenceId);
                });

            migrationBuilder.CreateTable(
                name: "Depression",
                columns: table => new
                {
                    DepressionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depression", x => x.DepressionId);
                });

            migrationBuilder.CreateTable(
                name: "Fatigue",
                columns: table => new
                {
                    FatigueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatigue", x => x.FatigueId);
                });

            migrationBuilder.CreateTable(
                name: "Mobility",
                columns: table => new
                {
                    MobilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobility", x => x.MobilityId);
                });

            migrationBuilder.CreateTable(
                name: "Pain",
                columns: table => new
                {
                    PainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewPain = table.Column<bool>(type: "bit", nullable: true),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pain", x => x.PainId);
                });

            migrationBuilder.CreateTable(
                name: "PersonalCare",
                columns: table => new
                {
                    PersonalCareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalCare", x => x.PersonalCareId);
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
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ptsd", x => x.PtsdId);
                });

            migrationBuilder.CreateTable(
                name: "SocialRole",
                columns: table => new
                {
                    SocialRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcovid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialRole", x => x.SocialRoleId);
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
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voice", x => x.VoiceId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivitiesId = table.Column<int>(type: "int", nullable: false),
                    AnxietyId = table.Column<int>(type: "int", nullable: false),
                    CognitionId = table.Column<int>(type: "int", nullable: false),
                    CommunicationId = table.Column<int>(type: "int", nullable: false),
                    ConsumptionId = table.Column<int>(type: "int", nullable: false),
                    ContinenceId = table.Column<int>(type: "int", nullable: false),
                    DepressionId = table.Column<int>(type: "int", nullable: false),
                    FatigueId = table.Column<int>(type: "int", nullable: false),
                    MobilityId = table.Column<int>(type: "int", nullable: false),
                    PainId = table.Column<int>(type: "int", nullable: false),
                    PersonalCareId = table.Column<int>(type: "int", nullable: false),
                    PtsdId = table.Column<int>(type: "int", nullable: false),
                    SocialRoleId = table.Column<int>(type: "int", nullable: false),
                    VoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "ActivitiesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Anxiety_AnxietyId",
                        column: x => x.AnxietyId,
                        principalTable: "Anxiety",
                        principalColumn: "AnxietyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Cognition_CognitionId",
                        column: x => x.CognitionId,
                        principalTable: "Cognition",
                        principalColumn: "CognitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Communication_CommunicationId",
                        column: x => x.CommunicationId,
                        principalTable: "Communication",
                        principalColumn: "CommunicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Consumption_ConsumptionId",
                        column: x => x.ConsumptionId,
                        principalTable: "Consumption",
                        principalColumn: "ConsumptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Continence_ContinenceId",
                        column: x => x.ContinenceId,
                        principalTable: "Continence",
                        principalColumn: "ContinenceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Depression_DepressionId",
                        column: x => x.DepressionId,
                        principalTable: "Depression",
                        principalColumn: "DepressionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Fatigue_FatigueId",
                        column: x => x.FatigueId,
                        principalTable: "Fatigue",
                        principalColumn: "FatigueId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Mobility_MobilityId",
                        column: x => x.MobilityId,
                        principalTable: "Mobility",
                        principalColumn: "MobilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Pain_PainId",
                        column: x => x.PainId,
                        principalTable: "Pain",
                        principalColumn: "PainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_PersonalCare_PersonalCareId",
                        column: x => x.PersonalCareId,
                        principalTable: "PersonalCare",
                        principalColumn: "PersonalCareId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Ptsd_PtsdId",
                        column: x => x.PtsdId,
                        principalTable: "Ptsd",
                        principalColumn: "PtsdId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_SocialRole_SocialRoleId",
                        column: x => x.SocialRoleId,
                        principalTable: "SocialRole",
                        principalColumn: "SocialRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Voice_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "Voice",
                        principalColumn: "VoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentQuestionQuestionId = table.Column<int>(type: "int", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Questions_CurrentQuestionQuestionId",
                        column: x => x.CurrentQuestionQuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CurrentQuestionQuestionId",
                table: "Patients",
                column: "CurrentQuestionQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ActivitiesId",
                table: "Questions",
                column: "ActivitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnxietyId",
                table: "Questions",
                column: "AnxietyId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CognitionId",
                table: "Questions",
                column: "CognitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CommunicationId",
                table: "Questions",
                column: "CommunicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ConsumptionId",
                table: "Questions",
                column: "ConsumptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ContinenceId",
                table: "Questions",
                column: "ContinenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_DepressionId",
                table: "Questions",
                column: "DepressionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_FatigueId",
                table: "Questions",
                column: "FatigueId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_MobilityId",
                table: "Questions",
                column: "MobilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_PainId",
                table: "Questions",
                column: "PainId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_PersonalCareId",
                table: "Questions",
                column: "PersonalCareId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_PtsdId",
                table: "Questions",
                column: "PtsdId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SocialRoleId",
                table: "Questions",
                column: "SocialRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_VoiceId",
                table: "Questions",
                column: "VoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Anxiety");

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
                name: "Fatigue");

            migrationBuilder.DropTable(
                name: "Mobility");

            migrationBuilder.DropTable(
                name: "Pain");

            migrationBuilder.DropTable(
                name: "PersonalCare");

            migrationBuilder.DropTable(
                name: "Ptsd");

            migrationBuilder.DropTable(
                name: "SocialRole");

            migrationBuilder.DropTable(
                name: "Voice");
        }
    }
}
