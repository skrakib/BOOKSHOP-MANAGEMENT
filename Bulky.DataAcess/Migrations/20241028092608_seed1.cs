using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_orderHeaders_OrderHeaderId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_products_ProductId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderHeaders_AspNetUsers_ApplicationUserId",
                table: "orderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderHeaders",
                table: "orderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails");

            migrationBuilder.RenameTable(
                name: "orderHeaders",
                newName: "OrderHeaders");

            migrationBuilder.RenameTable(
                name: "orderDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_orderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                newName: "IX_OrderHeaders_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_OrderHeaderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderHeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderHeaders",
                table: "OrderHeaders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId",
                principalTable: "OrderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderHeaders",
                table: "OrderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                newName: "orderHeaders");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "orderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "orderHeaders",
                newName: "IX_orderHeaders_ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "orderDetails",
                newName: "IX_orderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "orderDetails",
                newName: "IX_orderDetails_OrderHeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderHeaders",
                table: "orderHeaders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_orderHeaders_OrderHeaderId",
                table: "orderDetails",
                column: "OrderHeaderId",
                principalTable: "orderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_products_ProductId",
                table: "orderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderHeaders_AspNetUsers_ApplicationUserId",
                table: "orderHeaders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
