using Microsoft.EntityFrameworkCore.Migrations;

namespace BackComentario.Migrations
{
    public partial class borrarciudad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Comentario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Comentario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
