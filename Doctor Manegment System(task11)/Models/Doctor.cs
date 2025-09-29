
namespace Doctor_Manegment_System_task11_.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? phone { get; set; }
        public string? Email { get; set; }
        public string ImageUrl { get; set; }
        public string Descraption { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; } 
        public List<Patient> Patients { get; set; }
        public List <Appointment> Appointments { get; set; }

        internal static object Skip(int v)
        {
            throw new NotImplementedException();
        }
    }
}
