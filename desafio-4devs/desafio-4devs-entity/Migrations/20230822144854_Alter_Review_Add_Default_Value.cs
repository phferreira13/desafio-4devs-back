using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio_4devs_entity.Migrations
{
    /// <inheritdoc />
    public partial class Alter_Review_Add_Default_Value : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 48, 54, 574, DateTimeKind.Local).AddTicks(223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 10, 49, 52, 738, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 48, 54, 573, DateTimeKind.Local).AddTicks(5803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Organizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 48, 54, 573, DateTimeKind.Local).AddTicks(1433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 10, 49, 52, 737, DateTimeKind.Local).AddTicks(8106));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 10, 49, 52, 738, DateTimeKind.Local).AddTicks(6602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 48, 54, 574, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Review",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 48, 54, 573, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Organizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 10, 49, 52, 737, DateTimeKind.Local).AddTicks(8106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 48, 54, 573, DateTimeKind.Local).AddTicks(1433));
        }
    }
}
