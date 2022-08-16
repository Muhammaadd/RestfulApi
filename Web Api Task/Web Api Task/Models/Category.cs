using System.ComponentModel.DataAnnotations;

namespace Web_Api_Task.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        public string Name { get; set; }
        ////[System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Product>? Products { get; set; }
    }
}
