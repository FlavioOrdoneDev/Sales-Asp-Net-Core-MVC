using Microsoft.EntityFrameworkCore.Migrations;

namespace Sales_ASPNET_Core.Migrations
{
    public partial class CorrecaoCampoInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "SalesRecord",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "SalesRecord",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
