using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Empleados_core_CRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Empleado_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Empleado_Cod = table.Column<string>(type: "nvarchar(45)", nullable: true),
                    Empleado_Nomvre = table.Column<string>(type: "nvarchar(70)", nullable: true),
                    Empleado_Apellido = table.Column<string>(type: "nvarchar(70)", nullable: true),
                    Empleado_Correo = table.Column<string>(type: "nvarchar(45)", nullable: true),
                    Empleado_Departamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Empleado_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
