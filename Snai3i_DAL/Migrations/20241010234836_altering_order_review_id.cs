using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class altering_order_review_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d995eb30-44cb-434d-b949-be6b5b9ce7a7", "AQAAAAIAAYagAAAAELf86GAF+ciEweF4lLoTVw563Oezd1D6WXNGEh+j9UcgY/I63eNfG4JvzJNUVXJ3ZQ==", "820172fc-60e8-4ed6-b2f2-4966226b8b5c" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50331dcb-d483-431f-87c9-1585f66a4138", "AQAAAAIAAYagAAAAEEfjsN85CgBCljuWNqchx4ore2OkyTa7JfU6i+kR9pVu23B+R9uS8MwkkK5VnLN25w==", "27d79bd1-54d4-479d-98d4-c8faa6b1d52e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46c3cf47-e2ad-4e08-9440-3024891a41b0", "AQAAAAIAAYagAAAAEM1YEOND28CBIbsGCgZwMIWzQ4RmKagiwDIII2vKXlJzlMl4ypio4bVv4XN3rLLJKg==", "aac8173b-b63c-4580-9acd-84968e45b76e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2cd5823-d1fd-4439-b8ef-cf59e0518054", "AQAAAAIAAYagAAAAEOetvA2JpESVcAWbipY3KvaXVbLMXwvtSH+23K0OMD8ifZT6UdqO1tOYGTkxyKDc1A==", "0ca05898-3613-4fa1-a32b-3fd9c715bff7" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f0ac02b-78b8-476d-a56e-b41aff5a482b", "AQAAAAIAAYagAAAAEB+X4da+wQiH32tJpnHB9fYu8AOg7RHDJ/zr9fDBN/ktoEeArdgqW96sdU1IYNo+Cw==", "90819def-0eee-40af-b218-59c26a0b869d" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c84334e-d165-45e3-bf43-c093674ca728", "AQAAAAIAAYagAAAAEFgq7CSAWG+qtQJ1ybNKaTK9gbKshzcNkfEUHG0cfSjJ6Htl5xHiiCQlGw8lBhqvuQ==", "273506aa-3d13-43a6-a733-ca45943d43a6" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bdb05d0-a028-4313-9051-37edc35062e7", "AQAAAAIAAYagAAAAEE7qQe10MmsYGmNZx8wg8/ZlMAu+V2BXXyBWvi1szG0/mkpd6i3be9UnhrlcRI847Q==", "5b56a46c-459f-4c47-93fc-9bf349f6ba50" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
