using Doctor_Manegment_System_task11_.Data;
using Doctor_Manegment_System_task11_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Doctor_Manegment_System_task11_.Controllers
{
    public class BookanAppointmentController : Controller
    {
        private ApplicationDbContext _dbcontext =new ApplicationDbContext();
        
       public IActionResult BookanAppointment(int Page = 1)
         
        {
            var Doctors = _dbcontext.Doctors.AsQueryable(); 
            var bookApoiment = _dbcontext.Doctors.Include(d => d.Specialization). AsQueryable();
            var totalpage = Math.Ceiling(Doctors.Count() / 3.0);
            var doctors = _dbcontext.Doctors.Include(d => d.Specialization).Skip((Page - 1) * 3).Take(3).ToList();

            ViewBag.totalpage=totalpage;
            ViewBag.currentPage = Page;
            return View(new PersonVM
            {
                BookanAppointment = bookApoiment,
                Doctors = doctors
            });
        }
        public IActionResult CompleteAppointment(int id)
        {
            var Dr = _dbcontext.Doctors.FirstOrDefault(e=>e.Id==id);
           

            return View(Dr);
        }
        [HttpPost]
        public IActionResult CompleteAppointment(int DrId ,string Name, DateTime AppointmentDate, DateTime StartTime)
        {
            var patient = _dbcontext.Patients.FirstOrDefault(p => p.Name == Name && p.DoctorId == DrId);

            if (patient == null)
            {
                
                patient = new Patient
                {
                    Name = Name,
                    DoctorId = DrId
                };
                _dbcontext.Patients.Add(patient);
                _dbcontext.SaveChanges(); 
            }
            var doctor = _dbcontext.Doctors.FirstOrDefault(d => d.Id == DrId);
            if (doctor == null)
            {
                ModelState.AddModelError("", "Doctor not found");
                return View();
            }

            var appointment = new Appointment
            {
              DoctorId = DrId,
                PatientName = Name,
                AppointmentDate = AppointmentDate,
                StartTime = StartTime,
                
            };
            _dbcontext.Appointments.Add(appointment);
            _dbcontext.SaveChanges();
            TempData["SuccessMessage"] = "Your appointment has been successfully completed.";
            return RedirectToAction("CompleteAppointment", new { id = DrId });

            //var dr = _dbcontext.Doctors.FirstOrDefault(d => d.Id == DrId);
            //return View(dr);
        }





    }
}
