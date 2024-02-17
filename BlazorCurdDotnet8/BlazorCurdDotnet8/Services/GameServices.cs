using BlazorCurdDotnet8.Data;
using BlazorCurdDotnet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCurdDotnet8.Services
{
    public class GameServices : IGameServices
    {
        private readonly DataContext _context;
        public GameServices(DataContext context) 
        {
            _context= context;
        }
        public async Task<List<Game>> GetGamesAsync()
        {
            await Task.Delay(500);
            return  await _context.Games.ToListAsync();
        }
    }
}
