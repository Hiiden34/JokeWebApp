using JokeWebApp.Models;

namespace JokeWebApp.Interface
{
    public interface IJokeService
    {
        Task<List<Joke>> GetJokeBySearch(string input);
    }
}
