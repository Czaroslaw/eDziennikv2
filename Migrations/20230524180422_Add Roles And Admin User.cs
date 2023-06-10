using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDziennikv2.Migrations
{
    public partial class AddRolesAndAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Identity",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b", 0, "b607265e-828b-4343-a054-182a257f7e7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", true, "Admin", "Administracyjny", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEKb5IefeWIPfJTC18Wg+JpLvxQkfGo6LgMpgSODy1qrCznerSzFos9FgKakh/XSc3Q==", null, false, "Z3NOBYCZLYVPHDBSDFRINI3MJC3Z7UHZ", false, "admin" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "Administrator", "Admin" },
                    { "fab4fac1-c546-41de-aebc-a14da6895712", "2", "Nauczyciel", "Teacher" },
                    { "fab4fac1-c546-41de-aebc-a14da6895713", "2", "Uczeń", "Student" },
                    { "fab4fac1-c546-41de-aebc-a14da6895714", "2", "Rodzic", "Parent" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895712");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895713");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895714");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa0becc9-9b13-4e1a-a88c-3e42e4a63c9b");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");
        }
    }
}
