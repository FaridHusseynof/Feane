using System.ComponentModel.DataAnnotations;

namespace Feane.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password), ErrorMessage = "Your passwords doesn't match.")]
        public string CheckPassword { get; set; }
    }
}
