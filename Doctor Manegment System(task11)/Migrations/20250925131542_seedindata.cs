using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Doctor_Manegment_System_task11_.Migrations
{
    /// <inheritdoc />
    public partial class seedindata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctortId",
                table: "Patients");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Descraption", "Email", "ImageUrl", "Name", "phone" },
                values: new object[,]
                {
                    { 1, "Specialist in Cardiology with 10 years of experience.", "ahmed.hassan@example.com", "/images/doctor1.jpg", "Dr. Ahmed Hassan", "01012345678" },
                    { 2, "Dermatologist focusing on skin and hair treatments.", "sara.mahmoud@example.com", "/images/doctor2.jpg", "Dr. Sara Mahmoud", "01098765432" },
                    { 3, "Orthopedic surgeon specialized in sports injuries.", "mohamed.ali@example.com", "/images/doctor3.jpg", "Dr. Mohamed Ali", "01122334455" },
                    { 4, "Pediatrician with expertise in child nutrition and growth.", "nour.eldin@example.com", "/images/doctor4.jpg", "Dr. Nour El-Din", "01234567890" },
                    { 5, "Psychiatrist specialized in cognitive behavioral therapy.", "huda.khaled@example.com", "/images/doctor5.jpg", "Dr. Huda Khaled", "01555667788" },
                    { 6, "Dentist focusing on cosmetic and restorative dentistry.", "karim.mostafa@example.com", "/images/doctor6.jpg", "Dr. Karim Mostafa", "01044455566" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "BirthDate", "DoctorId", "Email", "Name", "phone" },
                values: new object[,]
                {
                    { 7, new DateTime(1987, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "khaled.mostafa@example.com", "KhaledMostafa", "01155556666" },
                    { 8, new DateTime(1990, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "mona.ali@example.com", "MonaAli", "01033334444" },
                    { 9, new DateTime(1995, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "omar.youssef@example.com", "OmarYoussef", "01011112222" },
                    { 10, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "layla.ibrahim@example.com", "LaylaIbrahim", "01277778888" },
                    { 11, new DateTime(1982, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "hassan.fathy@example.com", "HassanFathy", "01599990000" },
                    { 12, new DateTime(1998, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "salma.adel@example.com", "SalmaAdel", "01012121212" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<int>(
                name: "DoctortId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
