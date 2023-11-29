using PokemonApp.Models;
using PokemonReview.Models;

namespace PokemonApp.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
        Order GetOrder(int orderId);
        ICollection<Order> GetOrderOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOrder(int ownerId);
        bool OrderExists(int orderId);
        bool CreateOrder(Order order);
        bool UpdateOrder(Order order);
        bool DeleteOrder(Order order);
        bool Save();
    }
}
