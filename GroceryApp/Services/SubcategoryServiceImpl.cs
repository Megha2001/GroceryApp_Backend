using GroceryApp.Database;
using GroceryApp.Models;

namespace GroceryApp.Services
{
    public class SubcategoryServiceImpl : ISubcategoryService
    {
        private readonly AppDbContext _context;
        public SubcategoryServiceImpl(AppDbContext context)
        {
            _context = context;
        }
        public List<Subcategories> GetSubCategoriesByCatId(int catId)
        {
            return _context.Subcategories.Select(p => new Subcategories { Id = p.Id, SubcategoryName = p.SubcategoryName, Category = p.Category }).Where(x => x.Category.Id == catId).ToList();
        }
    }
}
