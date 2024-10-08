using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Ahmedfirstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b318e2c1-bde3-4891-ab6a-c7d21aa8756e", "AQAAAAIAAYagAAAAEFG7N6vyggzL1Y5O9c3vyY3d3Muyk6XqFxG79LCE23BLSJEyE2uRraIiNcN24aIPdg==", "cb5d0449-40b8-4af9-8917-bc6d9947578f" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a87ede30-0147-48b6-a098-23f8d2ed8989", "AQAAAAIAAYagAAAAECGYZOhGUvvvX56P6sJJOazqVnWnRI3MagTzu+X5H23uWXoZy486W/wub1iEcvg75w==", "b88049c6-fd09-416d-9d28-0e7cc915aa47" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b75b87d-0593-4bf5-afd7-a083656f04a5", "AQAAAAIAAYagAAAAEL9TS14VXa7bITojb3g+XvYC8xRPlohmCij90OaUf+43P4AmXa4vpLqj4x2e/H+H0g==", "4fd6d2cb-b274-4802-9902-f48ac4b4fafd" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2cd1f5c-bf46-44c5-abdf-48ae87fe2c76", "AQAAAAIAAYagAAAAEIlJAR4Qod++sPcR/QA8Wgk6gwgnATZD8sYgdiQ0pAx6mgk1RhBHAMZHKkgl0d3ieQ==", "283528bd-5ff5-40f3-9952-6a9c4378664d" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e6faec-0017-4e3a-a8f5-4928b3b2068d", "AQAAAAIAAYagAAAAEPhB4yyPmAwDnRpArkpXZLv20hdNXMyhtj1TRtSVXicyOW+NJsCJ+pEKibgTHj2ggg==", "ec167638-8d84-440f-abc2-d2d180465b58" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "720bd32a-64a7-4909-b295-7ca71bdaee74", "AQAAAAIAAYagAAAAEIHpAuIG9xMyDoooapWG5DTymssN/PaJCcvnptNRv4NXuySXarAkntf00ZCqNTDrug==", "dcc69a68-51d7-488b-97af-7939b464b171" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e1443f2-349f-49d9-a8f7-23572e7ca19c", "AQAAAAIAAYagAAAAEMo8JX6LDtNfRW5kQaPS4pU4Twm6q2LYFS/V3YoVyn2LPgK236MFZFV9IlF+xAnH+A==", "63f18476-3c27-4d47-ba61-55d06d69b862" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
