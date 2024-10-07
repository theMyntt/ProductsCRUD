using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCRUD.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TBL_PRODUTOS",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TX_NOME = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TX_PRECO = table.Column<double>(type: "double", nullable: false),
                    TX_TIMESTAMP = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PRODUTOS", x => x.ID_PRODUTO);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PRODUTOS_TX_NOME",
                table: "TBL_PRODUTOS",
                column: "TX_NOME",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_PRODUTOS");
        }
    }
}
