using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MQTT_WinForms.Migrations
{
    /// <inheritdoc />
    public partial class updatemessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ConnectionID",
                table: "Messages",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "MessageText",
                table: "Messages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "Messages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ConnectionID",
                table: "Messages",
                column: "ConnectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Connections_ConnectionID",
                table: "Messages",
                column: "ConnectionID",
                principalTable: "Connections",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Connections_ConnectionID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ConnectionID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ConnectionID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageText",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Topic",
                table: "Messages");
        }
    }
}
