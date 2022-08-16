using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_Task.Models;
using Web_Api_Task.Services.CategoryService;

namespace Web_Api_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(categoryService.GetAllCategories());
        }
        [HttpGet("{id}",Name ="GetCatById")]
        public IActionResult GetById(int id)
        {
            return Ok(categoryService.GetCategoryById(id));
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            categoryService.Create(category);
            string? url = Url.Link("GetCatById",new { id = category.Id });
            return Created(url, category);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,Category category)
        {
            categoryService.Update(id, category);
            return StatusCode(StatusCodes.Status204NoContent);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            categoryService.Delete(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }

    }
}
