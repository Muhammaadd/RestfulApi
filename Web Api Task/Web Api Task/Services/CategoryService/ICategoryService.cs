using Web_Api_Task.Repositories.CategoryRepo;
using Web_Api_Task.DTO.CategoryDto;
namespace Web_Api_Task.Services.CategoryService
{
    public interface ICategoryService:ICategoryRepository
    {
        List<CategoryAndProduct> GetAllCategories();
        CategoryAndProduct GetCategoryById(int id);
    }
}
