using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoFinancial.Trade.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AlterOrderSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Orders",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "USD");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 50, 27, 417, DateTimeKind.Local).AddTicks(221), "system", "USD", "", new DateTime(2024, 9, 19, 11, 50, 27, 417, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 50, 27, 417, DateTimeKind.Local).AddTicks(264), "system", "USD", "", new DateTime(2024, 9, 19, 11, 50, 27, 417, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 50, 27, 417, DateTimeKind.Local).AddTicks(269), "system", "USD", "", new DateTime(2024, 9, 19, 11, 50, 27, 417, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "Currency", "Text", "TransactTime" },
                values: new object[] { new DateTime(2024, 9, 19, 13, 50, 27, 417, DateTimeKind.Local).AddTicks(273), "system", "USD", "", new DateTime(2024, 9, 19, 11, 50, 27, 417, DateTimeKind.Utc).AddTicks(272) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 9, 19, 11, 26, 30, 105, DateTimeKind.Utc).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 9, 19, 11, 26, 30, 105, DateTimeKind.Utc).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 9, 19, 11, 26, 30, 105, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "CreatedBy", "TransactTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 9, 19, 11, 26, 30, 105, DateTimeKind.Utc).AddTicks(2926) });
        }
    }
}
