using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MQTT_WinForms.Migrations
{
    /// <inheritdoc />
    public partial class subscriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topic",
                table: "Connections");

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Topic = table.Column<string>(type: "TEXT", nullable: false),
                    QualityOfService = table.Column<int>(type: "INTEGER", nullable: false),
                    ConnectionID = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Connections_ConnectionID",
                        column: x => x.ConnectionID,
                        principalTable: "Connections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_ConnectionID",
                table: "Subscriptions",
                column: "ConnectionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "Connections",
                type: "TEXT",
                nullable: true);
        }
    }
}
