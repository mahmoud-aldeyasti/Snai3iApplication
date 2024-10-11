using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class addingagainorder4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dba3a243-41e7-4b13-8a20-77a5f5634498", "AQAAAAIAAYagAAAAEHRm5uI4OHC5N5bBTPqqC6sBbCtuMbkDjb7AAq/VLJe473h2ianovTVACO6yWTkzqA==", "cfac26f1-bde9-4c6e-87b9-9dc84b308b00" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61b3e65b-919f-428c-8d8b-cb234fea6885", "AQAAAAIAAYagAAAAEMbpY0INsVfkVgCMDoCj3V00Qb75Ynnl83WeFbTyjXznFThf/VYfV7pHGoAfMQnEpA==", "ae18f994-bb91-4856-aca2-8b18e8164f8d" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68ade195-772c-4972-b3e4-0d7b1abc24b3", "AQAAAAIAAYagAAAAECquQy4jH0qJnT1OmoWyQoEd2YegiP3c80lQ3PC6D9k83nhMvgH41c/oYruj68l5pw==", "7fe6a813-a5af-40cb-bf1a-274287d64254" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4493f479-4c4f-41fe-a538-1c40bcc49486", "AQAAAAIAAYagAAAAEGTiU2pmPyQ7AZoofPlCxRp2+a5HCRCkiW0Lu5BW0g5DqIUKLu/U9Xp0rxF850VQ4w==", "483ac27b-0119-40bd-bd76-57fc69e0caa6" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "398f15b3-2276-4618-bae7-ce9db72967c3", "AQAAAAIAAYagAAAAEK78x1U0P5GhCekv09ApaUw63OX/FquC1TDNAiA0VeZztfVh8IG/SooCxWm6lrJSRA==", "a5c2b189-ea0a-43e4-b013-f7528424d9b4" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcf18995-e530-4fc4-87f1-474754df11a7", "AQAAAAIAAYagAAAAELOkIohnC/0Xr1YeDnmQIuwx2LjxwcL1Bc/sMJmlbabXrUdwN58VfQ5TQbg9Xh7xNA==", "75639995-2381-40e0-ab78-7a8e3d39ccc2" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b6d18d2-e843-432d-9b33-35f3d220b658", "AQAAAAIAAYagAAAAEH+7KEHS7YWBOPOwou0ZoYhHNKngA3nfPXCWKn3JkqaF5BS+fOIAg1G8TzlUyHXUwQ==", "b55aad32-8edc-48d6-b9ea-055de97a7c93" });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "Commision", "ConfirmDate", "ForwardDate", "UserId", "Value", "WorkerId", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName", "reviewId" },
                values: new object[] { 4, 9.5, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1-id", 1000.25, "worker3-id", null, null, null, null, null, null, null, null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "088b7c38-5892-47e7-879f-29eccde9dcad", "AQAAAAIAAYagAAAAEESFVbN8NO3YNPWC2raicmt93w7jw3ei/UOmgCeq2wf69wAui+zd1OEqmRi0l4FKmA==", "f414bc96-d555-4f9c-ab33-e7aa05c3f2ee" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6ba22fd-7c96-4c07-96e1-f6f12252d731", "AQAAAAIAAYagAAAAEK4GUsIIeZ4aiMGkYGNEZ1kpJeU3ZuzpElxo7XubxvEw0GZije1aP547hxloOEKbOg==", "33ea9047-9db2-419b-b8af-3aa74663a134" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fa2b2a7-1a1c-4b95-b24e-5608dfde8af1", "AQAAAAIAAYagAAAAEP0eGrwLScRSzMd+H62oGnOLDiCICWMU+0OWJfp9KtF6rguSCi3v0YlSy4HCdpcoTg==", "eb124647-0ece-433a-9f74-9f7d90d559b2" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ddf1922-7994-476f-b593-4f49de6e972d", "AQAAAAIAAYagAAAAEIp8Abk4uU7RLR8yzcD5mlIm+jJDm3igdu/2t/czGzylqkE7lnmiWLJ6avrPCD1EyQ==", "fd557af7-f7c9-444a-a3d7-00336d8abaf3" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08c2c687-de5a-46ed-bc10-044a707ec13d", "AQAAAAIAAYagAAAAEKtHw+vrAoXjy0Fv8djIURDPUgFaUeNS8NdUrqLCLBLrpffQYHC9NLQ5oc1Ek6o1bA==", "0c1e7b38-c28a-4cb3-9fb0-677ca313398b" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b328bc8-6694-4685-af5a-cfdfa33bb257", "AQAAAAIAAYagAAAAEGmKU4WuRuOz5Ig0OpjP8y/yev2eyakSKkQYngzZPEAozSdpoWOj2soS9BgJ1NlkmA==", "c56c2361-8d09-43a1-817e-d34116331091" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2ccf263-ada8-4f0e-9e75-a14f0173262f", "AQAAAAIAAYagAAAAEJuTtWVqTwFQ/VHkSP2JACz0hECgyTCWycG0F6d3qdExgr07kod+91wmPJIN9Aqgsw==", "23f2caa6-0e66-46b4-b6c7-4fb5a00c7a0e" });
        }
    }
}
