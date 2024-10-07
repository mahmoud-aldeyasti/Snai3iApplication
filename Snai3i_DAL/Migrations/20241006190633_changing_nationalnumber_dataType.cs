using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class changing_nationalnumber_dataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Nationalnumber",
                table: "ApplicationUser",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a67407-9202-40c6-9044-85af286a1645", "AQAAAAIAAYagAAAAEB9PqZ0eSUpSXtM0nmeEHRzluhFl1iBOITTpaE+km/y6TNMLz7ZzWIpc0iZpHn3neg==", "d9e1af6f-c2a3-4876-8cc5-b7a9db74650e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2e0bf1e-1796-4859-84f5-b4b4148fea5a", "AQAAAAIAAYagAAAAEGiqzZ3P9as+vRvTL7S5o7YhmB8zE9rMqfdAJbeTze6XwvC+ICBX6Uh04+pX93rW4Q==", "65f7cac1-c796-4e65-af2b-62f5035e64a0" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e777f441-9a17-4494-ade7-734aac923096", "AQAAAAIAAYagAAAAEA9va+DhgPx0m1ipTOO6+sDw57YqlRiqjdpGl3hR5EbnqvKDPB3yDzT7Mumoz2uSXQ==", "53ce09ea-ba81-43e4-bd5c-1551b49dc94a" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "Nationalnumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5469c89c-36a0-4fce-9856-5a742ac0cfaf", 123456789L, "AQAAAAIAAYagAAAAEPdaplUfm9muUDgmKjwf4I8kLcqnTRCezOE6QP5n4O5RlygUrvINcSqrl491kaOqeg==", "fd34bd56-af43-4560-bd67-e8a61579f065" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "Nationalnumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e8a74de-1309-431c-a731-c313dac41224", 987654321L, "AQAAAAIAAYagAAAAEGg6+GmfRcB/hFvQAD9e9FGFM/7biw57FJxQ+xxbY2aQVLSYUrBBDgG7N/DgXkF9Og==", "0a5fdcc6-c543-46e0-83d2-da3c2c32e3ff" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "Nationalnumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90728a30-5b6a-4d49-b1ed-9c19fe75f1bd", 1122334455L, "AQAAAAIAAYagAAAAEAJpWCgV3vHAVHw0oMh0kH3ZV4DiDcTzOteHUWQ2HiofkvwXEFbTDFMkTb6gf9JQUw==", "8745d4d8-858a-4860-8dd2-a62f7f47bf7c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Nationalnumber",
                table: "ApplicationUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75134771-d435-4d9e-b659-bdb5ae40baaf", "AQAAAAIAAYagAAAAEKi066JlHslqCRhVUSsjgOMnKK+QRq1WDyCBODvIa6jKooM1AdNVB1twwykOztH+nw==", "2f21e0af-846f-45de-b544-b45466e4dbbe" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c07103f5-05d5-4684-81cd-e4da801d9c83", "AQAAAAIAAYagAAAAEAHMzNgauRy8uElofMkCO1JzLJGOsW1FH0pGeJYELYnBeDGWIPWfbgAIOrQyUo8Sog==", "1e6602bf-a4c2-49dc-9d21-7e5f8c0ea6d5" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ddb1a51-a7ad-4d96-921b-c89d412eaec3", "AQAAAAIAAYagAAAAEPLPn+Qq0g6Kknp84uCeeZq2W2Mm07WbWGr+XlsZFkNopjsE7+lxgahPVrnMGdRsUQ==", "894afc38-8153-431b-98a9-c6472c9ef9f1" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00107b05-a53d-45f7-ae3d-f4e362d3c627", "AQAAAAIAAYagAAAAEBc3PnJjbX272Z/Bc+RbxqneecYMldhN7+zAWS+Z28uW0ZjCXttovpUbLoejz1qAtA==", "3c5afa6c-2677-48bb-88e3-dff26976d73e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "Nationalnumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "699c3ba6-c447-498e-87f8-8cb45219fe72", 123456789, "AQAAAAIAAYagAAAAEJ8XdMEZU7ExZYpwZc0vQpPKZsdcbDiky+Ibva4t8ETYg3QJRfvMrkefLG8wTUu5jw==", "1e3308a0-a6f4-4569-b879-6ea10f557ffd" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "Nationalnumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "960904a4-b3e7-4610-9bbb-06a7452bc1e3", 987654321, "AQAAAAIAAYagAAAAEI+1mGys3BtrL5kmgo8DCm4Y7oQr+ey37dyR4xHfGaLSeznbLakl9Q9xKbL9MXDnpw==", "03476476-9e0f-48e5-b55e-537cf697ce22" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "Nationalnumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84afdfcc-5738-4d09-b059-2962e9c1d89b", 1122334455, "AQAAAAIAAYagAAAAELuwjzTUjm5zn5rGTA2ROTAnQbuOHGaFLNxYljvX6B6IEJlunl91Ia5ymZi3nG4Wgw==", "e645ae7a-cb24-468b-ace5-31f0f1c66253" });
        }
    }
}
