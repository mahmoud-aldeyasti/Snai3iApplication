using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewOrder4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac097fcb-bff1-4379-b9fb-5ddfccf1a200", "AQAAAAIAAYagAAAAEB09AC2kKjbvwnYpmRqiRDRUcMcQGiNrwIzbZoaMhPHuY3xYeaSFLWqWG3jm7sjFXA==", "f3d1497b-eea7-459f-b90f-e662317394bb" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81e2df19-3977-48fa-b62f-5d4e7dc094d1", "AQAAAAIAAYagAAAAENIlUD/ZlzdVJimhT85y2ZjkeXQYE5Z4Y/6Q8m3VqfpVBeuNiEee0j0U6qudR2Vybg==", "3151fe29-0407-4155-9700-6187313f668e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c03449c6-8778-4962-9e3e-ae903ac7168f", "AQAAAAIAAYagAAAAEJc6OK/WPZU7+uxRHs0jrMrYCP5gHH4eIMc1C7aTZUf69PsUhnpM0G56ckjeiFtVlg==", "7d84aa21-081d-4715-b8a4-e8cd730c208e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70e0467b-23f0-4baf-9a0a-ce726279a1b9", "AQAAAAIAAYagAAAAEI6/Tc3u9HA29PnmvcdVl6K6AAk6Vc7JsWMD3JHkWxGZ4+isUC2vsf3N02992RQZMQ==", "7f16835f-73b0-4acf-8520-59d43caba6c6" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6c24139-7806-4c3d-b1b4-0124c6b09f06", "AQAAAAIAAYagAAAAECBr5hDjwL8ZVrEu/0+SiFO6gQcIjCb2PmZ8oyzRplBx9E5e5nPYuoZosoDwim+/8g==", "4359b994-5cd8-430f-b5ce-6b51162ac2e1" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31a482bf-468e-4c77-8f65-6035314e25c6", "AQAAAAIAAYagAAAAEI2u873cGOW0fIhTsNvAjDdj9lwdhJscqBuSb/kXPVXBsaOVPvmPR0Xy4GOQjiimOQ==", "627ebd4a-0cf5-4588-8450-8d719b41559f" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a79bddd3-a363-4362-9d8e-d7a2e5d534f9", "AQAAAAIAAYagAAAAEPyASs5eloDmXrbnWVnA0MJitEn5wYcc7RqDci+3yuO704+gMCDog3MqroVpDW7CFQ==", "93bcee24-8a83-405b-8e38-69708a8eea1a" });
        }
    }
}
