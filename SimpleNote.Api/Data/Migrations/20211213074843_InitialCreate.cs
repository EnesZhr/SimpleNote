using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleNote.Api.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Time", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet,consectetur adipiscing elit.", new DateTime(2021, 12, 13, 10, 48, 43, 388, DateTimeKind.Local).AddTicks(6422), "Sample Note 1" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Time", "Title" },
                values: new object[] { 2, "Lorem ipsum dolor sit amet,consectetur adipiscing elit.", new DateTime(2021, 12, 13, 10, 48, 43, 390, DateTimeKind.Local).AddTicks(623), "Sample Note 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
