using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.API.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Body = table.Column<string>(maxLength: 280, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body" },
                values: new object[] { new Guid("b5c3e2e2-beb2-4178-bb63-c0a749860fb1"), "It was a bright cold day in April, and the clocks were striking thirteen" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body" },
                values: new object[] { new Guid("12d50335-25c5-422a-b010-fbfc7726ef9a"), "It was the best of times, it was the worst of times" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body" },
                values: new object[] { new Guid("637eda53-dc77-4650-b390-3eefd42c75bf"), "I'll tell you what I want, what I really, really want" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
