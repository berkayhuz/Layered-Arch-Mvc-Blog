using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuzlabBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class init923 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("43d1868f-0c3b-4683-b08d-030bce35fc65"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("2ec94c0a-3aa9-4dc8-9c73-970a9adf0c1c"), new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"), "Deneme Content", "Berkay Huz", new DateTime(2023, 11, 2, 17, 38, 12, 926, DateTimeKind.Local).AddTicks(6679), null, null, new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"), false, null, null, "Asp.Net Core Deneme Makalesi 1", new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("68dfdd6b-a20b-498c-ad1d-b0eb12ae076a"),
                column: "ConcurrencyStamp",
                value: "e6b73cb0-4e68-4817-acb1-89ef0ec5ad97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9c1bd465-4ff6-437e-b43e-1f848fd26d99"),
                column: "ConcurrencyStamp",
                value: "8e196bd1-c3b2-45bf-aaf2-4899f27c9d88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cad1bc04-44bf-44b7-ade1-4d6b3fffcba7"),
                column: "ConcurrencyStamp",
                value: "e4d49cbd-2729-42eb-864c-2f9dc2e27227");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31feb16f-8c01-4e22-9a6f-df79b7e5582a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "562c2199-e7b2-48b6-b641-41f6b218801c", "AQAAAAIAAYagAAAAEEPos4H/1f0I/ygJRHDis6Ssl2RiJFiqPSkzKKFv/bIi6UQiJBNuSi+SGkrrdhSb4Q==", "05764baa-21ac-4cc1-b901-0fe77bed1ac3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0572e551-68e4-4760-86dd-fe2593f7cb7c", "AQAAAAIAAYagAAAAEM9b019bAjjDTRdiwmBmbIOSLmX8zl8oFtAjrCxIOqE19c9qRGd4zyo8rubBYsk3BA==", "fe2f0b19-5a51-4a68-a5b2-441cf27e9a16" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 17, 38, 12, 928, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 17, 38, 12, 928, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2ec94c0a-3aa9-4dc8-9c73-970a9adf0c1c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("43d1868f-0c3b-4683-b08d-030bce35fc65"), new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"), "Deneme Content", "Berkay Huz", new DateTime(2023, 11, 2, 7, 8, 39, 548, DateTimeKind.Local).AddTicks(8763), null, null, new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"), false, null, null, "Asp.Net Core Deneme Makalesi 1", new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("68dfdd6b-a20b-498c-ad1d-b0eb12ae076a"),
                column: "ConcurrencyStamp",
                value: "4198aca5-f268-4863-9c9b-47bc125e4826");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9c1bd465-4ff6-437e-b43e-1f848fd26d99"),
                column: "ConcurrencyStamp",
                value: "4ede6b52-c92f-48fc-8523-1f0db56777df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cad1bc04-44bf-44b7-ade1-4d6b3fffcba7"),
                column: "ConcurrencyStamp",
                value: "aa63075a-095d-469a-aefe-2d8f66fa218e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31feb16f-8c01-4e22-9a6f-df79b7e5582a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c727e304-6f10-4669-a400-86537c0bafc3", "AQAAAAIAAYagAAAAEEG51TLXS3j955vVCujb1IQMQTJ5OUR2qD04MQBWSXbNmUNOgS3Jjmt7ZyGO+GgWQQ==", "eed504c0-3c63-4f70-ae0d-948ad125b24d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90fdae09-e6a8-43be-ac53-67972595f9f4", "AQAAAAIAAYagAAAAENgXEgo5yhrWp4Wu0A8p/3WkGUcUdGsuSvrOXvZPWxki3PgGv+Izxm3kLlohACCmqw==", "294c91dc-53d8-49ff-9200-b3aa4578c2b1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 7, 8, 39, 549, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 7, 8, 39, 549, DateTimeKind.Local).AddTicks(3363));
        }
    }
}
