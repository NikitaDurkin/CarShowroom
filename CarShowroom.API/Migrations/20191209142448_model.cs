using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShowroom.API.Migrations
{
    public partial class model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VolumeTrunk",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "SeatsNumber",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FuelConsumption",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "EngineVolume",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "EnginePower",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "DoorsNumber",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Guid", "AutomaticTransmission", "Brand", "Client", "Color", "Conditioner", "CruiseControl", "DoorsNumber", "EnginePower", "EngineVolume", "Fuel", "FuelConsumption", "GpsNavigator", "Interior", "Manufacturer", "Milage", "Model", "Price", "Radio", "RegistryNumber", "SeatsNumber", "TO", "Video", "VolumeTrunk" },
                values: new object[,]
                {
                    { new Guid("05f2193b-a72a-4d84-b80c-52bb1d60d8d1"), true, "Toyota", "Иванов Иван Иванович", "Black", true, true, "5", "167", "2.4", "АИ-95", "12", true, "Leather", "Япония", "200000", "Camry", "600000", true, "А000АА00", "5", new DateTime(2019, 6, 9, 17, 24, 48, 4, DateTimeKind.Local).AddTicks(3699), true, "300" },
                    { new Guid("046e6f37-ef7e-4117-be56-03ec7d516212"), true, "Mecedes-Benz", "Петров Петр Петрович", "Black", true, true, "5", "345", "5.0", "АИ-95", "20", true, "Leather", "Германия", "200000", "E-classe", "600000", true, "А111АА11", "5", new DateTime(2019, 6, 9, 17, 24, 48, 5, DateTimeKind.Local).AddTicks(1309), true, "300" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Guid",
                keyValue: new Guid("046e6f37-ef7e-4117-be56-03ec7d516212"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Guid",
                keyValue: new Guid("05f2193b-a72a-4d84-b80c-52bb1d60d8d1"));

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "VolumeTrunk",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SeatsNumber",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "FuelConsumption",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "EngineVolume",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "EnginePower",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoorsNumber",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
