namespace Web_Api_Task.DTO.CategoryDto
{
    public class CategoryAndProduct
    {
        public CategoryAndProduct()
        {
            Products = new List<CustomProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CustomProduct> Products { get; set; }
    }
    public class CustomProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
