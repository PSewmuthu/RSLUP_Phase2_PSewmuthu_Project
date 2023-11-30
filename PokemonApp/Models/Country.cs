namespace PokemonApp.Models
{
    public class Country
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public ICollection<Owner> Owner { get; set; }
    }
}
