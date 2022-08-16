using Web_Api_Task.Models;

namespace Web_Api_Task.Repositories.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        DBContext dbContext;
        public ProductRepository(DBContext dBContext)
        {
            dbContext = dBContext;
        }
        public List<Product> getAll()
        {
            return dbContext.product.ToList();
        }
        public Product getById(int id)
        {
            return dbContext.product.FirstOrDefault(n => n.Id == id);
        }
        public Product getByName(string name)
        {
            return dbContext.product.FirstOrDefault(n => n.Name == name);
        }
        public void delete(int id)
        {
            dbContext.product.Remove(getById(id));
            dbContext.SaveChanges();
        }
        public void create(Product product)
        {
            dbContext.product.Add(product);
            dbContext.SaveChanges();

        }
        public void update(int id, Product product)
        {
            Product oldproduct = getById(id);
            oldproduct.Name = product.Name;
            oldproduct.Price = product.Price;
            oldproduct.Description = product.Description;
            dbContext.SaveChanges();
        }

    }
}
