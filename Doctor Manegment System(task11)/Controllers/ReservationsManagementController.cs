using Doctor_Manegment_System_task11_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Doctor_Manegment_System_task11_.Controllers
{
    public class ReservationsManagementController : Controller
    {
        private ApplicationDbContext _dbcontext = new ApplicationDbContext();

        public IActionResult Index()
        {
            var Appointment = _dbcontext.Appointments.Include(e => e.Doctor).Include(e => e.Patient).ToList();
            return View(Appointment);
        }
    }
}
