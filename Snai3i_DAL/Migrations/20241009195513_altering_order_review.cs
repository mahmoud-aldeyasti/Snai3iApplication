using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class altering_order_review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f9a2e0d-17ac-479b-ab8a-b0237c7627fa", "AQAAAAIAAYagAAAAEJ577iUxVT0q3HLsSiZBMTJ75bX6RCyFH7dLkxW+/NWNPj+1ew6w/70u55M0/VHjPQ==", "27fd0da3-bfc4-4bb2-bba9-8e5e09393467" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de7ce1f6-4d7c-485c-a7e7-02ffcecc9a88", "AQAAAAIAAYagAAAAEPKW5/o2nfpKO165/FILVW4WkaOkR41wQpxBp+fNKK5PUC9ugqyvnJvTIgMsQGL+xQ==", "499401a2-82b3-40e1-8ddf-e31f4e272ff2" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06e7184f-6db6-4bcf-ad27-59a01e243899", "AQAAAAIAAYagAAAAEF9d5olazrs8olEddUr+BnImNrxNCECfAb3Sk5c7hi9cJMuVLKRD6+hRGWgzNg+5qQ==", "c2ee5fa0-23e4-46f9-adf8-cbb84edf0260" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfa20a6e-b157-4b39-89d0-078d8615e097", "AQAAAAIAAYagAAAAEKid1vU53jMV7Yn25DyMVJDbhFMSFPZJgj2RaUGG+7YHJ2awoUSSt+eo/uW2IPPUlg==", "31da944b-47e0-4e41-8c94-048bbba59b91" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ddec0d-65e0-4a75-9497-68f35c7bea07", "AQAAAAIAAYagAAAAEAzTIrA1O+4q1ijk23DBeGnosIjnDuSaCsPL/DXJYG6Gp1kqi0R9mDUyY/SgFSgcsQ==", "5168fd1d-07d5-4c7c-af50-6a29469ee1b8" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08be94ce-df20-4e34-bb48-ace32a7b5256", "AQAAAAIAAYagAAAAEOX5RDRvmWgzXwDKYkrC/Ge4Te9Vvdv228yM09/eQ/5lsuHMEeZJRAtnWsQc09/17w==", "0a42cf23-f295-4943-914c-179351ca1c70" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea4e5c68-fc37-44ca-8d9a-3f035ea28d92", "AQAAAAIAAYagAAAAELtWB+GIcYjTSbuJzC8YBPV38Q38EsrDkqAZ9fwqrb+OaOSs+mo56NF6I/8IBxZ39Q==", "1be4b7ea-ae2a-4ea5-a397-6f7b2a968ffa" });
        }
    }
}
