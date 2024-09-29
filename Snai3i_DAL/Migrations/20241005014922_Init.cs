﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "crafts",
                columns: table => new
                {
                    CraftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crafts", x => x.CraftId);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Nationalnumber = table.Column<int>(type: "int", nullable: true),
                    Governorate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfOperation = table.Column<int>(type: "int", nullable: true),
                    CraftId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_crafts_CraftId",
                        column: x => x.CraftId,
                        principalTable: "crafts",
                        principalColumn: "CraftId");
                });

            migrationBuilder.CreateTable(
                name: "sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ToolSize = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ToolId = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sizes_tools_ToolId",
                        column: x => x.ToolId,
                        principalTable: "tools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserTool",
                columns: table => new
                {
                    buyersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    toolsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserTool", x => new { x.buyersId, x.toolsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserTool_ApplicationUser_buyersId",
                        column: x => x.buyersId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationUserTool_tools_toolsId",
                        column: x => x.toolsId,
                        principalTable: "tools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chats_ApplicationUser_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chats_ApplicationUser_SenderId",
                        column: x => x.SenderId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForwardDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Commision = table.Column<double>(type: "float", nullable: false),
                    reviewId = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.UniqueConstraint("AK_orders_reviewId", x => x.reviewId);
                    table.ForeignKey(
                        name: "FK_orders_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_orders_ApplicationUser_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserWorker",
                columns: table => new
                {
                    usersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    workersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWorker", x => new { x.usersId, x.workersId });
                    table.ForeignKey(
                        name: "FK_UserWorker_ApplicationUser_usersId",
                        column: x => x.usersId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserWorker_ApplicationUser_workersId",
                        column: x => x.workersId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ToolId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    BuyerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cards", x => x.Id);
                    table.UniqueConstraint("AK_cards_SaleId", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_cards_ApplicationUser_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_cards_sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "sizes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_cards_tools_ToolId",
                        column: x => x.ToolId,
                        principalTable: "tools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reviews_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reviews_ApplicationUser_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reviews_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "reviewId");
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<int>(type: "int", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<int>(type: "int", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<int>(type: "int", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sales_cards_CardId",
                        column: x => x.CardId,
                        principalTable: "cards",
                        principalColumn: "SaleId");
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "image", "modifiedDatetime", "modifiedbyId", "modifiedbyName", "type" },
                values: new object[] { "superadmin-id", 0, "75134771-d435-4d9e-b659-bdb5ae40baaf", "kholoud@sani3i.com", true, "Salama", false, null, "KHOLOUD@SANI3I.COM", "KHOLOUD", "AQAAAAIAAYagAAAAEKi066JlHslqCRhVUSsjgOMnKK+QRq1WDyCBODvIa6jKooM1AdNVB1twwykOztH+nw==", "0100000000", true, "2f21e0af-846f-45de-b544-b45466e4dbbe", false, "kholoud", null, null, null, null, null, "Khouloud.png", null, null, null, 0 });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "image", "modifiedDatetime", "modifiedbyId", "modifiedbyName", "type" },
                values: new object[,]
                {
                    { "user1-id", 0, "c07103f5-05d5-4684-81cd-e4da801d9c83", "ahmed@example.com", false, "Ragab", 31.235700000000001, false, null, 30.0444, "AHMED@EXAMPLE.COM", "AHMED", "AQAAAAIAAYagAAAAEAHMzNgauRy8uElofMkCO1JzLJGOsW1FH0pGeJYELYnBeDGWIPWfbgAIOrQyUo8Sog==", null, false, "1e6602bf-a4c2-49dc-9d21-7e5f8c0ea6d5", false, "ahmed", null, null, null, null, null, "ahmed.png", null, null, null, 2 },
                    { "user2-id", 0, "3ddb1a51-a7ad-4d96-921b-c89d412eaec3", "sara@example.com", false, "elalfy", 31.1325, false, null, 29.9773, "SARA@EXAMPLE.COM", "SARA", "AQAAAAIAAYagAAAAEPLPn+Qq0g6Kknp84uCeeZq2W2Mm07WbWGr+XlsZFkNopjsE7+lxgahPVrnMGdRsUQ==", null, false, "894afc38-8153-431b-98a9-c6472c9ef9f1", false, "sara", null, null, null, null, null, "Sara.png", null, null, null, 2 },
                    { "user3-id", 0, "00107b05-a53d-45f7-ae3d-f4e362d3c627", "omar@example.com", false, "hamada", 30.8141, false, null, 29.8264, "OMAR@EXAMPLE.COM", "OMAR", "AQAAAAIAAYagAAAAEBc3PnJjbX272Z/Bc+RbxqneecYMldhN7+zAWS+Z28uW0ZjCXttovpUbLoejz1qAtA==", null, false, "3c5afa6c-2677-48bb-88e3-dff26976d73e", false, "omar", null, null, null, null, null, "Omar.png", null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "role-admin-id", null, "Admin", "ADMIN" },
                    { "role-superadmin-id", null, "SuperAdmin", "SUPERADMIN" },
                    { "role-user-id", null, "User", "USER" },
                    { "role-worker-id", null, "Worker", "WORKER" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "role-superadmin-id", "superadmin-id" },
                    { "role-user-id", "user1-id" },
                    { "role-user-id", "user2-id" },
                    { "role-user-id", "user3-id" },
                    { "role-worker-id", "worker1-id" },
                    { "role-worker-id", "worker2-id" },
                    { "role-worker-id", "worker3-id" }
                });

            migrationBuilder.InsertData(
                table: "crafts",
                columns: new[] { "CraftId", "CraftName", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "Plumbing", null, null, null, null, null, null, null, null },
                    { 2, "Electrical", null, null, null, null, null, null, null, null },
                    { 3, "Carpentry", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "tools",
                columns: new[] { "Id", "Description", "Image", "Name", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "Heavy-duty hammer", "hammer.png", "Hammer", null, null, null, null, null, null, null, null },
                    { 2, "Multi-purpose screwdriver", "screwdriver.png", "Screwdriver", null, null, null, null, null, null, null, null },
                    { 3, "Adjustable wrench", "wrench.png", "Wrench", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CraftId", "Email", "EmailConfirmed", "Governorate", "LastName", "LockoutEnabled", "LockoutEnd", "Nationalnumber", "NormalizedEmail", "NormalizedUserName", "NumberOfOperation", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StartingDate", "TwoFactorEnabled", "UserName", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "image", "modifiedDatetime", "modifiedbyId", "modifiedbyName", "type" },
                values: new object[,]
                {
                    { "worker1-id", 0, "699c3ba6-c447-498e-87f8-8cb45219fe72", 1, "mustafa@example.com", false, "Cairo", "hamed", false, null, 123456789, "MUSTAFA@EXAMPLE.COM", "MUSTAFA", 10, "AQAAAAIAAYagAAAAEJ8XdMEZU7ExZYpwZc0vQpPKZsdcbDiky+Ibva4t8ETYg3QJRfvMrkefLG8wTUu5jw==", null, false, "1e3308a0-a6f4-4569-b879-6ea10f557ffd", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "mustafa", null, null, null, null, null, "Mustafa.png", null, null, null, 3 },
                    { "worker2-id", 0, "960904a4-b3e7-4610-9bbb-06a7452bc1e3", 1, "mohamed@example.com", false, "Alexandria", "yousry", false, null, 987654321, "MOHAMED@EXAMPLE.COM", "MOHAMED", 20, "AQAAAAIAAYagAAAAEI+1mGys3BtrL5kmgo8DCm4Y7oQr+ey37dyR4xHfGaLSeznbLakl9Q9xKbL9MXDnpw==", null, false, "03476476-9e0f-48e5-b55e-537cf697ce22", new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "mohamed", null, null, null, null, null, "Mohamed.png", null, null, null, 3 },
                    { "worker3-id", 0, "84afdfcc-5738-4d09-b059-2962e9c1d89b", 2, "fatma@example.com", false, "Giza", "yassin", false, null, 1122334455, "FATMA@EXAMPLE.COM", "FATMA", 15, "AQAAAAIAAYagAAAAELuwjzTUjm5zn5rGTA2ROTAnQbuOHGaFLNxYljvX6B6IEJlunl91Ia5ymZi3nG4Wgw==", null, false, "e645ae7a-cb24-468b-ace5-31f0f1c66253", new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "fatma", null, null, null, null, null, "Fatma.png", null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "sizes",
                columns: new[] { "Id", "Price", "Stock", "ToolId", "ToolSize", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, 100.0, 20, 2, 10.5, null, null, null, null, null, null, null, null },
                    { 2, 150.0, 15, 3, 12.5, null, null, null, null, null, null, null, null },
                    { 3, 200.0, 10, 3, 15.0, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "cards",
                columns: new[] { "Id", "BuyerId", "Quantity", "SaleId", "SizeId", "ToolId", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "user1-id", 2, 1, 1, 1, null, null, null, null, null, null, null, null },
                    { 2, "user2-id", 3, 2, 2, 2, null, null, null, null, null, null, null, null },
                    { 3, "user2-id", 5, 3, 3, 3, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "Commision", "ConfirmDate", "ForwardDate", "UserId", "Value", "WorkerId", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName", "reviewId" },
                values: new object[,]
                {
                    { 1, 10.0, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1-id", 1500.5, "worker1-id", null, null, null, null, null, null, null, null, 1 },
                    { 2, 8.0, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2-id", 800.75, "worker2-id", null, null, null, null, null, null, null, null, 2 },
                    { 3, 9.5, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3-id", 1000.25, "worker3-id", null, null, null, null, null, null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "Id", "Comment", "OrderId", "Rate", "UserId", "WorkerId", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "Great service, very satisfied!", 1, 4.5f, "user1-id", "worker1-id", null, null, null, null, null, null, null, null },
                    { 2, "Good job, but a bit delayed.", 2, 4f, "user2-id", "worker2-id", null, null, null, null, null, null, null, null },
                    { 3, "Excellent service, highly recommended!", 3, 5f, "user3-id", "worker3-id", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "sales",
                columns: new[] { "Id", "Address", "CardId", "Date", "DeliveryState", "OrderState", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "123 Main St, Cairo", 1, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", "Completed", null, null, null, null, null, null, null, null },
                    { 2, "456 Elm St, Alexandria", 2, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "Processing", null, null, null, null, null, null, null, null },
                    { 3, "789 Oak St, Giza", 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", "Shipped", null, null, null, null, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_CraftId",
                table: "ApplicationUser",
                column: "CraftId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserTool_toolsId",
                table: "ApplicationUserTool",
                column: "toolsId");

            migrationBuilder.CreateIndex(
                name: "IX_cards_BuyerId",
                table: "cards",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_cards_SizeId",
                table: "cards",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_cards_ToolId",
                table: "cards",
                column: "ToolId");

            migrationBuilder.CreateIndex(
                name: "IX_chats_ReceiverId",
                table: "chats",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_chats_SenderId",
                table: "chats",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_WorkerId",
                table: "orders",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_OrderId",
                table: "reviews",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_reviews_UserId",
                table: "reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_WorkerId",
                table: "reviews",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_CardId",
                table: "sales",
                column: "CardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sizes_ToolId",
                table: "sizes",
                column: "ToolId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWorker_workersId",
                table: "UserWorker",
                column: "workersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserTool");

            migrationBuilder.DropTable(
                name: "chats");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "UserWorker");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "cards");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "sizes");

            migrationBuilder.DropTable(
                name: "crafts");

            migrationBuilder.DropTable(
                name: "tools");
        }
    }
}
