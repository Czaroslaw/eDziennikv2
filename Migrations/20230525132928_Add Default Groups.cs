using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDziennikv2.Migrations
{
    public partial class AddDefaultGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "celina.piotrowska@testowy.mail", true, "Celina", "Piotrowska", false, null, "CELINA.PIOTROWSKA@TESTOWY.MAIL", "CELINA.PIOTROWSKA", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "celina.piotrowska" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sulisław.dudek@testowy.mail", true, "Sulisław", "Dudek", false, null, "SULISŁAW.DUDEK@TESTOWY.MAIL", "SULISŁAW.DUDEK", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "sulisław.dudek" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "maksym.dudek@testowy.mail", true, "Maksym", "Dudek", false, null, "MAKSYM.DUDEK@TESTOWY.MAIL", "MAKSYM.DUDEK", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "maksym.dudek" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mirosława.rutkowska@testowy.mail", true, "Mirosława", "Rutkowska", false, null, "MIROSŁAWA.RUTKOWSKA@TESTOWY.MAIL", "MIROSŁAWA.RUTKOWSKA", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "mirosława.rutkowska" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "henryka.jasińska@testowy.mail", true, "Henryka", "Jasińska", false, null, "HENRYKA.JASIŃSKA@TESTOWY.MAIL", "HENRYKA.JASIŃSKA", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "henryka.jasińska" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kazia.sawicka@testowy.mail", true, "Kazia", "Sawicka", false, null, "KAZIA.SAWICKA@TESTOWY.MAIL", "KAZIA.SAWICKA", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "kazia.sawicka" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jadwiga.piotrowska@testowy.mail", true, "Jadwiga", "Piotrowska", false, null, "JADWIGA.PIOTROWSKA@TESTOWY.MAIL", "JADWIGA.PIOTROWSKA", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "jadwiga.piotrowska" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "wielisław.czerwinski@testowy.mail", true, "Wielisław", "Czerwinski", false, null, "WIELISŁAW.CZERWINSKI@TESTOWY.MAIL", "WIELISŁAW.CZERWINSKI", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "wielisław.czerwinski" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "antoni.kalinowski@testowy.mail", true, "Antoni", "Kalinowski", false, null, "ANTONI.KALINOWSKI@TESTOWY.MAIL", "ANTONI.KALINOWSKI", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "antoni.kalinowski" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dawid.kucharski@testowy.mail", true, "Dawid", "Kucharski", false, null, "DAWID.KUCHARSKI@TESTOWY.MAIL", "DAWID.KUCHARSKI", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "dawid.kucharski" },
                    { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adrianna.zawadzka@testowy.mail", true, "Adrianna", "Zawadzka", false, null, "ADRIANNA.ZAWADZKA@TESTOWY.MAIL", "ADRIANNA.ZAWADZKA", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "adrianna.zawadzka" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "50da648c-000c-4ebf-88e1-ae1688dfc57f", "Klasa 3C" },
                    { "b0e85d40-25bd-4501-ae93-487e03ac2e25", "Klasa 1A" },
                    { "d8e93d4a-93c5-4778-a216-ef99d66f84d6", "Klasa 2B" }
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "Name",
                value: "Administrator");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895712",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Nauczyciel", "Teacher" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895713",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Uczeń", "Student" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895714",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Rodzic", "Parent" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fab4fac1-c546-41de-aebc-a14da6895712", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10" },
                    { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11" },
                    { "fab4fac1-c546-41de-aebc-a14da6895712", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12" },
                    { "fab4fac1-c546-41de-aebc-a14da6895714", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13" },
                    { "fab4fac1-c546-41de-aebc-a14da6895714", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14" },
                    { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15" },
                    { "fab4fac1-c546-41de-aebc-a14da6895714", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16" },
                    { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17" },
                    { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18" },
                    { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19" },
                    { "fab4fac1-c546-41de-aebc-a14da6895712", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups",
                schema: "Identity");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895712", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895712", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895714", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895714", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895714", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895713", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895712", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c12");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c13");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c14");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c16");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c20");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                column: "Name",
                value: "Admin");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895712",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Teacher", "Nauczyciel" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895713",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Student", "Uczeń" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895714",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Parent", "Rodzic" });
        }
    }
}
