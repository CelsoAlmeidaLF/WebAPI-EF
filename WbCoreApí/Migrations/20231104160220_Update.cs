using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WbCoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "TB_DESPESA",
                newName: "IdStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdStatus",
                table: "TB_DESPESA",
                newName: "Status");
        }
    }
}
