using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixPartMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_register_Part_PartId",
                table: "tb_register");

            migrationBuilder.RenameTable(
                name: "Part",
                newName: "tb_part");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tb_part",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "tb_part",
                newName: "serialnumber");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_part",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "serialnumber",
                table: "tb_part",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_register_tb_part_PartId",
                table: "tb_register",
                column: "PartId",
                principalTable: "tb_part",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_register_tb_part_PartId",
                table: "tb_register");

            migrationBuilder.RenameTable(
                name: "tb_part",
                newName: "Part");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Part",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "serialnumber",
                table: "Part",
                newName: "SerialNumber");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Part",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber",
                table: "Part",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_register_Part_PartId",
                table: "tb_register",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
