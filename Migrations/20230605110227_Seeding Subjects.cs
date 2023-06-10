using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDziennikv2.Migrations
{
    public partial class SeedingSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "1b8a2b06-2300-4f42-89d4-0c09aa82adf2");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "975c2c09-5473-459e-88a4-09d79ad2b96e");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "c4d7d65a-9007-43e7-961a-71e75528f130");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "d0221d0d-da36-4b8b-acda-2f36d53a9e28");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "eabba7f4-cfe1-4a53-9233-ee3fd3bac81d");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "f27cc593-8f61-483f-a62c-07a063f461bd");

            migrationBuilder.CreateTable(
                name: "ExampleUser",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "13ae740a-032b-4ceb-8cd5-e3e15882aea9", "Geografia" },
                    { "5e5673e9-610c-4b11-aae3-ab3bd2d6425b", "Informatyka" },
                    { "8581003c-f80e-40d4-b092-7cd42195fb67", "Angielski" },
                    { "c9ef7f3a-fbc3-462b-baf8-1bdd2fe8b72b", "Polski" },
                    { "d5ebb4be-e12a-4795-81b7-63c13af88a06", "Historia" },
                    { "f5577245-da57-4c5a-8dc7-f47ab88f7723", "Biologia" },
                    { "f7cecc54-77ab-463d-92e0-7e3ea2b6bd5c", "Matematyka" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserGroups",
                columns: new[] { "Id", "GroupId", "UserId" },
                values: new object[,]
                {
                    { "3a6a22a8-0faa-4dbe-b07b-eb463fc9381d", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15" },
                    { "3ab17670-350a-4a74-873f-af1709fe64df", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11" },
                    { "89c67482-8a5b-4956-8f63-24e5aad881c6", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10" },
                    { "b4da7a70-c2f6-4c97-83b5-04ade0c525a1", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18" },
                    { "d412f786-538b-455b-8a5a-cee6ba9e5cdf", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19" },
                    { "e9528604-5412-40db-8aab-ea12fad951de", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExampleUser",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Subjects",
                schema: "Identity");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "3a6a22a8-0faa-4dbe-b07b-eb463fc9381d");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "3ab17670-350a-4a74-873f-af1709fe64df");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "89c67482-8a5b-4956-8f63-24e5aad881c6");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "b4da7a70-c2f6-4c97-83b5-04ade0c525a1");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "d412f786-538b-455b-8a5a-cee6ba9e5cdf");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "e9528604-5412-40db-8aab-ea12fad951de");

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
    }
}
