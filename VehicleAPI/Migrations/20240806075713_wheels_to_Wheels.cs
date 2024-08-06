using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAPI.Migrations
{
    /// <inheritdoc />
    public partial class wheels_to_Wheels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "wheels",
                table: "Cars",
                newName: "Wheels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wheels",
                table: "Cars",
                newName: "wheels");
        }
    }
}
