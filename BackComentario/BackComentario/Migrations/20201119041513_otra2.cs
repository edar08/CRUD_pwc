﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BackComentario.Migrations
{
    public partial class otra2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Texto",
                table: "Comentario",
                newName: "Corazon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Corazon",
                table: "Comentario",
                newName: "Texto");
        }
    }
}
