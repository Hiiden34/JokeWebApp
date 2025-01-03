using JokeWebApp.Data;
using JokeWebApp.Interface;
using JokeWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JokeWebApp.Repository
{
    public class JokeRepository : IJokeRepository
    {
        private readonly ApplicationDbContext _context;

        public JokeRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Joke?> GetJokeDetail(string input)
        {
            return await _context.Joke.FirstOrDefaultAsync(x => x.JokeQuestion.Contains(input));
        }
    }
}
