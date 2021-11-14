using Microsoft.EntityFrameworkCore.Migrations;

namespace UnderControl.Data.Migrations
{
    public partial class DataMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Time",
                table: "MyData",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Temperature",
                table: "MyData",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Time",
                table: "MyData",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "Temperature",
                table: "MyData",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
