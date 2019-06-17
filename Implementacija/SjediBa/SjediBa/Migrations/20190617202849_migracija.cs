using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SjediBa.Migrations
{
    public partial class migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorModelId);
                });

            migrationBuilder.CreateTable(
                name: "Organizer",
                columns: table => new
                {
                    OrganizerModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizer", x => x.OrganizerModelId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserModelId);
                });

            migrationBuilder.CreateTable(
                name: "Space",
                columns: table => new
                {
                    SpaceModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    LocalAdministratorModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Space", x => x.SpaceModelId);
                    table.ForeignKey(
                        name: "FK_Space_Administrator_LocalAdministratorModelId",
                        column: x => x.LocalAdministratorModelId,
                        principalTable: "Administrator",
                        principalColumn: "AdministratorModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Notification = table.Column<string>(nullable: true),
                    RegisteredUserModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationModelId);
                    table.ForeignKey(
                        name: "FK_Notification_User_RegisteredUserModelId",
                        column: x => x.RegisteredUserModelId,
                        principalTable: "User",
                        principalColumn: "UserModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    OrganizerModelId = table.Column<int>(nullable: false),
                    SpaceModelId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventModelId);
                    table.ForeignKey(
                        name: "FK_Event_Organizer_OrganizerModelId",
                        column: x => x.OrganizerModelId,
                        principalTable: "Organizer",
                        principalColumn: "OrganizerModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Space_SpaceModelId",
                        column: x => x.SpaceModelId,
                        principalTable: "Space",
                        principalColumn: "SpaceModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpaceModelId = table.Column<int>(nullable: false),
                    SeatPrices = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionModelId);
                    table.ForeignKey(
                        name: "FK_Section_Space_SpaceModelId",
                        column: x => x.SpaceModelId,
                        principalTable: "Space",
                        principalColumn: "SpaceModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    SeatModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SectionModelId = table.Column<int>(nullable: false),
                    RowSeat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.SeatModelId);
                    table.ForeignKey(
                        name: "FK_Seat_Section_SectionModelId",
                        column: x => x.SectionModelId,
                        principalTable: "Section",
                        principalColumn: "SectionModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventModelId = table.Column<int>(nullable: false),
                    SeatModelId = table.Column<int>(nullable: false),
                    UserModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationModelId);
                    table.ForeignKey(
                        name: "FK_Reservation_Event_EventModelId",
                        column: x => x.EventModelId,
                        principalTable: "Event",
                        principalColumn: "EventModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservation_Seat_SeatModelId",
                        column: x => x.SeatModelId,
                        principalTable: "Seat",
                        principalColumn: "SeatModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservation_User_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "User",
                        principalColumn: "UserModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_OrganizerModelId",
                table: "Event",
                column: "OrganizerModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_SpaceModelId",
                table: "Event",
                column: "SpaceModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_RegisteredUserModelId",
                table: "Notification",
                column: "RegisteredUserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_EventModelId",
                table: "Reservation",
                column: "EventModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_SeatModelId",
                table: "Reservation",
                column: "SeatModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserModelId",
                table: "Reservation",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_SectionModelId",
                table: "Seat",
                column: "SectionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Section_SpaceModelId",
                table: "Section",
                column: "SpaceModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Space_LocalAdministratorModelId",
                table: "Space",
                column: "LocalAdministratorModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Organizer");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Space");

            migrationBuilder.DropTable(
                name: "Administrator");
        }
    }
}
