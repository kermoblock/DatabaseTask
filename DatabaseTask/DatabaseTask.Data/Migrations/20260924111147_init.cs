using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Difficulty_Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prison",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Maxiumum_Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prison", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Punishment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Punishment_Type = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punishment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Personal_Number = table.Column<int>(type: "int", nullable: false),
                    Telphone_Number = table.Column<int>(type: "int", nullable: false),
                    Relation_To_The_Prisoner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Security_Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Block_Prison_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prison",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Building_Prison_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prison",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrisonId = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Worker_Number = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guards_Prison_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prison",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chamber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Maxiumum_Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamber_Block_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuardsId = table.Column<int>(type: "int", nullable: false),
                    Start_time = table.Column<int>(type: "int", nullable: false),
                    Finish_time = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shift_Guards_GuardsId",
                        column: x => x.GuardsId,
                        principalTable: "Guards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prisoners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChamberId = table.Column<int>(type: "int", nullable: false),
                    PunishmentId = table.Column<int>(type: "int", nullable: false),
                    CrimeId = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Personal_Number = table.Column<int>(type: "int", nullable: false),
                    Arrival_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prisoner_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisoners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prisoners_Chamber_ChamberId",
                        column: x => x.ChamberId,
                        principalTable: "Chamber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prisoners_Crime_CrimeId",
                        column: x => x.CrimeId,
                        principalTable: "Crime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prisoners_Punishment_PunishmentId",
                        column: x => x.PunishmentId,
                        principalTable: "Punishment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorsId = table.Column<int>(type: "int", nullable: false),
                    PrisonersId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start_Time = table.Column<int>(type: "int", nullable: false),
                    Finish_Time = table.Column<int>(type: "int", nullable: false),
                    Visiting_Status = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visit_Prisoners_PrisonersId",
                        column: x => x.PrisonersId,
                        principalTable: "Prisoners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visit_Visitors_VisitorsId",
                        column: x => x.VisitorsId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Block_PrisonId",
                table: "Block",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_PrisonId",
                table: "Building",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamber_BlockId",
                table: "Chamber",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_PrisonId",
                table: "Guards",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_ChamberId",
                table: "Prisoners",
                column: "ChamberId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_CrimeId",
                table: "Prisoners",
                column: "CrimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_PunishmentId",
                table: "Prisoners",
                column: "PunishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_GuardsId",
                table: "Shift",
                column: "GuardsId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PrisonersId",
                table: "Visit",
                column: "PrisonersId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_VisitorsId",
                table: "Visit",
                column: "VisitorsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Shift");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Guards");

            migrationBuilder.DropTable(
                name: "Prisoners");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Chamber");

            migrationBuilder.DropTable(
                name: "Crime");

            migrationBuilder.DropTable(
                name: "Punishment");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Prison");
        }
    }
}
