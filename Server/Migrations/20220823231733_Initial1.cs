using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpitecCMSApp.Server.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("a6aaea46-384f-4b01-a449-8f31e0dd59bc"));

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "birthDate", "firstName", "lastName", "phoneNum" },
                values: new object[,]
                {
                    { new Guid("a7d37b08-962e-4ceb-913f-a54c5fee7207"), new DateTime(1988, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bill", "Blokovitch", "1234567890" },
                    { new Guid("afe8638f-1e8e-4926-a4e4-64ab88b75b65"), new DateTime(2002, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Smith", "5556667777" },
                    { new Guid("e7044ea5-b311-4be4-888f-d113527e6ba1"), new DateTime(1997, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam", "Hyde", "11123456789" },
                    { new Guid("f2efb90d-270f-4513-b209-5034da2fc5e4"), new DateTime(2001, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wasim", "Algamal", "3133984347" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("a7d37b08-962e-4ceb-913f-a54c5fee7207"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("afe8638f-1e8e-4926-a4e4-64ab88b75b65"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("e7044ea5-b311-4be4-888f-d113527e6ba1"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("f2efb90d-270f-4513-b209-5034da2fc5e4"));

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "birthDate", "firstName", "lastName", "phoneNum" },
                values: new object[] { new Guid("a6aaea46-384f-4b01-a449-8f31e0dd59bc"), new DateTime(2001, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wasim", "Algamal", "3133984347" });
        }
    }
}
