using Web_Api_Task.Models;
namespace Web_Api_Task.Repositories.CategoryRepo
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Create(Category category);
        void Update(int id,Category category);
        void Delete(int id);
    }
}
