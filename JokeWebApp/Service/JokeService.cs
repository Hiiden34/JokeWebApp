using JokeWebApp.Controllers;
using JokeWebApp.Interface;
using JokeWebApp.Models;
using JokeWebApp.Repository;

namespace JokeWebApp.Service
{
    public class JokeService : IJokeService
    {
        private readonly IJokeRepository _jokeRepository;

        public JokeService(IJokeRepository jokeRepository)
        {
            _jokeRepository = jokeRepository;
        }

        public async Task<Joke> GetJokeBySearch(string input)
        {
            Joke? jokes = await _jokeRepository.GetJokeDetail(input);

            if(jokes is not null)
            {
                return jokes;
            }
            else
            {
                return new();
            }
        }

    }
}
