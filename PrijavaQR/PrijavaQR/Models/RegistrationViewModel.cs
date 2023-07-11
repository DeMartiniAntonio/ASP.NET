using System.ComponentModel.DataAnnotations;

namespace PrijavaQR.Models
{
    public class RegistrationViewModel
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? OIB { get; set; }


    }
}
