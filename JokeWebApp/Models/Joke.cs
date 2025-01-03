namespace JokeWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public Guid UniqueIdentifier { get; set; } = Guid.NewGuid();

        public Joke() { 
        }
    }
}
