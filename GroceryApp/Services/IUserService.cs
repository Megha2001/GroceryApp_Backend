using GroceryApp.Models;
namespace GroceryApp.Services
{
    public interface IUserService
    {
        public Users RegisterUser(Users user);
        public Users LoginUser(string email, string password);
    }
}
