using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MQTT_WinForms.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Connections_ConnectionID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ConnectionID",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ConnectionID",
                table: "Messages",
                newName: "ClientID");

            migrationBuilder.AddColumn<int>(
                name: "Direction",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QoSLevel",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direction",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "QoSLevel",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Messages",
                newName: "ConnectionID");

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
    }
}
