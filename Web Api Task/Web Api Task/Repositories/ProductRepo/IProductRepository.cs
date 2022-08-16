using Web_Api_Task.Models;

namespace Web_Api_Task.Repositories.ProductRepo
{
    public interface IProductRepository
    {
        List<Product> getAll();
        Product getById(int id);
        Product getByName(string name);
        void delete(int id);
        void create(Product product);
        void update(int id, Product product);
    }
}
