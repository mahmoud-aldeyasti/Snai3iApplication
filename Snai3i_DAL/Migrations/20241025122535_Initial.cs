﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Snai3i_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    type = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
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
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    State = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
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
                    BuyerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cards", x => x.Id);
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
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id");
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    deletedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deleteddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedbyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedbyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifiedDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sales_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_sales_ApplicationUser_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_sales_cards_CardId",
                        column: x => x.CardId,
                        principalTable: "cards",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "image", "modifiedDatetime", "modifiedbyId", "modifiedbyName", "type" },
                values: new object[,]
                {
                    { "superadmin-id", 0, "82faf0c1-8c22-4af0-a136-0632e4b0f508", "kholoud@sani3i.com", true, "Salama", null, false, null, null, "KHOLOUD@SANI3I.COM", "KHOLOUD", "AQAAAAIAAYagAAAAENxK54JiujoFjv7uusSSpkXlftPPgxcCuvsRE2/6ZhtQ8bf6xcHoitqmXGxKTHffQw==", "0100000000", true, "cd2b1362-5270-476a-80af-75309071af29", false, "kholoud", null, null, null, null, null, "Khouloud.png", null, null, null, "User" },
                    { "user1-id", 0, "c761d2ba-9718-468f-8e98-56f2fb83e797", "ahmed@example.com", true, "Ragab", 31.235700000000001, false, null, 30.0444, "AHMED@EXAMPLE.COM", "AHMED", "AQAAAAIAAYagAAAAEELT39oLmpgkQFNs4mmL9m+CO/yBwK3lJ6AFyC4w6ItU/7I2JSg2yuECj0smnE1SPA==", null, true, "a33b538b-a261-4267-9475-06cf4cf8efac", false, "ahmed", null, null, null, null, null, "ahmed.png", null, null, null, "User" },
                    { "user2-id", 0, "3328b373-14e1-4b70-a15e-fb39f89395ea", "sara@example.com", true, "elalfy", 31.1325, false, null, 29.9773, "SARA@EXAMPLE.COM", "SARA", "AQAAAAIAAYagAAAAEHsVQdqs8g5D4qduEgOxhMI1yIlODoGT2EK5TQipxPIc0xng77YrW1iEmtwH7nZ91Q==", null, true, "83fe910c-beb9-4d59-9067-1736ca8f5bdf", false, "sara", null, null, null, null, null, "Sara.png", null, null, null, "User" },
                    { "user3-id", 0, "8630eed4-518d-42f8-bcc5-3b549ca223e1", "omar@example.com", true, "hamada", 30.8141, false, null, 29.8264, "OMAR@EXAMPLE.COM", "OMAR", "AQAAAAIAAYagAAAAEHvBilQGEXsObCYxV18GnAz56LS0twbnyxjV9yS5FAzJIsBkCrltd5oDPkPEqbxz9Q==", null, true, "90d108f3-8634-4c77-af58-4c157e8eb15e", false, "omar", null, null, null, null, null, "Omar.png", null, null, null, "User" }
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
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "superadmin-id", "superadmin-id" },
                    { 2, "first_name", "kholoud", "superadmin-id" },
                    { 3, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "superadmin-id" },
                    { 4, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "SuperAdmin", "superadmin-id" },
                    { 5, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "user1-id", "user1-id" },
                    { 6, "first_name", "ahmed", "user1-id" },
                    { 7, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "user1-id" },
                    { 8, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "user2-id", "user2-id" },
                    { 9, "first_name", "sara", "user2-id" },
                    { 10, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "user2-id" },
                    { 11, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "user3-id", "user3-id" },
                    { 12, "first_name", "omar", "user3-id" },
                    { 13, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "user3-id" },
                    { 14, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "worker1-id", "worker1-id" },
                    { 15, "first_name", "mustafa", "worker1-id" },
                    { 16, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Worker", "worker1-id" },
                    { 17, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "worker2-id", "worker2-id" },
                    { 18, "first_name", "mohamed", "worker2-id" },
                    { 19, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Worker", "worker2-id" },
                    { 20, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", "worker3-id", "worker3-id" },
                    { 21, "first_name", "fatma", "worker3-id" },
                    { 22, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Worker", "worker3-id" }
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
                columns: new[] { "CraftId", "CraftName", "PictureUrl", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "Plumbing", "service-1.jpg", null, null, null, null, null, null, null, null },
                    { 2, "Electrical", "service-2.jpg", null, null, null, null, null, null, null, null },
                    { 3, "Carpentry", "service-3.jpg", null, null, null, null, null, null, null, null }
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
                    { "worker1-id", 0, "9c90f47d-c8a5-4e34-9574-5b4d827c2aff", 1, "mustafa@example.com", true, "Cairo", "hamed", false, null, 123456789, "MUSTAFA@EXAMPLE.COM", "MUSTAFA", 10, "AQAAAAIAAYagAAAAECu7u/lQb0e2e1fkbW4+DIfQUnoRrXC9LqEOiRVXZgsYr4wMepE9y3wlSk2nbslGig==", null, true, "9788ab8c-e989-4fcd-989c-6b8ad36cd8b7", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "mustafa", null, null, null, null, null, "Mustafa.png", null, null, null, "Worker" },
                    { "worker2-id", 0, "97b90497-b27d-454e-a2ff-454015e42c58", 1, "mohamed@example.com", true, "Alexandria", "yousry", false, null, 987654321, "MOHAMED@EXAMPLE.COM", "MOHAMED", 20, "AQAAAAIAAYagAAAAENpyYPdXr/fBFQl1RILGyOCd4sQEOeewq69N1SMPJe76YVKRoLSMSl5nE5p9g1+f3g==", null, true, "f7206c4f-0488-4a16-9a3b-cade71487b85", new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "mohamed", null, null, null, null, null, "Mohamed.png", null, null, null, "Worker" },
                    { "worker3-id", 0, "86c2e458-6000-443c-b799-7f73715b70aa", 2, "fatma@example.com", true, "Giza", "yassin", false, null, 1122334455, "FATMA@EXAMPLE.COM", "FATMA", 15, "AQAAAAIAAYagAAAAEG3bCz2dgc5z08ny9rKfPnlZV0LsSdlSclqbbDFr+fwOpaXLT+ZuaSl6GyJMK+J3Tg==", null, true, "c9c4075c-a402-4a97-85af-e4792ebff1a1", new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "fatma", null, null, null, null, null, "Fatma.png", null, null, null, "Worker" }
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
                columns: new[] { "Id", "BuyerId", "Quantity", "SizeId", "ToolId", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "user1-id", 2, 1, 1, null, null, null, null, null, null, null, null },
                    { 2, "user2-id", 3, 2, 2, null, null, null, null, null, null, null, null },
                    { 3, "user2-id", 5, 3, 3, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "Commision", "ConfirmDate", "ForwardDate", "State", "UserId", "Value", "WorkerId", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName", "reviewId" },
                values: new object[,]
                {
                    { 1, 10.0, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user1-id", 1500.5, "worker1-id", null, null, null, null, null, null, null, null, 1 },
                    { 2, 8.0, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user2-id", 800.75, "worker2-id", null, null, null, null, null, null, null, null, 2 },
                    { 3, 9.5, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user3-id", 1000.25, "worker3-id", null, null, null, null, null, null, null, null, 3 }
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
                columns: new[] { "Id", "Address", "CardId", "Date", "DeliveryState", "OrderState", "UserId", "WorkerId", "createdbyId", "createdbyName", "createddatetime", "deletedbyId", "deleteddatetime", "modifiedDatetime", "modifiedbyId", "modifiedbyName" },
                values: new object[,]
                {
                    { 1, "123 Main St, Cairo", 1, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delivered", "Completed", "user1-id", "worker1-id", null, null, null, null, null, null, null, null },
                    { 2, "456 Elm St, Alexandria", 2, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "Processing", "user3-id", "worker3-id", null, null, null, null, null, null, null, null },
                    { 3, "789 Oak St, Giza", 3, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", "Shipped", "user2-id", "worker2-id", null, null, null, null, null, null, null, null }
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
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_UserId",
                table: "sales",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_WorkerId",
                table: "sales",
                column: "WorkerId");

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
