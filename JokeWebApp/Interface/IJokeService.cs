using JokeWebApp.Models;

namespace JokeWebApp.Interface
{
    public interface IJokeService
    {
        Task<Joke> GetJokeBySearch(string input);
    }
}
