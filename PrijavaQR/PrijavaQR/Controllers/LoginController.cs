using Microsoft.AspNetCore.Mvc;
using PrijavaQR.Models;
using System.Diagnostics;
using PrijavaQR.Services;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace PrijavaQR.Controllers
{
    public class LogController : Controller
    {
        private readonly HttpClient httpClient = new HttpClient();

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
        public IActionResult Registration(RegistrationViewModel registrationM)
        {
            var view = new RegistrationViewModel();

            if (registrationM.Email == "test@gmail.com")
            {
                // Prepare the data for the SendEmailUsingTemplate method
                var welcomeMail = new WelcomeMail
                {
                    Name = "Lacy Pollich",

                    Email = "lacy.pollich11@ethereal.email"// Replace this with the desired email address
                };

                // Serialize the data to JSON
                var jsonContent = new StringContent(JsonSerializer.Serialize(welcomeMail), Encoding.UTF8, "application/json");

                var response = httpClient.PostAsync("https://localhost:7011/api/Mail/sendemailusingtemplate", jsonContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("HomeScr", "");

                    // Success handling
                }
                else
                {
                    // Error handling
                    return View(view);

                }
            }
            else
            {
                return RedirectToAction("HomeScr", "");
            }
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginM) {

            var model = new LoginViewModel();
            
            if (loginM.Email == "test@gmail.com" && loginM.Password == "test")
            {
                return RedirectToAction("HomeScr", "");
            }
            else 
            {
                return View(model);
            }

        }
    }
}
