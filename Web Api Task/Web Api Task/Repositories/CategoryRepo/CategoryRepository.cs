using Web_Api_Task.Models;
using Microsoft.EntityFrameworkCore;
namespace Web_Api_Task.Repositories.CategoryRepo
{
    public class CategoryRepository:ICategoryRepository
    {
        DBContext dbContext;
        public CategoryRepository(DBContext dBContext)
        {
            this.dbContext = dBContext;
        }

        public List<Category> GetAll()
        {
            return dbContext.Category.Include(n=>n.Products).ToList();
        }
        public Category GetById(int id)
        {
            return dbContext.Category.Include(n=>n.Products).FirstOrDefault(n=>n.Id==id);
        }
        public void Create(Category category)
        {
            dbContext.Category.Add(category);
            dbContext.SaveChanges();
        }
        public void Update(int id,Category category)
        {
            Category oldCategory = GetById(id);
            oldCategory.Name = category.Name;
            dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            dbContext.Category.Remove(GetById(id));
            dbContext.SaveChanges();

        }
    }
}
