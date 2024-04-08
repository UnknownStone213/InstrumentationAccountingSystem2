using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstrumentationAccountingSystem2.Migrations
{
    /// <inheritdoc />
    public partial class TypeCanBeNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instrumentations_Types_TypeId",
                table: "Instrumentations");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Instrumentations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Instrumentations_Types_TypeId",
                table: "Instrumentations",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instrumentations_Types_TypeId",
                table: "Instrumentations");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Instrumentations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrumentations_Types_TypeId",
                table: "Instrumentations",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
