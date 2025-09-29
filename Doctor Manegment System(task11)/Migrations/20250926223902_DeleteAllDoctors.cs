using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor_Manegment_System_task11_.Migrations
{
    /// <inheritdoc />
    public partial class DeleteAllDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Doctors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
