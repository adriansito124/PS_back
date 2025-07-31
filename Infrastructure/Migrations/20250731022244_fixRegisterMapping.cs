using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixRegisterMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_register_tb_part_PartId",
                table: "tb_register");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "tb_register",
                newName: "datetime");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "tb_register",
                newName: "part_id");

            migrationBuilder.RenameIndex(
                name: "IX_tb_register_PartId",
                table: "tb_register",
                newName: "IX_tb_register_part_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_register_tb_part_part_id",
                table: "tb_register",
                column: "part_id",
                principalTable: "tb_part",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_register_tb_part_part_id",
                table: "tb_register");

            migrationBuilder.RenameColumn(
                name: "datetime",
                table: "tb_register",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "part_id",
                table: "tb_register",
                newName: "PartId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_register_part_id",
                table: "tb_register",
                newName: "IX_tb_register_PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_register_tb_part_PartId",
                table: "tb_register",
                column: "PartId",
                principalTable: "tb_part",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
