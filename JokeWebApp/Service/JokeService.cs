using JokeWebApp.Interface;
using JokeWebApp.Models;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Core.Types;

namespace JokeWebApp.Service
{
    public class JokeService : IJokeService
    {
        private readonly IJokeRepository _jokeRepository;

        public JokeService(IJokeRepository jokeRepository)
        {
            _jokeRepository = jokeRepository;
        }

        public async Task<List<Joke>> GetJokeBySearch(string input)
        {
             List<Joke> jokes = await _jokeRepository.GetJokeDetail(input);

            if(jokes.Count != 0)
            {
                return jokes;
            }
            else
            {
                return [];
            }
        }

    }
}
