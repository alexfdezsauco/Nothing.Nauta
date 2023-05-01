using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nothing.Nauta.App.Data.Migrations
{
    public partial class Add_RemainingTime_And_ResetDateTime_To_AccountInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "RemainingTime",
                table: "Accounts",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemainingTime",
                table: "Accounts");
        }
    }
}
