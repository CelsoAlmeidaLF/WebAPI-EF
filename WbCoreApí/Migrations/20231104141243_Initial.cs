using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WbCoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_DESPESA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DsDespesa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VlrDespesa = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    DtVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DtCriação = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DtAlteração = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlExclusão = table.Column<bool>(type: "bit", nullable: false),
                    DtExclusão = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DESPESA", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_DESPESA");
        }
    }
}
