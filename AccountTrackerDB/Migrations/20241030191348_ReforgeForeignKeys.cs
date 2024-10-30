using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountTrackerDB.Migrations
{
    /// <inheritdoc />
    public partial class ReforgeForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_SourceAccountId",
                table: "TransactionPersistences");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_TargetAccountId",
                table: "TransactionPersistences");

            migrationBuilder.DropIndex(
                name: "IX_TransactionPersistences_SourceAccountId",
                table: "TransactionPersistences");

            migrationBuilder.DropIndex(
                name: "IX_TransactionPersistences_TargetAccountId",
                table: "TransactionPersistences");

            migrationBuilder.DropColumn(
                name: "SourceAccountId",
                table: "TransactionPersistences");

            migrationBuilder.DropColumn(
                name: "TargetAccountId",
                table: "TransactionPersistences");

            migrationBuilder.AddColumn<int>(
                name: "source_account_id",
                table: "TransactionPersistences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "target_account_id",
                table: "TransactionPersistences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionPersistences_source_account_id",
                table: "TransactionPersistences",
                column: "source_account_id");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionPersistences_target_account_id",
                table: "TransactionPersistences",
                column: "target_account_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_source_account_id",
                table: "TransactionPersistences",
                column: "source_account_id",
                principalTable: "AccountPersistences",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_target_account_id",
                table: "TransactionPersistences",
                column: "target_account_id",
                principalTable: "AccountPersistences",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_source_account_id",
                table: "TransactionPersistences");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_target_account_id",
                table: "TransactionPersistences");

            migrationBuilder.DropIndex(
                name: "IX_TransactionPersistences_source_account_id",
                table: "TransactionPersistences");

            migrationBuilder.DropIndex(
                name: "IX_TransactionPersistences_target_account_id",
                table: "TransactionPersistences");

            migrationBuilder.DropColumn(
                name: "source_account_id",
                table: "TransactionPersistences");

            migrationBuilder.DropColumn(
                name: "target_account_id",
                table: "TransactionPersistences");

            migrationBuilder.AddColumn<int>(
                name: "SourceAccountId",
                table: "TransactionPersistences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetAccountId",
                table: "TransactionPersistences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionPersistences_SourceAccountId",
                table: "TransactionPersistences",
                column: "SourceAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionPersistences_TargetAccountId",
                table: "TransactionPersistences",
                column: "TargetAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_SourceAccountId",
                table: "TransactionPersistences",
                column: "SourceAccountId",
                principalTable: "AccountPersistences",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionPersistences_AccountPersistences_TargetAccountId",
                table: "TransactionPersistences",
                column: "TargetAccountId",
                principalTable: "AccountPersistences",
                principalColumn: "id");
        }
    }
}
