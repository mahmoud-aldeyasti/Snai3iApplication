using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class seeding_user_claims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cc58044-f45e-42cc-8331-9a684bf623ba", "AQAAAAIAAYagAAAAEDkOxFBJsiqIS7LnqjreVl7x8NfRzyNU+kDCOtQglyz1C3tOJykCcT2p2req7AbCWA==", "241943d8-a58f-4811-85bc-90372f4f7c2e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "303ce261-9adb-4155-8d68-ff89056991d0", true, "AQAAAAIAAYagAAAAEGQNdqMIS50L3cjdYuI0W1CzAmuTBFjetgtYxVgAXQ4JpdOVJF/CIaoYtO+ySC3Q4g==", true, "10de9911-e3d7-453b-98ea-585a2ce48a35" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "31b3e52f-88a7-4602-b028-b7f0cacceb3e", true, "AQAAAAIAAYagAAAAENWNNt/pUTjX0QosP8oMd0k/6/0kT9JdE8weD4J9Jan+i3TgjwYGHdI1HRL1+mru4w==", true, "5da061bd-4110-4ab6-bc21-d696f35ecdbd" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "ff596251-b5e4-4bec-9f9d-802034194a75", true, "AQAAAAIAAYagAAAAEG7EsuGSrSRHYoJX3unNcmczgKWEvEpRAE+3UlJfeH3esgSDkETohOuWM2JYdOeNWw==", true, "0aa66783-02cd-468f-a3fa-274f9530c3ab" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "413bb351-6b7f-4ae1-9e14-f47a75c493e5", true, "AQAAAAIAAYagAAAAEA72HS91zjloY35hDemo4T19740lMxuc0ueC8rk/nuiZoxN+0jJazxtgA2n0ANpJZg==", true, "2fc6a72c-adce-46c3-8b95-e5e6a2083d36" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "94180b1f-8ca0-42d4-9e2c-604ee67d1b12", true, "AQAAAAIAAYagAAAAELXr+BNGLZk+IiQkPMzAc4AIgUMqIvPpT77O/w3SFlakbxfTz8lMRGKkt31top6xdw==", true, "6881c616-028b-4e3c-9a7b-bd5dd309ac00" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "299de589-5756-4414-b01b-b9616d818df7", true, "AQAAAAIAAYagAAAAEInYurjm+jVFKl+xIdWTBXSf5S8ARw4l07Wo40MXM7JONP4H1MX9g2MVzcvAy/lkbw==", true, "2dad3f18-9d5e-4d14-9962-e8ce47b3a32b" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 4, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", null },
                    { 5, "first_name", "kholoud", null },
                    { 6, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "SuperAdmin", null },
                    { 7, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", null },
                    { 8, "first_name", "ahmed", null },
                    { 9, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", null },
                    { 10, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", null },
                    { 11, "first_name", "sara", null },
                    { 12, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", null },
                    { 13, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", null },
                    { 14, "first_name", "omar", null },
                    { 15, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", null },
                    { 16, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", null },
                    { 17, "first_name", "mustafa", null },
                    { 18, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Worker", null },
                    { 19, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", null },
                    { 20, "first_name", "mohamed", null },
                    { 21, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Worker", null },
                    { 22, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", null },
                    { 23, "first_name", "fatma", null },
                    { 24, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Worker", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdc6bf28-3055-499a-9e59-96f4125b4313", "AQAAAAIAAYagAAAAEJX0qMfsPSnOqMPh0GQL5SNGhqMK9DkSdmB+rU6VegXFXiO+WmdoJOespBKeOrQPfg==", "a248e419-9862-44d2-9a67-5df55828f718" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "23a67407-9202-40c6-9044-85af286a1645", false, "AQAAAAIAAYagAAAAEB9PqZ0eSUpSXtM0nmeEHRzluhFl1iBOITTpaE+km/y6TNMLz7ZzWIpc0iZpHn3neg==", false, "d9e1af6f-c2a3-4876-8cc5-b7a9db74650e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "c2e0bf1e-1796-4859-84f5-b4b4148fea5a", false, "AQAAAAIAAYagAAAAEGiqzZ3P9as+vRvTL7S5o7YhmB8zE9rMqfdAJbeTze6XwvC+ICBX6Uh04+pX93rW4Q==", false, "65f7cac1-c796-4e65-af2b-62f5035e64a0" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "e777f441-9a17-4494-ade7-734aac923096", false, "AQAAAAIAAYagAAAAEA9va+DhgPx0m1ipTOO6+sDw57YqlRiqjdpGl3hR5EbnqvKDPB3yDzT7Mumoz2uSXQ==", false, "53ce09ea-ba81-43e4-bd5c-1551b49dc94a" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "5469c89c-36a0-4fce-9856-5a742ac0cfaf", false, "AQAAAAIAAYagAAAAEPdaplUfm9muUDgmKjwf4I8kLcqnTRCezOE6QP5n4O5RlygUrvINcSqrl491kaOqeg==", false, "fd34bd56-af43-4560-bd67-e8a61579f065" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "8e8a74de-1309-431c-a731-c313dac41224", false, "AQAAAAIAAYagAAAAEGg6+GmfRcB/hFvQAD9e9FGFM/7biw57FJxQ+xxbY2aQVLSYUrBBDgG7N/DgXkF9Og==", false, "0a5fdcc6-c543-46e0-83d2-da3c2c32e3ff" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "90728a30-5b6a-4d49-b1ed-9c19fe75f1bd", false, "AQAAAAIAAYagAAAAEAJpWCgV3vHAVHw0oMh0kH3ZV4DiDcTzOteHUWQ2HiofkvwXEFbTDFMkTb6gf9JQUw==", false, "8745d4d8-858a-4860-8dd2-a62f7f47bf7c" });
        }
    }
}
