using JokeWebApp.Data;
using JokeWebApp.Interface;
using JokeWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;

namespace JokeWebApp.Repository
{
    public class JokeRepository : IJokeRepository
    {
        private readonly ApplicationDbContext _context;

        public JokeRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<List<Joke>> GetJokeDetail(string input)
        {
            return await _context.Joke
                .Where(x => x.JokeQuestion.Contains(input)).ToListAsync();
        }
    }
}
