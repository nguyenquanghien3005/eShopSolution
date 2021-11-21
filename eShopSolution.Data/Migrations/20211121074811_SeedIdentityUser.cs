using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("853da3a3-7d54-4076-934e-219f177975c6"), "2177eaa3-c12a-4dbd-a243-cf51a71d942c", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("853da3a3-7d54-4076-934e-219f177975c6"), new Guid("8a7ea03e-6009-4f61-b250-17257ffa001c") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8a7ea03e-6009-4f61-b250-17257ffa001c"), 0, "eee04d53-abd7-47fe-a16f-7e37433f9f68", new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenquanghien3005@gmail.com", true, "Hien", "Nguyen Quang", false, null, "nguyenquanghien3005@gmail.com", "admin", "AQAAAAEAACcQAAAAEEUeuxea5Ng/RZyyEBTs8Td/P0Rfb2Dr80R5G5n6DmxXU98LyYmoQ6EXupsTxd82bQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 21, 14, 48, 10, 473, DateTimeKind.Local).AddTicks(6811));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("853da3a3-7d54-4076-934e-219f177975c6"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("853da3a3-7d54-4076-934e-219f177975c6"), new Guid("8a7ea03e-6009-4f61-b250-17257ffa001c") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a7ea03e-6009-4f61-b250-17257ffa001c"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 21, 14, 10, 11, 156, DateTimeKind.Local).AddTicks(1511));
        }
    }
}
