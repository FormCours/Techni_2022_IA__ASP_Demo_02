using System.ComponentModel.DataAnnotations;

namespace Demo_ASP_MVC_02.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
    }

    public class ProductAddViewModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [MaxLength(5000)]
        public string? Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        //[RegularExpression("^[0-9]+(\\,[0-9]{1,2})?$")]
        public double? Price { get; set; }
    }
}
