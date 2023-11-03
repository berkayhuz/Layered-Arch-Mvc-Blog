using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuzlabBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class init93 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e0e2cd17-0fe0-4203-9c16-46fa600c56de"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("43d1868f-0c3b-4683-b08d-030bce35fc65"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[] { new Guid("e0e2cd17-0fe0-4203-9c16-46fa600c56de"), new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"), "Deneme Content", "Berkay Huz", new DateTime(2023, 10, 26, 1, 30, 26, 558, DateTimeKind.Local).AddTicks(5960), null, null, new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"), false, null, null, "Asp.Net Core Deneme Makalesi 1", new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("68dfdd6b-a20b-498c-ad1d-b0eb12ae076a"),
                column: "ConcurrencyStamp",
                value: "08c9bc6a-b61b-4925-94c0-f947d0c0ceed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9c1bd465-4ff6-437e-b43e-1f848fd26d99"),
                column: "ConcurrencyStamp",
                value: "a66b6d0c-3b0a-44e9-a760-668f446d2739");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cad1bc04-44bf-44b7-ade1-4d6b3fffcba7"),
                column: "ConcurrencyStamp",
                value: "b62e42c8-ee41-4132-9d02-232c00e4f9eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31feb16f-8c01-4e22-9a6f-df79b7e5582a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e85ce13-039d-4e14-b935-391df11e7f97", "AQAAAAIAAYagAAAAEEviNBJR+XPTCug1ae8wURz8hishBCdLww9VvyTTlypL/oX9ZsP+1fbVBIhnU0OQcw==", "8eb15c98-3c48-474b-ba62-cbc98d69b2a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b3402ec4-ab10-4f89-bd4a-9d95b601316f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31bdc8d0-423b-4904-9b02-df6f90c208a7", "AQAAAAIAAYagAAAAEABkCVRcoD1hzvH09oloknBVF89hkhXfrMC3C5uXT2wT5MFDvs1HKVNsHFiCoPF7Ow==", "a6a3428c-69c8-4544-8d5e-712a3d30854b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f679be0-ca72-4dfc-b2bf-66e375f9cbc0"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 1, 30, 26, 558, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5783a0a4-0c35-4f26-a466-05636f9fee2c"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 1, 30, 26, 559, DateTimeKind.Local).AddTicks(1436));
        }
    }
}
