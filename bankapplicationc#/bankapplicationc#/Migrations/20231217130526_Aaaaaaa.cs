using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bankapplicationc_.Migrations
{
    /// <inheritdoc />
    public partial class Aaaaaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionLogId",
                table: "Transfers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_TransactionLogId",
                table: "Transfers",
                column: "TransactionLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_TransactionLogs_TransactionLogId",
                table: "Transfers",
                column: "TransactionLogId",
                principalTable: "TransactionLogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_TransactionLogs_TransactionLogId",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_TransactionLogId",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "TransactionLogId",
                table: "Transfers");
        }
    }
}
