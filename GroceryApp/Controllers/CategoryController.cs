using GroceryApp.Models;
using GroceryApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = categoryService.GetAllCategories();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = categoryService.GetCategoryById(id);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(Categories category)
        {
            var data = categoryService.AddCategory(category);
            return Ok(data);
        }
    }
}
