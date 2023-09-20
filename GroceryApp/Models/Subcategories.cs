namespace GroceryApp.Models
{
    public class Subcategories
    {
        public int Id { get; set; }
        public string SubcategoryName { get; set; }
        public Categories Category { get; set; }
    }
}
