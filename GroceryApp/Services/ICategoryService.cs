using GroceryApp.Models;

namespace GroceryApp.Services
{
    public interface ICategoryService
    {
        public List<Categories> GetAllCategories();
        public Categories GetCategoryById(int id);
        public Categories AddCategory(Categories category);
    }
}
