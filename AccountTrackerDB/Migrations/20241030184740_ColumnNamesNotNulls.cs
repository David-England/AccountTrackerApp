using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountTrackerDB.Migrations
{
    /// <inheritdoc />
    public partial class ColumnNamesNotNulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "TransactionPersistences",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TransactionPersistences",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "TransactionPersistences",
                newName: "transaction_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccountPersistences",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CurrentValue",
                table: "AccountPersistences",
                newName: "current_value");

            migrationBuilder.RenameColumn(
                name: "AccountName",
                table: "AccountPersistences",
                newName: "account_name");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "AccountPersistences",
                newName: "account_id");

            migrationBuilder.RenameColumn(
                name: "AccountHolderName",
                table: "AccountPersistences",
                newName: "account_holder_name");

            migrationBuilder.AlterColumn<string>(
                name: "transaction_id",
                table: "TransactionPersistences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "account_name",
                table: "AccountPersistences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "account_id",
                table: "AccountPersistences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "account_holder_name",
                table: "AccountPersistences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "amount",
                table: "TransactionPersistences",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TransactionPersistences",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "transaction_id",
                table: "TransactionPersistences",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AccountPersistences",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "current_value",
                table: "AccountPersistences",
                newName: "CurrentValue");

            migrationBuilder.RenameColumn(
                name: "account_name",
                table: "AccountPersistences",
                newName: "AccountName");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "AccountPersistences",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "account_holder_name",
                table: "AccountPersistences",
                newName: "AccountHolderName");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "TransactionPersistences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountName",
                table: "AccountPersistences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                table: "AccountPersistences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountHolderName",
                table: "AccountPersistences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
