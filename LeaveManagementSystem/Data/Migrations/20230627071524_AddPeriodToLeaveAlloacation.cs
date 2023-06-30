using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    public partial class AddPeriodToLeaveAlloacation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f04b0791-a569-4649-b6a8-ea56c5e18e80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "d2423530-9169-4f69-9192-9cc75efedae3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0277cf85-7f7e-4d55-8808-dbc456156581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98fd89d3-a80a-4c3b-ba4c-e2f02730e0c4", "AQAAAAEAACcQAAAAEKwpk47oEaMFrzQwT+rSkPT3yoT8MqbfrR1hrTU2v50gOA1U+k1gAnxkmzY/yilYlg==", "4317767b-7b28-453b-8314-90c6ebb58e70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ade5992-4dbc-496f-9c94-2a57b4e46d1f", "AQAAAAEAACcQAAAAEPHjwzFKo0vVu2sAMmKLdyqQg4iGzpWG2RsbCVEvQEUPUmtsi1hz0qhKWoMCOR0pcQ==", "77d12c04-b383-4b5b-9472-25379b4b2b18" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b4a911d-7bc1-4d25-80a4-830fb3ed918c", "AQAAAAEAACcQAAAAEJqhc8+SfJXY/hHZ6TAZO6DLW3+hbdr8GIyzsprX+GA9rfbcdwMUsBmyjOTeZ1Q7aw==", "183b4ae2-54c4-4832-b668-07d18097e7de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2014e4a6-3b9d-47f8-9eeb-f8d005c782a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e58a60-7967-4abd-b0b5-fd29a965dd0f", "AQAAAAEAACcQAAAAEHku7OGBVEy2kYuLd6Zv8wO8yUHAyEIHwEV+S1bvkZLAAfNc7FlxLWE4f2Qt10PH5Q==", "a6641db0-122c-456e-bb64-a6977f64860c" });
        }
    }
}
