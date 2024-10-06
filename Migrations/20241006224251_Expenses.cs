using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Budget.Migrations
{
    /// <inheritdoc />
    public partial class Expenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PaymentFrequency",
                table: "RecurringExpense",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "RecurringExpense",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecurringExpense_CategoryId",
                table: "RecurringExpense",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecurringExpense_Category_CategoryId",
                table: "RecurringExpense",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecurringExpense_Category_CategoryId",
                table: "RecurringExpense");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_RecurringExpense_CategoryId",
                table: "RecurringExpense");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "RecurringExpense");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentFrequency",
                table: "RecurringExpense",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
