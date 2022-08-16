using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Api_Task.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string? Description { get; set; }
        [ForeignKey("category")]
        public int? Cat_id { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Category? category { get; set; }

    }
}
