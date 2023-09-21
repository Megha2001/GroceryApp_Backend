using GroceryApp.Database;
using GroceryApp.Models;

namespace GroceryApp.Services
{
    public class ProductServiceImpl : IProductService
    {
        private readonly AppDbContext _context;
        public ProductServiceImpl(AppDbContext context)
        {
            _context = context;
        }

        public Products AddProduct(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Products EditProduct(int id)
        {
            Products product = _context.Products.FirstOrDefault(x => x.Id == id);
            product.UnitsinStock--;
            _context.SaveChanges();
            return product;
        }

        public List<Products> GetAllProducts()
        {
            return _context.Products.Select(p => new Products { Id = p.Id, ProductName = p.ProductName, ProductUrl=p.ProductUrl,UnitPrice=p.UnitPrice, DiscountedPrice=p.DiscountedPrice, Subcategory = p.Subcategory, Category = p.Category}).ToList();
        }

        public Products GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public List<Products> SearchProduct(int catId, int subCatId)
        {
            List<Products> reqdProducts = new List<Products>();
            List<Products> products = GetAllProducts();
            foreach(Products product in products)
            {
                if (product.Category.Id == catId && product.Subcategory.Id == subCatId)
                
                    reqdProducts.Add(product);
                
            }
            return reqdProducts;
        }

        public List<Products> SearchProduct(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
