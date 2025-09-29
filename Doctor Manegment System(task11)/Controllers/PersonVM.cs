using Doctor_Manegment_System_task11_.Models;

namespace Doctor_Manegment_System_task11_.Controllers
{
    internal class PersonVM
    {
        public IQueryable<Doctor> BookanAppointment { get; set; }
        public List<Doctor> Doctors { get; set; }
       
    }
}