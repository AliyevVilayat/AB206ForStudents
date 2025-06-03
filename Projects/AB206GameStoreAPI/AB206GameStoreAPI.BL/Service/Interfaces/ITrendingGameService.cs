using AB206GameStoreAPI.DAL.Entities;

namespace AB206GameStoreAPI.BL.Service.Interfaces;

public interface ITrendingGameService
{

    List<TrendingGame> GetAllTrendingGames();

    void CreateTrendingGame(TrendingGame game);
    void UpdateTrendingGame(int id, TrendingGame game);
    void DeleteTrendingGame(int id);
}
