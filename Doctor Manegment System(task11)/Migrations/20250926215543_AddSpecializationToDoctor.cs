using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Doctor_Manegment_System_task11_.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecializationToDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

           

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Descraption", "Email", "ImageUrl", "Name", "Specialization", "phone" },
                values: new object[,]
                {
                    { 111, "Specialist in Cardiology with 10 years of experience.", "ahmed.hassan@example.com", "doctor1.jpg", "DrAhmedHassan", "Cardiology", "01012345678" },
                    { 222, "Dermatologist focusing on skin and hair treatments.", "gamal.mahmoud@example.com", "doctor2.jp", "DrGamalMahmoud", "Dermatology", "01098765432" },
                    { 333, "Orthopedic surgeon specialized in sports injuries.", "mohamed.ali@example.com", "doctor3.jpg", "Dr. Mohamed Ali", "Pediatrics", "01122334455" },
                    { 444, "Pediatrician with expertise in child nutrition and growth.", "nour.eldin@example.com", "doctor4.jpg", "Dr. Nour El-Din", "Dentistry", "01234567890" },
                    { 555, "Psychiatrist specialized in cognitive behavioral therapy.", "huda.khaled@example.com", "doctor5.jpg", "Dr. Khaled Nour", "Psychiatry", "01555667788" },
                    { 666, "Dentist focusing on cosmetic and restorative dentistry.", "karim.mostafa@example.com", "doctor6.jpg", "Dr. Karim Mostafa", "Orthopedics", "01044455566" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Doctors");

            

            
        }
    }
}
