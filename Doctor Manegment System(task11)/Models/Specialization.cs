namespace Doctor_Manegment_System_task11_.Models
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
