using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDziennikv2.Migrations
{
    public partial class AssignUsersToGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: "b0e85d40-25bd-4501-ae93-487e03ac2e25");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: "d8e93d4a-93c5-4778-a216-ef99d66f84d6");

            migrationBuilder.CreateTable(
                name: "UserGroups",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                column: "Name",
                value: "Klasa 1A");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "50da648c-000c-4ebf-88e1-ae1688dfc57g", "Klasa 2B" },
                    { "50da648c-000c-4ebf-88e1-ae1688dfc57h", "Klasa 3C" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserGroups",
                columns: new[] { "Id", "GroupId", "UserId" },
                values: new object[,]
                {
                    { "1b8a2b06-2300-4f42-89d4-0c09aa82adf2", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11" },
                    { "975c2c09-5473-459e-88a4-09d79ad2b96e", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17" },
                    { "c4d7d65a-9007-43e7-961a-71e75528f130", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10" },
                    { "d0221d0d-da36-4b8b-acda-2f36d53a9e28", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19" },
                    { "eabba7f4-cfe1-4a53-9233-ee3fd3bac81d", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18" },
                    { "f27cc593-8f61-483f-a62c-07a063f461bd", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGroups",
                schema: "Identity");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: "50da648c-000c-4ebf-88e1-ae1688dfc57g");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: "50da648c-000c-4ebf-88e1-ae1688dfc57h");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: "50da648c-000c-4ebf-88e1-ae1688dfc57f",
                column: "Name",
                value: "Klasa 3C");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "b0e85d40-25bd-4501-ae93-487e03ac2e25", "Klasa 1A" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "d8e93d4a-93c5-4778-a216-ef99d66f84d6", "Klasa 2B" });
        }
    }
}
