using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Doctor_Manegment_System_task11_.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentDateToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "Appointments");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Descraption", "Email", "ImageUrl", "Name", "SpecializationId", "phone" },
                values: new object[] { 3, "Orthopedic surgeon specialized in sports injuries.", "mohamed.ali@example.com", "doctor3.jpg", "DrMohamedAli", 3, "01122334455" });
        }
    }
}
