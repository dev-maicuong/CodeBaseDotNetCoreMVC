using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectName.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idUser",
                table: "UserDetail");

            migrationBuilder.DropColumn(
                name: "idUserDetail",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "UserDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idUserDetail",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
