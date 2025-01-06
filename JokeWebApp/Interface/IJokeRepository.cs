using JokeWebApp.Models;

namespace JokeWebApp.Interface
{
    public interface IJokeRepository
    {
        Task<List<Joke>> GetJokeDetail(string input);
    }
}
