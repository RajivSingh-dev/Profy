using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "user",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "user",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "user",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "user");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "user");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "user");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "user");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "user");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "user");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "user");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "user");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "user");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "user");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "user");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "user");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "user");
        }
    }
}
