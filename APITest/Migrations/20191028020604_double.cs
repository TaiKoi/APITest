using Microsoft.EntityFrameworkCore.Migrations;

namespace APITest.Migrations
{
    public partial class @double : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Length",
                table: "MyDatas",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Length",
                table: "MyDatas",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
