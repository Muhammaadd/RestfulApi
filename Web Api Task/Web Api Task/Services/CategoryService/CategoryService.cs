using Web_Api_Task.Repositories.CategoryRepo;
using Web_Api_Task.Models;
using Microsoft.EntityFrameworkCore;
using Web_Api_Task.DTO.CategoryDto;
namespace Web_Api_Task.Services.CategoryService
{
    public class CategoryService:ICategoryService
    {
        ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }
        public List<CategoryAndProduct> GetAllCategories()
        {
            List<Category> categories = GetAll();
            List<CategoryAndProduct> categoriesAndProducts = new List<CategoryAndProduct>();
            List<CustomProduct> products;
            foreach (Category category in categories)
            {
                products = new List<CustomProduct>();
                foreach (Product product in category.Products)
                {
                    products.Add(new CustomProduct() { Id = product.Id, Name = product.Name });
                }
                categoriesAndProducts.Add(new CategoryAndProduct() { Id = category.Id, Name = category.Name,Products=products });
            }
            return categoriesAndProducts;
        }
        public Category GetById(int id)
        {
            return categoryRepository.GetById(id);
        }
        public CategoryAndProduct GetCategoryById(int id)
        {
            Category category = GetById(id);
            CategoryAndProduct categoryAndProduct = new CategoryAndProduct();
            categoryAndProduct.Id = category.Id;
            categoryAndProduct.Name = category.Name;
            foreach(Product product in category.Products)
            {
                categoryAndProduct.Products.Add(new CustomProduct() { Id = product.Id, Name = product.Name });
            }
            return categoryAndProduct;
        }

        public void Create(Category category) 
        {
            categoryRepository.Create(category);
        }
        public void Update(int id, Category category)
        {
            categoryRepository.Update(id, category);
        }
        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }
    }
}
