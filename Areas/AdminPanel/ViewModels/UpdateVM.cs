using System.ComponentModel.DataAnnotations;

namespace Feane.Areas.AdminPanel.ViewModels
{
    public class UpdateVM
    {
        [Required]
        public int price { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public int id_ { get; set; }
        public string? imageURL { get; set; }
        public IFormFile? imageFile { get; set; }
    }
}
