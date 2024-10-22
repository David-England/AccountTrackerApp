using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountTrackerDB.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountPersistences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountHolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountPersistences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionPersistences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceAccountId = table.Column<int>(type: "int", nullable: true),
                    TargetAccountId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionPersistences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionPersistences_AccountPersistences_SourceAccountId",
                        column: x => x.SourceAccountId,
                        principalTable: "AccountPersistences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransactionPersistences_AccountPersistences_TargetAccountId",
                        column: x => x.TargetAccountId,
                        principalTable: "AccountPersistences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionPersistences_SourceAccountId",
                table: "TransactionPersistences",
                column: "SourceAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionPersistences_TargetAccountId",
                table: "TransactionPersistences",
                column: "TargetAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionPersistences");

            migrationBuilder.DropTable(
                name: "AccountPersistences");
        }
    }
}
