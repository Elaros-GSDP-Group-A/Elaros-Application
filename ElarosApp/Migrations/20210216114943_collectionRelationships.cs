using Microsoft.EntityFrameworkCore.Migrations;

namespace ElarosApp.Migrations
{
    public partial class collectionRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Activities_ActivitiesId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Anxiety_AnxietyId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Breathlessness_BreathlessnessId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Cognition_CognitionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Communication_CommunicationId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Consumption_ConsumptionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Continence_ContinenceId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Depression_DepressionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Employment_EmploymentActivitiesId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Fatigue_FatigueId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Mobility_MobilityId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_OpeningQuestion_OpeningQuestionId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_OverallHealth_OverallHealthId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Pain_PainId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_PersonalCare_PersonalCareId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Ptsd_PtsdId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_SocialRole_SocialRoleId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Voice_VoiceId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ActivitiesId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_AnxietyId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_BreathlessnessId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CognitionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CommunicationId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ConsumptionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ContinenceId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_DepressionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_EmploymentActivitiesId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_FatigueId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_MobilityId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_OpeningQuestionId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_OverallHealthId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_PainId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_PersonalCareId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_PtsdId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_SocialRoleId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_VoiceId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "EmploymentActivitiesId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "OverallHealthId",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Voice",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "SocialRole",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Ptsd",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "PersonalCare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Pain",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "OverallHealth",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "OpeningQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Mobility",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Fatigue",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Employment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Depression",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Continence",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Consumption",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Communication",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Cognition",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Breathlessness",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Anxiety",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelQuestionId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Voice_QuestionModelQuestionId",
                table: "Voice",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialRole_QuestionModelQuestionId",
                table: "SocialRole",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ptsd_QuestionModelQuestionId",
                table: "Ptsd",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalCare_QuestionModelQuestionId",
                table: "PersonalCare",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pain_QuestionModelQuestionId",
                table: "Pain",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_OverallHealth_QuestionModelQuestionId",
                table: "OverallHealth",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningQuestion_QuestionModelQuestionId",
                table: "OpeningQuestion",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mobility_QuestionModelQuestionId",
                table: "Mobility",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Fatigue_QuestionModelQuestionId",
                table: "Fatigue",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_QuestionModelQuestionId",
                table: "Employment",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Depression_QuestionModelQuestionId",
                table: "Depression",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Continence_QuestionModelQuestionId",
                table: "Continence",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumption_QuestionModelQuestionId",
                table: "Consumption",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Communication_QuestionModelQuestionId",
                table: "Communication",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cognition_QuestionModelQuestionId",
                table: "Cognition",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Breathlessness_QuestionModelQuestionId",
                table: "Breathlessness",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Anxiety_QuestionModelQuestionId",
                table: "Anxiety",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_QuestionModelQuestionId",
                table: "Activities",
                column: "QuestionModelQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Questions_QuestionModelQuestionId",
                table: "Activities",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Anxiety_Questions_QuestionModelQuestionId",
                table: "Anxiety",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breathlessness_Questions_QuestionModelQuestionId",
                table: "Breathlessness",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cognition_Questions_QuestionModelQuestionId",
                table: "Cognition",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Communication_Questions_QuestionModelQuestionId",
                table: "Communication",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consumption_Questions_QuestionModelQuestionId",
                table: "Consumption",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Continence_Questions_QuestionModelQuestionId",
                table: "Continence",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Depression_Questions_QuestionModelQuestionId",
                table: "Depression",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_Questions_QuestionModelQuestionId",
                table: "Employment",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fatigue_Questions_QuestionModelQuestionId",
                table: "Fatigue",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mobility_Questions_QuestionModelQuestionId",
                table: "Mobility",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningQuestion_Questions_QuestionModelQuestionId",
                table: "OpeningQuestion",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OverallHealth_Questions_QuestionModelQuestionId",
                table: "OverallHealth",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pain_Questions_QuestionModelQuestionId",
                table: "Pain",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalCare_Questions_QuestionModelQuestionId",
                table: "PersonalCare",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ptsd_Questions_QuestionModelQuestionId",
                table: "Ptsd",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialRole_Questions_QuestionModelQuestionId",
                table: "SocialRole",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Voice_Questions_QuestionModelQuestionId",
                table: "Voice",
                column: "QuestionModelQuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Questions_QuestionModelQuestionId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Anxiety_Questions_QuestionModelQuestionId",
                table: "Anxiety");

            migrationBuilder.DropForeignKey(
                name: "FK_Breathlessness_Questions_QuestionModelQuestionId",
                table: "Breathlessness");

            migrationBuilder.DropForeignKey(
                name: "FK_Cognition_Questions_QuestionModelQuestionId",
                table: "Cognition");

            migrationBuilder.DropForeignKey(
                name: "FK_Communication_Questions_QuestionModelQuestionId",
                table: "Communication");

            migrationBuilder.DropForeignKey(
                name: "FK_Consumption_Questions_QuestionModelQuestionId",
                table: "Consumption");

            migrationBuilder.DropForeignKey(
                name: "FK_Continence_Questions_QuestionModelQuestionId",
                table: "Continence");

            migrationBuilder.DropForeignKey(
                name: "FK_Depression_Questions_QuestionModelQuestionId",
                table: "Depression");

            migrationBuilder.DropForeignKey(
                name: "FK_Employment_Questions_QuestionModelQuestionId",
                table: "Employment");

            migrationBuilder.DropForeignKey(
                name: "FK_Fatigue_Questions_QuestionModelQuestionId",
                table: "Fatigue");

            migrationBuilder.DropForeignKey(
                name: "FK_Mobility_Questions_QuestionModelQuestionId",
                table: "Mobility");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningQuestion_Questions_QuestionModelQuestionId",
                table: "OpeningQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_OverallHealth_Questions_QuestionModelQuestionId",
                table: "OverallHealth");

            migrationBuilder.DropForeignKey(
                name: "FK_Pain_Questions_QuestionModelQuestionId",
                table: "Pain");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalCare_Questions_QuestionModelQuestionId",
                table: "PersonalCare");

            migrationBuilder.DropForeignKey(
                name: "FK_Ptsd_Questions_QuestionModelQuestionId",
                table: "Ptsd");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialRole_Questions_QuestionModelQuestionId",
                table: "SocialRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Voice_Questions_QuestionModelQuestionId",
                table: "Voice");

            migrationBuilder.DropIndex(
                name: "IX_Voice_QuestionModelQuestionId",
                table: "Voice");

            migrationBuilder.DropIndex(
                name: "IX_SocialRole_QuestionModelQuestionId",
                table: "SocialRole");

            migrationBuilder.DropIndex(
                name: "IX_Ptsd_QuestionModelQuestionId",
                table: "Ptsd");

            migrationBuilder.DropIndex(
                name: "IX_PersonalCare_QuestionModelQuestionId",
                table: "PersonalCare");

            migrationBuilder.DropIndex(
                name: "IX_Pain_QuestionModelQuestionId",
                table: "Pain");

            migrationBuilder.DropIndex(
                name: "IX_OverallHealth_QuestionModelQuestionId",
                table: "OverallHealth");

            migrationBuilder.DropIndex(
                name: "IX_OpeningQuestion_QuestionModelQuestionId",
                table: "OpeningQuestion");

            migrationBuilder.DropIndex(
                name: "IX_Mobility_QuestionModelQuestionId",
                table: "Mobility");

            migrationBuilder.DropIndex(
                name: "IX_Fatigue_QuestionModelQuestionId",
                table: "Fatigue");

            migrationBuilder.DropIndex(
                name: "IX_Employment_QuestionModelQuestionId",
                table: "Employment");

            migrationBuilder.DropIndex(
                name: "IX_Depression_QuestionModelQuestionId",
                table: "Depression");

            migrationBuilder.DropIndex(
                name: "IX_Continence_QuestionModelQuestionId",
                table: "Continence");

            migrationBuilder.DropIndex(
                name: "IX_Consumption_QuestionModelQuestionId",
                table: "Consumption");

            migrationBuilder.DropIndex(
                name: "IX_Communication_QuestionModelQuestionId",
                table: "Communication");

            migrationBuilder.DropIndex(
                name: "IX_Cognition_QuestionModelQuestionId",
                table: "Cognition");

            migrationBuilder.DropIndex(
                name: "IX_Breathlessness_QuestionModelQuestionId",
                table: "Breathlessness");

            migrationBuilder.DropIndex(
                name: "IX_Anxiety_QuestionModelQuestionId",
                table: "Anxiety");

            migrationBuilder.DropIndex(
                name: "IX_Activities_QuestionModelQuestionId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Voice");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "SocialRole");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Ptsd");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "PersonalCare");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Pain");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "OverallHealth");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "OpeningQuestion");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Mobility");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Fatigue");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Depression");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Continence");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Consumption");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Communication");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Cognition");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Breathlessness");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Anxiety");

            migrationBuilder.DropColumn(
                name: "QuestionModelQuestionId",
                table: "Activities");

            migrationBuilder.AddColumn<int>(
                name: "EmploymentActivitiesId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OverallHealthId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ActivitiesId",
                table: "Questions",
                column: "ActivitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnxietyId",
                table: "Questions",
                column: "AnxietyId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_BreathlessnessId",
                table: "Questions",
                column: "BreathlessnessId");

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
                name: "IX_Questions_EmploymentActivitiesId",
                table: "Questions",
                column: "EmploymentActivitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_FatigueId",
                table: "Questions",
                column: "FatigueId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_MobilityId",
                table: "Questions",
                column: "MobilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_OpeningQuestionId",
                table: "Questions",
                column: "OpeningQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_OverallHealthId",
                table: "Questions",
                column: "OverallHealthId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Activities_ActivitiesId",
                table: "Questions",
                column: "ActivitiesId",
                principalTable: "Activities",
                principalColumn: "ActivitiesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Anxiety_AnxietyId",
                table: "Questions",
                column: "AnxietyId",
                principalTable: "Anxiety",
                principalColumn: "AnxietyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Breathlessness_BreathlessnessId",
                table: "Questions",
                column: "BreathlessnessId",
                principalTable: "Breathlessness",
                principalColumn: "BreathlessnessId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Cognition_CognitionId",
                table: "Questions",
                column: "CognitionId",
                principalTable: "Cognition",
                principalColumn: "CognitionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Communication_CommunicationId",
                table: "Questions",
                column: "CommunicationId",
                principalTable: "Communication",
                principalColumn: "CommunicationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Consumption_ConsumptionId",
                table: "Questions",
                column: "ConsumptionId",
                principalTable: "Consumption",
                principalColumn: "ConsumptionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Continence_ContinenceId",
                table: "Questions",
                column: "ContinenceId",
                principalTable: "Continence",
                principalColumn: "ContinenceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Depression_DepressionId",
                table: "Questions",
                column: "DepressionId",
                principalTable: "Depression",
                principalColumn: "DepressionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Employment_EmploymentActivitiesId",
                table: "Questions",
                column: "EmploymentActivitiesId",
                principalTable: "Employment",
                principalColumn: "ActivitiesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Fatigue_FatigueId",
                table: "Questions",
                column: "FatigueId",
                principalTable: "Fatigue",
                principalColumn: "FatigueId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Mobility_MobilityId",
                table: "Questions",
                column: "MobilityId",
                principalTable: "Mobility",
                principalColumn: "MobilityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_OpeningQuestion_OpeningQuestionId",
                table: "Questions",
                column: "OpeningQuestionId",
                principalTable: "OpeningQuestion",
                principalColumn: "OpeningQuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_OverallHealth_OverallHealthId",
                table: "Questions",
                column: "OverallHealthId",
                principalTable: "OverallHealth",
                principalColumn: "OverallHealthId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Pain_PainId",
                table: "Questions",
                column: "PainId",
                principalTable: "Pain",
                principalColumn: "PainId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_PersonalCare_PersonalCareId",
                table: "Questions",
                column: "PersonalCareId",
                principalTable: "PersonalCare",
                principalColumn: "PersonalCareId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Ptsd_PtsdId",
                table: "Questions",
                column: "PtsdId",
                principalTable: "Ptsd",
                principalColumn: "PtsdId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_SocialRole_SocialRoleId",
                table: "Questions",
                column: "SocialRoleId",
                principalTable: "SocialRole",
                principalColumn: "SocialRoleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Voice_VoiceId",
                table: "Questions",
                column: "VoiceId",
                principalTable: "Voice",
                principalColumn: "VoiceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
