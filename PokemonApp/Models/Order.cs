namespace PokemonApp.Models
{
    public class Order
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
