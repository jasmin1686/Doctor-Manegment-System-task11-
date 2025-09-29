 namespace Doctor_Manegment_System_task11_.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public string PatientName { get; internal set; }
    }
}

