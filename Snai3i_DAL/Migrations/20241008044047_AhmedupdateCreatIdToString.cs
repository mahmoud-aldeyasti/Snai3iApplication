using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class AhmedupdateCreatIdToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "tools",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "tools",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "tools",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "sizes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "sizes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "sizes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "sales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "sales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "sales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "crafts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "crafts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "crafts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "chats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "chats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "chats",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "modifiedbyId",
                table: "cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "deletedbyId",
                table: "cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "createdbyId",
                table: "cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "superadmin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c60a0902-8563-466d-a18c-d5aa7c6837bc", "AQAAAAIAAYagAAAAEBNvh0gF5L/Tr/97rpd9IqOqJqfXfdqcSgMAZFKLRXt0J0cHJXUVvBPtVpN6iRwBIg==", "b827c7a9-23c0-4f04-ae36-d2fad9165fb0" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2143db8-3635-434d-809c-02888726069f", "AQAAAAIAAYagAAAAEOj1cD5GefdaCbSSM4YYbjiF7/AzOf7tJ8EKOh+gvUFZVgdU0uxLcWeBLAOjTlLc4w==", "0952325c-f557-4786-868a-b71f92cd10bd" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81bae25c-fc5d-4bb9-89ec-d50b2f64c385", "AQAAAAIAAYagAAAAECz4XY+FV1aZx+VqD4l6dOzrPiSgqGEuVahVImVMc8DQRnLx8vW8iz3xjlmtoW208Q==", "50be578b-db49-403c-b674-2a68e7bee08a" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "user3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ce106b8-54d9-4ba8-baf5-30614af1e453", "AQAAAAIAAYagAAAAEKeSwvA7kOmhcZyZktCaIgHw+5APHX92Jl99rB9NaBMU4HkvxEir7tFuR7E4ITOXxQ==", "652ba7eb-1b06-41ba-ac16-7d7049490978" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker1-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdc028f4-c98a-48e6-b710-66efef87ea79", "AQAAAAIAAYagAAAAEAMCNdEeEsM/UeJTfULpH3PLMnk3OS9V0ympPvO2uojA8y3CWM4533MeP0YDZKc8fw==", "3d8d0c16-7be3-4aeb-9836-79f6b2c0864e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker2-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ee0776a-800f-4a0a-912c-274195349dfb", "AQAAAAIAAYagAAAAECqKADDJQp/5BQjqWsVGB7JfWDywkoHFGlu8caxI0jzgdQFE+529YgPkgHGGUUe/TQ==", "fffa27a0-7ab9-49ab-8a83-0d550dc00a8d" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "worker3-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2a16e7d-6572-493e-a122-034fdec7b056", "AQAAAAIAAYagAAAAEH6DUKJcdnUx2k3xeh5J+PRaPceKC15jDqFGGtlcIGcDqRdmsYEzSZ7h8+oPxq+Luw==", "37ef8add-dcb0-4cf0-87cf-c6910ee1955f" });

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "crafts",
                keyColumn: "CraftId",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "crafts",
                keyColumn: "CraftId",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "crafts",
                keyColumn: "CraftId",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "tools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "tools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "tools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "tools",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "tools",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "tools",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "sizes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "sizes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "sizes",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "sales",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "crafts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "crafts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "crafts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "chats",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "chats",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "chats",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modifiedbyId",
                table: "cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deletedbyId",
                table: "cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "createdbyId",
                table: "cards",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "crafts",
                keyColumn: "CraftId",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "crafts",
                keyColumn: "CraftId",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "crafts",
                keyColumn: "CraftId",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sizes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sizes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "sizes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "tools",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "tools",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "tools",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdbyId", "deletedbyId", "modifiedbyId" },
                values: new object[] { null, null, null });
        }
    }
}
