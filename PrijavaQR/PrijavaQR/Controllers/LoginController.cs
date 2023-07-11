using Microsoft.AspNetCore.Mvc;
using PrijavaQR.Models;
using System.Diagnostics;

namespace PrijavaQR.Controllers
{
    public class LogController : Controller
    {
        private readonly ILogger<LogController> _logger;
        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        public IActionResult Registration()
        {
            var model = new RegistrationViewModel();

            return View(model);
        }

        public IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginM) {

            var model = new LoginViewModel();
            
            if (loginM.Email == "test@gmail.com" && loginM.Password == "test")
            {
                return RedirectToAction("Home", "Home");
            }
            else {
                return View(model);
            }

        }
    }
}
