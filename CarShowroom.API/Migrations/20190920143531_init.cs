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
                    Manufacturer = table.Column<string>(nullable: true),
                    EngineVolume = table.Column<float>(nullable: false),
                    EnginePower = table.Column<float>(nullable: false),
                    FuelConsumption = table.Column<float>(nullable: false),
                    DoorsNumber = table.Column<int>(nullable: false),
                    SeatsNumber = table.Column<int>(nullable: false),
                    VolumeTrunk = table.Column<int>(nullable: false),
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
                    DateTime = table.Column<DateTime>(nullable: false),
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
