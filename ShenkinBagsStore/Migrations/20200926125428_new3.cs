using Microsoft.EntityFrameworkCore.Migrations;

namespace ShenkinBagsStore.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalTransactionId",
                table: "Transactions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalTransactionsID",
                table: "Transactions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TotalTransactionss",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalTransactionss", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TotalTransactionss_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TotalTransactionsID",
                table: "Transactions",
                column: "TotalTransactionsID");

            migrationBuilder.CreateIndex(
                name: "IX_TotalTransactionss_UserID",
                table: "TotalTransactionss",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_TotalTransactionss_TotalTransactionsID",
                table: "Transactions",
                column: "TotalTransactionsID",
                principalTable: "TotalTransactionss",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_TotalTransactionss_TotalTransactionsID",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "TotalTransactionss");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_TotalTransactionsID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TotalTransactionId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TotalTransactionsID",
                table: "Transactions");
        }
    }
}
