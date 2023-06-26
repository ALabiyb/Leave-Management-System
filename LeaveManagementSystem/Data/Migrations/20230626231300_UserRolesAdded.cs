using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    public partial class UserRolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e8953b7a-10a5-42f3-9477-ccbc0fe0fe73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "8f967932-a2e6-48f3-a960-bd9e94453dfc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0277cf85-7f7e-4d55-8808-dbc456156581",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6b4a911d-7bc1-4d25-80a4-830fb3ed918c", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJqhc8+SfJXY/hHZ6TAZO6DLW3+hbdr8GIyzsprX+GA9rfbcdwMUsBmyjOTeZ1Q7aw==", "183b4ae2-54c4-4832-b668-07d18097e7de", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b8e58a60-7967-4abd-b0b5-fd29a965dd0f", "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHku7OGBVEy2kYuLd6Zv8wO8yUHAyEIHwEV+S1bvkZLAAfNc7FlxLWE4f2Qt10PH5Q==", "a6641db0-122c-456e-bb64-a6977f64860c", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0793f436-4d75-4b50-af77-5f68a5ac704f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "969c8263-1e48-4a4b-94e0-0e6d2e2ca43b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0277cf85-7f7e-4d55-8808-dbc456156581",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "86157a43-a2f4-438e-a8d1-141d0281d058", null, "AQAAAAEAACcQAAAAELaD4yBKqWTmsBshRT0pU2Cp5eu2cj4yCTsZFOqQovm/yCPPw24fWxlqEaB7rCToCA==", "f1043b9e-3ef9-4046-b418-91fd411017ce", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "769ebf98-5268-4f37-91a2-fe7f3df53909", "user@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEProPsrKNvkt1C5rJbmRElC8zSKJeDZO03MeVanJgcCa8cteaKCYdeGQFr/Sxz57zg==", "595e380a-b96b-4d12-bd97-7bc73652b1e8", null });
        }
    }
}
