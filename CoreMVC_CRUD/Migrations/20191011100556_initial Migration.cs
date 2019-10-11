using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreMVC_CRUD.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    FullName = table.Column<string>(nullable: true),
                    EmpCode = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
