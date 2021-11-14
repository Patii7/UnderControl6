using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnderControl.Data.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyData",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<double>(nullable: false),
                    Temperature = table.Column<double>(nullable: false),
                    Feeling = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Consistency = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Cervix = table.Column<string>(nullable: true),
                    Bleeding = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Others = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyData", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyData");
        }
    }
}
