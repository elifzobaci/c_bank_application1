using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bankapplicationc_.Migrations
{
    /// <inheritdoc />
    public partial class Bbbbbbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountID",
                table: "TransactionLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "TransactionLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransferID",
                table: "TransactionLogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_AccountID",
                table: "TransactionLogs",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_CustomerID",
                table: "TransactionLogs",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransferID",
                table: "TransactionLogs",
                column: "TransferID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLogs_Accounts_AccountID",
                table: "TransactionLogs",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLogs_Customers_CustomerID",
                table: "TransactionLogs",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_TransactionLogs_Accounts_AccountID",
                table: "TransactionLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLogs_Customers_CustomerID",
                table: "TransactionLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLogs_Transfers_TransferID",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_AccountID",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_CustomerID",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_TransferID",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransferID",
                table: "TransactionLogs");
        }
    }
}
