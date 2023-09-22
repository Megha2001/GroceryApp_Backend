using GroceryApp.Database;
using GroceryApp.Models;

namespace GroceryApp.Services
{
    public class UserServiceImpl : IUserService
    {
        private readonly AppDbContext _context;
        public UserServiceImpl(AppDbContext context)
        {
            _context = context;
        }
        public Users LoginUser(string email, string password)
        {
            Users user = _context.Users.FirstOrDefault(x=>x.Email==email&&x.Password==password);
            if (user != null)
                return user;
            return null;
        }

        public Users RegisterUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
