using JokeWebApp.Models;

namespace JokeWebApp.Interface
{
    public interface IJokeRepository
    {
        Task<Joke?> GetJokeDetail(string input);
    }
}
