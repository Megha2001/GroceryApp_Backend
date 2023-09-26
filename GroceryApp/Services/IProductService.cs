using GroceryApp.Models;

namespace GroceryApp.Services
{
    public interface IProductService
    {
        public List<Products> GetAllProducts();
        public Products GetProductById(int id);
        public Products AddProduct(Products product);
        public Products EditProduct(int id);
        public List<Products> SearchProduct(int catId, int subCatId);
    
        public List<Products> SearchProduct(string productName);
    }
}
