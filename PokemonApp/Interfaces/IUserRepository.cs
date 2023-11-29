using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(int usrrId);
        bool UserExists(int userId);
        User GetUserByEmail(string userEmail);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool Save();
    }
}
