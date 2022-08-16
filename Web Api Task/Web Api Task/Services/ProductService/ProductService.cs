using Web_Api_Task.Models;
using Web_Api_Task.Repositories.ProductRepo;
using Web_Api_Task.Services.ProductService;

namespace Web_Api_Task.Services.ProductService
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> getAll()
        {
            return productRepository.getAll();
        }
        public Product getById(int id)
        {
            return productRepository.getById(id);
        }
        public Product getByName(string name)
        {
            return productRepository.getByName(name);
        }
        public void delete(int id)
        {
            productRepository.delete(id);
        }
        public void create(Product product)
        {
            productRepository.create(product);
        }
        public void update(int id, Product product)
        {
            productRepository.update(id, product);
        }

    }
}
