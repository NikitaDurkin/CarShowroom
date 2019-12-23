using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShowroom.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    RegistryNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    EngineVolume = table.Column<string>(nullable: true),
                    EnginePower = table.Column<string>(nullable: true),
                    FuelConsumption = table.Column<string>(nullable: true),
                    DoorsNumber = table.Column<string>(nullable: true),
                    SeatsNumber = table.Column<string>(nullable: true),
                    VolumeTrunk = table.Column<string>(nullable: true),
                    AutomaticTransmission = table.Column<bool>(nullable: false),
                    CruiseControl = table.Column<bool>(nullable: false),
                    Fuel = table.Column<string>(nullable: true),
                    Conditioner = table.Column<bool>(nullable: false),
                    Radio = table.Column<bool>(nullable: false),
                    Video = table.Column<bool>(nullable: false),
                    GpsNavigator = table.Column<bool>(nullable: false),
                    Interior = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Milage = table.Column<string>(nullable: true),
                    TO = table.Column<DateTime>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    Client = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    DateTime = table.Column<DateTimeOffset>(nullable: false),
                    Client = table.Column<Guid>(nullable: false),
                    TestDrive = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ClientGuid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientGuid",
                        column: x => x.ClientGuid,
                        principalTable: "Clients",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Guid", "AutomaticTransmission", "Brand", "Client", "Color", "Conditioner", "CruiseControl", "DoorsNumber", "EnginePower", "EngineVolume", "Fuel", "FuelConsumption", "GpsNavigator", "Interior", "Manufacturer", "Milage", "Model", "Price", "Radio", "RegistryNumber", "SeatsNumber", "TO", "Video", "VolumeTrunk" },
                values: new object[,]
                {
                    { new Guid("9edb2ab6-0d09-4ca0-9e45-ed0760ffab32"), true, "Toyota", "Иванов Иван Иванович", "Black", true, true, "5", "167", "2.4", "АИ-95", "12", true, "Leather", "Япония", "200000", "Camry", "600000", true, "А000АА00", "5", new DateTime(2019, 6, 23, 11, 42, 9, 881, DateTimeKind.Local).AddTicks(2638), true, "300" },
                    { new Guid("6bcfee3e-f3b5-4446-90fa-d85bcd583e89"), false, "Mecedes-Benz", "Петров Петр Петрович", "Black", true, true, "5", "345", "5.0", "АИ-95", "20", true, "Leather", "Германия", "200000", "E-classe", "600000", true, "А111АА11", "5", new DateTime(2019, 6, 23, 11, 42, 9, 881, DateTimeKind.Local).AddTicks(8955), true, "300" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientGuid",
                table: "Orders",
                column: "ClientGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
