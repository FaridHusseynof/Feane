using System.ComponentModel.DataAnnotations;

namespace Feane.Models
{
    public class Product: BaseModel
    {
        [Required]
        public int Price { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
