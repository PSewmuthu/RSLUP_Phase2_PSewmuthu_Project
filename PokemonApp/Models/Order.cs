using PokemonReview.Models;

namespace PokemonApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
