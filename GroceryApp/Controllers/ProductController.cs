using GroceryApp.Models;
using GroceryApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = productService.GetAllProducts();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = productService.GetProductById(id);
            return Ok(data);
        }

        [HttpGet("{catId}/{subCatId}")]
        public IActionResult Get(int catId, int subCatId)
        {
            var data = productService.SearchProduct(catId, subCatId);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(Products product)
        {
            var data = productService.AddProduct(product);
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Put(int id)
        {
            var data = productService.EditProduct(id);
            return Ok(data);
        }

    }
}
