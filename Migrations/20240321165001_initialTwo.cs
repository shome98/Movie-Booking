using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_Booking.Migrations
{
    /// <inheritdoc />
    public partial class initialTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CinemaName",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CinemaName",
                table: "Cinemas");
        }
    }
}
