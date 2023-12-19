using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bankapplicationc_.Migrations
{
    /// <inheritdoc />
    public partial class Tahir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_TransactionLogs_TransactionLogId1",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_TransactionLogId1",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "TransactionLogId1",
                table: "Transfers");

            migrationBuilder.AddColumn<int>(
                name: "TransferID",
                table: "TransactionLogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransferID",
                table: "TransactionLogs",
                column: "TransferID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLogs_Transfers_TransferID",
                table: "TransactionLogs",
                column: "TransferID",
                principalTable: "Transfers",
                principalColumn: "TransferID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLogs_Transfers_TransferID",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_TransferID",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransferID",
                table: "TransactionLogs");

            migrationBuilder.AddColumn<int>(
                name: "TransactionLogId1",
                table: "Transfers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_TransactionLogId1",
                table: "Transfers",
                column: "TransactionLogId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_TransactionLogs_TransactionLogId1",
                table: "Transfers",
                column: "TransactionLogId1",
                principalTable: "TransactionLogs",
                principalColumn: "Id");
        }
    }
}
