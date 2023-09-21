using GroceryApp.Models;

namespace GroceryApp.Services
{
    public interface ISubcategoryService
    {
        public List<Subcategories> GetSubCategoriesByCatId(int catId);
    }
}
