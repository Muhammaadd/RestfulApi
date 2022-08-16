using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Task.Models;
using Web_Api_Task.Services.ProductService;

namespace Web_Api_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            return Ok(productService.getAll());
        }
        [HttpGet("id/{id:int}",Name ="getById")]
        public IActionResult getById(int id)
        {
            Product product = productService.getById(id);
            if (product == null)
                return BadRequest("invalid id");
            return Ok(product);
        }
        [HttpGet("name/{name:regex(.*)}")]
        public IActionResult getByName(string name)
        {
            Product product = productService.getByName(name);
            if (product == null)
                return BadRequest("invalid name");
            return Ok(product);
        }
        [HttpPost]
        public IActionResult create(Product product)
        {
            productService.create(product);
            string url = Url.Link("getById", new { id = product.Id });
            return Created(url,product);
        }
        [HttpPut("{id}")]
        public IActionResult update([FromRoute]int id,Product product)
        {
            productService.update(id,product);
            return StatusCode(StatusCodes.Status204NoContent);
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            productService.delete(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
