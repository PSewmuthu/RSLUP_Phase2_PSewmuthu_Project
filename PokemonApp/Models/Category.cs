namespace PokemonApp.Models
{
    public class Category
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
