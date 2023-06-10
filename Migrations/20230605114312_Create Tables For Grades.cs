using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDziennikv2.Migrations
{
    public partial class CreateTablesForGrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "13ae740a-032b-4ceb-8cd5-e3e15882aea9");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "5e5673e9-610c-4b11-aae3-ab3bd2d6425b");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "8581003c-f80e-40d4-b092-7cd42195fb67");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "c9ef7f3a-fbc3-462b-baf8-1bdd2fe8b72b");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "d5ebb4be-e12a-4795-81b7-63c13af88a06");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "f5577245-da57-4c5a-8dc7-f47ab88f7723");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "f7cecc54-77ab-463d-92e0-7e3ea2b6bd5c");

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

            migrationBuilder.CreateTable(
                name: "Grades",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IssuedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IssuedToId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_AspNetUsers_IssuedById",
                        column: x => x.IssuedById,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Grades_AspNetUsers_IssuedToId",
                        column: x => x.IssuedToId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Grades_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "Identity",
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "04938cb0-3200-4134-94ce-7388f182cfc3", "Matematyka" },
                    { "626fbe3d-d5a9-4746-9852-3b76a8dcfa4f", "Geografia" },
                    { "65b59c1e-cb11-4ecb-81aa-fef668f10e00", "Historia" },
                    { "ae0a9bb6-a319-46c2-82f3-70c07f180f1c", "Polski" },
                    { "c864e25d-f4eb-4d3d-a285-7ec321a3e4b1", "Informatyka" },
                    { "da5548f9-10da-42e2-93ee-d8092fae914e", "Biologia" },
                    { "fa6a06d0-498a-4cf0-a449-ad60ee3f95a9", "Angielski" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserGroups",
                columns: new[] { "Id", "GroupId", "UserId" },
                values: new object[,]
                {
                    { "11e487d0-1ce4-49d1-857e-5bf8588fd159", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c17" },
                    { "3cf6fef9-44d0-4aea-ac40-c5c29bf80d27", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c18" },
                    { "6649b7be-aec9-4d2c-a5f9-2756db2f75e8", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c19" },
                    { "73214d76-d821-4e21-b9c0-ad3e5062b544", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c10" },
                    { "b9728f5c-e48b-4f26-8970-2fd49f0b37fa", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c11" },
                    { "fb3e50e3-57f0-4a04-9d9c-0e16b0657760", "50da648c-000c-4ebf-88e1-ae1688dfc57f", "fa0becc9-9b13-4e1a-a88c-3e42e4a63c15" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IssuedById",
                schema: "Identity",
                table: "Grades",
                column: "IssuedById");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IssuedToId",
                schema: "Identity",
                table: "Grades",
                column: "IssuedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SubjectId",
                schema: "Identity",
                table: "Grades",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades",
                schema: "Identity");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "04938cb0-3200-4134-94ce-7388f182cfc3");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "626fbe3d-d5a9-4746-9852-3b76a8dcfa4f");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "65b59c1e-cb11-4ecb-81aa-fef668f10e00");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "ae0a9bb6-a319-46c2-82f3-70c07f180f1c");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "c864e25d-f4eb-4d3d-a285-7ec321a3e4b1");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "da5548f9-10da-42e2-93ee-d8092fae914e");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Subjects",
                keyColumn: "Id",
                keyValue: "fa6a06d0-498a-4cf0-a449-ad60ee3f95a9");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "11e487d0-1ce4-49d1-857e-5bf8588fd159");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "3cf6fef9-44d0-4aea-ac40-c5c29bf80d27");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "6649b7be-aec9-4d2c-a5f9-2756db2f75e8");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "73214d76-d821-4e21-b9c0-ad3e5062b544");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "b9728f5c-e48b-4f26-8970-2fd49f0b37fa");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: "fb3e50e3-57f0-4a04-9d9c-0e16b0657760");

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
    }
}
