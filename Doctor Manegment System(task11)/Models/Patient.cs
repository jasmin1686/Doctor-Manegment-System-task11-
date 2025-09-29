namespace Doctor_Manegment_System_task11_.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? phone { get; set; }
        public string? Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
