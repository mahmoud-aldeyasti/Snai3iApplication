using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class seeding_user_claims1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36ce0c6d-37f9-4f3e-a55f-f80421911868", "AQAAAAIAAYagAAAAEJtcc3gVq+wX5LdRLLZoxBoJJKCOffDY9KdSE5mldqMeg3RfJRH8RuaIB04M562o2A==", "45227818-87b1-4a18-bfb7-e198fe26ce2d" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da515bf5-439a-49bd-8593-abc48644751a", "AQAAAAIAAYagAAAAEJoOVr4QF213JackliLi72Q4f+qWWafUDBAZ1iKer7hOOdz0ced4Ld0idOSFk9VXHw==", "22846e9e-875b-498f-8c58-4a25e4b77a41" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8004fbf7-0d2d-4536-8467-1651d5b6a74a", "AQAAAAIAAYagAAAAEEPxu4DknYhU7/mXhfWnH/uUtYS3hzuUonp6SVDu4iPlttH1tU/XlYW+Q90yPHaLKA==", "35eda25d-c2ec-4f48-ba30-27fd68a24b0d" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f5c42ce-6790-463e-897e-5264beca4b7b", "AQAAAAIAAYagAAAAEPGMcWuBm/Wt9wldNyTzMzti08hg/tw79+/6YNebRfJ50dEsv1bsvmFAb1L8ObEShg==", "6c64d5da-91be-4c7f-aa5c-ddaf5745fafc" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2326918-74a9-4a4c-b472-17e1f0c2d846", "AQAAAAIAAYagAAAAEOi/tF0EA4DVi1eI6J4wAI+P705ZYuzWMvomNPyd1NAN4WLNS2uFGwJ1hMcn4VgjCg==", "f1e74e8b-36f6-45d6-86f2-78f2655043fd" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69903e81-7788-46f1-ad36-120cadd697c2", "AQAAAAIAAYagAAAAEGGb7Zw03UI1lYdryJm9UbQc6Dj8ZP/9I2yBrcNh/zeSXFOyZPFKaRyCykMuiT8M3Q==", "5d0ac619-b0d6-4971-a5a3-7a00cd853ba8" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8eb514e-b33a-42dd-8fd9-9d3e4f495fce", "AQAAAAIAAYagAAAAEIyRoOmZQKgh19cPnT4rUN/dKjP6tLLEYw1KwcPEeYyIRhB15EOBmSGUIJoo/hxltw==", "374fdea3-271d-411e-8815-6955dcfac56c" });

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "superadmin-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "superadmin-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: "superadmin-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: "user1-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: "user1-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: "user1-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: "user2-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: "user2-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: "user2-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: "user3-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "user3-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: "user3-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: "worker1-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: "worker1-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserId",
                value: "worker1-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: "worker2-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: "worker2-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 21,
                column: "UserId",
                value: "worker2-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: "worker3-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: "worker3-id");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "UserId",
                value: "worker3-id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "303ce261-9adb-4155-8d68-ff89056991d0", "AQAAAAIAAYagAAAAEGQNdqMIS50L3cjdYuI0W1CzAmuTBFjetgtYxVgAXQ4JpdOVJF/CIaoYtO+ySC3Q4g==", "10de9911-e3d7-453b-98ea-585a2ce48a35" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31b3e52f-88a7-4602-b028-b7f0cacceb3e", "AQAAAAIAAYagAAAAENWNNt/pUTjX0QosP8oMd0k/6/0kT9JdE8weD4J9Jan+i3TgjwYGHdI1HRL1+mru4w==", "5da061bd-4110-4ab6-bc21-d696f35ecdbd" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff596251-b5e4-4bec-9f9d-802034194a75", "AQAAAAIAAYagAAAAEG7EsuGSrSRHYoJX3unNcmczgKWEvEpRAE+3UlJfeH3esgSDkETohOuWM2JYdOeNWw==", "0aa66783-02cd-468f-a3fa-274f9530c3ab" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "413bb351-6b7f-4ae1-9e14-f47a75c493e5", "AQAAAAIAAYagAAAAEA72HS91zjloY35hDemo4T19740lMxuc0ueC8rk/nuiZoxN+0jJazxtgA2n0ANpJZg==", "2fc6a72c-adce-46c3-8b95-e5e6a2083d36" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94180b1f-8ca0-42d4-9e2c-604ee67d1b12", "AQAAAAIAAYagAAAAELXr+BNGLZk+IiQkPMzAc4AIgUMqIvPpT77O/w3SFlakbxfTz8lMRGKkt31top6xdw==", "6881c616-028b-4e3c-9a7b-bd5dd309ac00" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "299de589-5756-4414-b01b-b9616d818df7", "AQAAAAIAAYagAAAAEInYurjm+jVFKl+xIdWTBXSf5S8ARw4l07Wo40MXM7JONP4H1MX9g2MVzcvAy/lkbw==", "2dad3f18-9d5e-4d14-9962-e8ce47b3a32b" });

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 21,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "UserId",
                value: null);
        }
    }
}
