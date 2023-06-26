using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    public partial class UserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "0793f436-4d75-4b50-af77-5f68a5ac704f", "Admin", "ADMIN" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "969c8263-1e48-4a4b-94e0-0e6d2e2ca43b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0277cf85-7f7e-4d55-8808-dbc456156581", 0, "86157a43-a2f4-438e-a8d1-141d0281d058", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "admin", "test", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAELaD4yBKqWTmsBshRT0pU2Cp5eu2cj4yCTsZFOqQovm/yCPPw24fWxlqEaB7rCToCA==", null, false, "f1043b9e-3ef9-4046-b418-91fd411017ce", null, false, null },
                    { "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9", 0, "769ebf98-5268-4f37-91a2-fe7f3df53909", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "user", "test", false, null, "user@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEProPsrKNvkt1C5rJbmRElC8zSKJeDZO03MeVanJgcCa8cteaKCYdeGQFr/Sxz57zg==", null, false, "595e380a-b96b-4d12-bd97-7bc73652b1e8", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "0277cf85-7f7e-4d55-8808-dbc456156581" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "0277cf85-7f7e-4d55-8808-dbc456156581" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0277cf85-7f7e-4d55-8808-dbc456156581");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9");
        }
    }
}
