using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectName.Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetail_User_idUserDetail",
                table: "UserDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_idRole",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_idUser",
                table: "UserRole");

            migrationBuilder.RenameColumn(
                name: "idRole",
                table: "UserRole",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "idUser",
                table: "UserRole",
                newName: "roleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_idRole",
                table: "UserRole",
                newName: "IX_UserRole_userId");

            migrationBuilder.RenameColumn(
                name: "idUserDetail",
                table: "UserDetail",
                newName: "userDetailId");

            migrationBuilder.RenameColumn(
                name: "idUser",
                table: "User",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "nameRole",
                table: "Role",
                newName: "roleName");

            migrationBuilder.RenameColumn(
                name: "idRole",
                table: "Role",
                newName: "roleId");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_userId",
                table: "Products",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetail_User_userDetailId",
                table: "UserDetail",
                column: "userDetailId",
                principalTable: "User",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_roleId",
                table: "UserRole",
                column: "roleId",
                principalTable: "Role",
                principalColumn: "roleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_userId",
                table: "UserRole",
                column: "userId",
                principalTable: "User",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetail_User_userDetailId",
                table: "UserDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_roleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_userId",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UserRole",
                newName: "idRole");

            migrationBuilder.RenameColumn(
                name: "roleId",
                table: "UserRole",
                newName: "idUser");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_userId",
                table: "UserRole",
                newName: "IX_UserRole_idRole");

            migrationBuilder.RenameColumn(
                name: "userDetailId",
                table: "UserDetail",
                newName: "idUserDetail");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "User",
                newName: "idUser");

            migrationBuilder.RenameColumn(
                name: "roleName",
                table: "Role",
                newName: "nameRole");

            migrationBuilder.RenameColumn(
                name: "roleId",
                table: "Role",
                newName: "idRole");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetail_User_idUserDetail",
                table: "UserDetail",
                column: "idUserDetail",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_idRole",
                table: "UserRole",
                column: "idRole",
                principalTable: "Role",
                principalColumn: "idRole",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_idUser",
                table: "UserRole",
                column: "idUser",
                principalTable: "User",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
