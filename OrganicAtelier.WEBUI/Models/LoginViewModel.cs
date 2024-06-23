using System.ComponentModel.DataAnnotations;

namespace OrganicAtelier.WEBUI.Models
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
