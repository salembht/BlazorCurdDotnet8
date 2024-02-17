using BlazorCurdDotnet8.Entities;

namespace BlazorCurdDotnet8.Services
{
    public interface IGameServices
    {
        Task<List<Game>> GetGamesAsync();
        Task<Game> AddGame(Game game);
    }
}
