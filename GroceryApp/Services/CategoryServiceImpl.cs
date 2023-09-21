using GroceryApp.Database;
using GroceryApp.Models;

namespace GroceryApp.Services
{
    public class CategoryServiceImpl : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryServiceImpl(AppDbContext context)
        {
            _context = context;
        }
        public Categories AddCategory(Categories category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public List<Categories> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Categories GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }
    }
}
