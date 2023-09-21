using System.ComponentModel.DataAnnotations;

namespace GroceryApp.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public float DiscountedPrice { get; set; }
        public int UnitsinStock { get; set; }
        public string UnitType { get; set; }
        public int Discontinued { get; set; }
        public Subcategories Subcategory { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ProductUrl { get; set; }
    }
}
