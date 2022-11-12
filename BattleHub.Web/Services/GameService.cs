using BattleHub.DataAccess.Models;
using BattleHub.DataAccess.Repositories;

namespace BattleHub.Web.Services;

public class GameService
{
    private readonly GameRepository _gameRepository;
    public GameService(GameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }

    public async Task<List<Game>> GetAll()
    {
        return await _gameRepository.GetAll();
    }

    public async Task<Game> Get(string id)
    {
        return await _gameRepository.GetById(id);
    }

    public async Task<Game> Create(Game game)
    {
        return await _gameRepository.Create(game);
    }
}