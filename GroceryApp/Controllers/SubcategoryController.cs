using GroceryApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoryController : ControllerBase
    {
        private readonly ISubcategoryService subcategoryService;
        public SubcategoryController(ISubcategoryService subcategoryService)
        {
            this.subcategoryService = subcategoryService;
        }

        [HttpGet("{catId}")]
        public IActionResult Get(int catId)
        {
            var data = subcategoryService.GetSubCategoriesByCatId(catId);
            return Ok(data);
        }
    }
}
