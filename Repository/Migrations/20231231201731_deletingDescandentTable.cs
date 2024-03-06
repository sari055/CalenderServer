using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class deletingDescandentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecialDate_Descendant_DescendantId",
                table: "SpecialDate");

            migrationBuilder.DropTable(
                name: "Descendant");

            migrationBuilder.DropIndex(
                name: "IX_SpecialDate_DescendantId",
                table: "SpecialDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descendant",
                columns: table => new
                {
                    DescendantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    FatherId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherId = table.Column<int>(type: "int", nullable: false),
                    SpouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descendant", x => x.DescendantId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecialDate_DescendantId",
                table: "SpecialDate",
                column: "DescendantId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecialDate_Descendant_DescendantId",
                table: "SpecialDate",
                column: "DescendantId",
                principalTable: "Descendant",
                principalColumn: "DescendantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
