namespace PokemonApp.Models
{
    public class Reviewer
    {
        public int Id { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
