using Doctor_Appointment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doctor_Appointment.Controllers
{
    public class AppointmentController : Controller
    {
        static List<AppointmentModel> appointments = new List<AppointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }

        public IActionResult Create()
        {
            return View();
        } 
        
        public IActionResult Details(AppointmentModel appointment) 
        {
            appointments.Add(appointment);
            return View("Details", appointment);
        }
    }
}
