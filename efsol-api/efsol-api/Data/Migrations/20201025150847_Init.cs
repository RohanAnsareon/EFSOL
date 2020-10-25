using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace efsol_api.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    QuestionId = table.Column<Guid>(nullable: false),
                    UserCode = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "SortOrder", "Type" },
                values: new object[,]
                {
                    { new Guid("6617d1d9-cc53-4c22-b6ea-9cea93dc23b1"), "Name", 1, 0 },
                    { new Guid("b27e744d-581f-4a27-9692-697990e475fd"), "Age", 2, 2 },
                    { new Guid("aaad22ed-31d2-4ab2-8a2b-293e50ab1d66"), "Gender", 3, 1 },
                    { new Guid("32cfb7f5-cdda-4aa8-9f34-fab1fb96c58d"), "Date of birth", 4, 4 },
                    { new Guid("1e75a626-794a-4697-ac19-79b64884b7e4"), "Maritial status", 5, 1 },
                    { new Guid("758204f2-56b8-4628-aa58-c5bced7332e6"), "Do you love programming?", 6, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SortOrder",
                table: "Questions",
                column: "SortOrder",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
