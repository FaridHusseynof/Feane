using System.ComponentModel.DataAnnotations;

namespace Feane.Areas.AdminPanel.ViewModels
{
    public class CreateVM
    {
        [Required]
        public int price { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public string? imageURL { get; set; }
        public IFormFile? imageFile { get; set; }
    }
}
