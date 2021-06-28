using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID_19.ES.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CABIN",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    direction = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    phone = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    position = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mail = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABIN", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CITIZEN",
                columns: table => new
                {
                    dui = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    direction = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    phone = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    mail = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CITIZEN__D876F1BE4BEAA863", x => x.dui);
                });

            migrationBuilder.CreateTable(
                name: "MANAGER",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    institutional_mail = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    home_direction = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    employee_type = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MANAGER", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SIDE_EFFECT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIDE_EFFECT", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "APPOINTMENT_1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    place = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    dui_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPOINTMENT_1", x => x.id);
                    table.ForeignKey(
                        name: "FK_CITIZENXAPPOINTMET_1",
                        column: x => x.dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APPOINTMENT_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    place = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    dui_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPOINTMENT_2", x => x.id);
                    table.ForeignKey(
                        name: "FK_CITIZENXAPPOINTMET_2",
                        column: x => x.dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CHRONIC_DISEASE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dui_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHRONIC_DISEASE", x => x.id);
                    table.ForeignKey(
                        name: "FK_CITIZENXCHRONIC_DISEASE",
                        column: x => x.dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DOSE_1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    dui_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOSE_1", x => x.id);
                    table.ForeignKey(
                        name: "FK_CITIZENXDOSE_1",
                        column: x => x.dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DOSE_2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    dui_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOSE_2", x => x.id);
                    table.ForeignKey(
                        name: "FK_CITIZENXDOSE_2",
                        column: x => x.dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUTION",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dui_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSTITUTION", x => x.id);
                    table.ForeignKey(
                        name: "FK_CITIZENXINSTITUTION",
                        column: x => x.dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PRIORITY_GROUP",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dui_citizen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRIORITY_GROUP", x => x.id);
                    table.ForeignKey(
                        name: "FK_CITIZENXPRIORITY_GROUP",
                        column: x => x.dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "REGISTRATION_START",
                columns: table => new
                {
                    id_manager = table.Column<int>(type: "int", nullable: false),
                    id_cabin = table.Column<int>(type: "int", nullable: false),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MANAGERXCABIN", x => new { x.id_manager, x.id_cabin });
                    table.ForeignKey(
                        name: "FK__REGISTRAT__id_ca__38996AB5",
                        column: x => x.id_cabin,
                        principalTable: "CABIN",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__REGISTRAT__id_ma__37A5467C",
                        column: x => x.id_manager,
                        principalTable: "MANAGER",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CABINXAPPOINTMENT_1",
                columns: table => new
                {
                    id_cabin = table.Column<int>(type: "int", nullable: false),
                    id_appointment_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABINXAPPOINTMET_1", x => new { x.id_cabin, x.id_appointment_1 });
                    table.ForeignKey(
                        name: "FK__CABINXAPP__id_ap__3C69FB99",
                        column: x => x.id_appointment_1,
                        principalTable: "APPOINTMENT_1",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__CABINXAPP__id_ca__3B75D760",
                        column: x => x.id_cabin,
                        principalTable: "CABIN",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WAIT_ROW1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    dui_appointment_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WAIT_ROW1", x => x.id);
                    table.ForeignKey(
                        name: "FK_APPOINTMENT_1XWAIT_ROW1",
                        column: x => x.dui_appointment_1,
                        principalTable: "APPOINTMENT_1",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CABINXAPPOINTMENT_2",
                columns: table => new
                {
                    id_cabin = table.Column<int>(type: "int", nullable: false),
                    id_appointment_2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CABINXAPPOINTMET_2", x => new { x.id_cabin, x.id_appointment_2 });
                    table.ForeignKey(
                        name: "FK__CABINXAPP__id_ap__403A8C7D",
                        column: x => x.id_appointment_2,
                        principalTable: "APPOINTMENT_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__CABINXAPP__id_ca__3F466844",
                        column: x => x.id_cabin,
                        principalTable: "CABIN",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WAIT_ROW2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    dui_appointment_2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WAIT_ROW2", x => x.id);
                    table.ForeignKey(
                        name: "FK_APPOINTMENT_2XWAIT_ROW2",
                        column: x => x.dui_appointment_2,
                        principalTable: "APPOINTMENT_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DOSE_1XSIDE_EFFECT",
                columns: table => new
                {
                    id_side_effect = table.Column<int>(type: "int", nullable: false),
                    id_dose_1 = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOSE_1XSIDE_EFFECT", x => new { x.id_side_effect, x.id_dose_1 });
                    table.ForeignKey(
                        name: "FK__DOSE_1XSI__id_do__52593CB8",
                        column: x => x.id_dose_1,
                        principalTable: "DOSE_1",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DOSE_1XSI__id_si__5165187F",
                        column: x => x.id_side_effect,
                        principalTable: "SIDE_EFFECT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DOSE_2XSIDE_EFFECT",
                columns: table => new
                {
                    id_side_effect = table.Column<int>(type: "int", nullable: false),
                    id_dose_2 = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOSE_2XSIDE_EFFECT", x => new { x.id_side_effect, x.id_dose_2 });
                    table.ForeignKey(
                        name: "FK__DOSE_2XSI__id_do__5629CD9C",
                        column: x => x.id_dose_2,
                        principalTable: "DOSE_2",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DOSE_2XSI__id_si__5535A963",
                        column: x => x.id_side_effect,
                        principalTable: "SIDE_EFFECT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_1_dui_citizen",
                table: "APPOINTMENT_1",
                column: "dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_2_dui_citizen",
                table: "APPOINTMENT_2",
                column: "dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_CABINXAPPOINTMENT_1_id_appointment_1",
                table: "CABINXAPPOINTMENT_1",
                column: "id_appointment_1");

            migrationBuilder.CreateIndex(
                name: "IX_CABINXAPPOINTMENT_2_id_appointment_2",
                table: "CABINXAPPOINTMENT_2",
                column: "id_appointment_2");

            migrationBuilder.CreateIndex(
                name: "IX_CHRONIC_DISEASE_dui_citizen",
                table: "CHRONIC_DISEASE",
                column: "dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_DOSE_1_dui_citizen",
                table: "DOSE_1",
                column: "dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_DOSE_1XSIDE_EFFECT_id_dose_1",
                table: "DOSE_1XSIDE_EFFECT",
                column: "id_dose_1");

            migrationBuilder.CreateIndex(
                name: "IX_DOSE_2_dui_citizen",
                table: "DOSE_2",
                column: "dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_DOSE_2XSIDE_EFFECT_id_dose_2",
                table: "DOSE_2XSIDE_EFFECT",
                column: "id_dose_2");

            migrationBuilder.CreateIndex(
                name: "IX_INSTITUTION_dui_citizen",
                table: "INSTITUTION",
                column: "dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_PRIORITY_GROUP_dui_citizen",
                table: "PRIORITY_GROUP",
                column: "dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_REGISTRATION_START_id_cabin",
                table: "REGISTRATION_START",
                column: "id_cabin");

            migrationBuilder.CreateIndex(
                name: "IX_WAIT_ROW1_dui_appointment_1",
                table: "WAIT_ROW1",
                column: "dui_appointment_1");

            migrationBuilder.CreateIndex(
                name: "IX_WAIT_ROW2_dui_appointment_2",
                table: "WAIT_ROW2",
                column: "dui_appointment_2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CABINXAPPOINTMENT_1");

            migrationBuilder.DropTable(
                name: "CABINXAPPOINTMENT_2");

            migrationBuilder.DropTable(
                name: "CHRONIC_DISEASE");

            migrationBuilder.DropTable(
                name: "DOSE_1XSIDE_EFFECT");

            migrationBuilder.DropTable(
                name: "DOSE_2XSIDE_EFFECT");

            migrationBuilder.DropTable(
                name: "INSTITUTION");

            migrationBuilder.DropTable(
                name: "PRIORITY_GROUP");

            migrationBuilder.DropTable(
                name: "REGISTRATION_START");

            migrationBuilder.DropTable(
                name: "WAIT_ROW1");

            migrationBuilder.DropTable(
                name: "WAIT_ROW2");

            migrationBuilder.DropTable(
                name: "DOSE_1");

            migrationBuilder.DropTable(
                name: "DOSE_2");

            migrationBuilder.DropTable(
                name: "SIDE_EFFECT");

            migrationBuilder.DropTable(
                name: "CABIN");

            migrationBuilder.DropTable(
                name: "MANAGER");

            migrationBuilder.DropTable(
                name: "APPOINTMENT_1");

            migrationBuilder.DropTable(
                name: "APPOINTMENT_2");

            migrationBuilder.DropTable(
                name: "CITIZEN");
        }
    }
}
