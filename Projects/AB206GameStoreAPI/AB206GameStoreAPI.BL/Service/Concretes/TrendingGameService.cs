using AB206GameStoreAPI.BL.Exceptions;
using AB206GameStoreAPI.BL.Service.Interfaces;
using AB206GameStoreAPI.DAL.Entities;
using AB206GameStoreAPI.DAL.Repositories.Interfaces;

namespace AB206GameStoreAPI.BL.Service.Concretes;

public class TrendingGameService : ITrendingGameService
{
    private readonly IRepository<TrendingGame> _repository;

    public TrendingGameService(IRepository<TrendingGame> repository)
    {
        _repository = repository;
    }

    //DML
    public void CreateTrendingGame(TrendingGame game)
    {
        _repository.Create(game);
        _repository.Save();
    }

    public void UpdateTrendingGame(int id, TrendingGame game)
    {
        if (id != game.Id)
        {
            throw new TrendingGameException();
        }
        TrendingGame? trendingGame = _repository.GetById(id);
        if (trendingGame is null)
        {
            throw new TrendingGameException();
        }

        //Mapping Process
        trendingGame.Name = game.Name;


        _repository.Update(trendingGame); //optional
        _repository.Save();
    }

    public void DeleteTrendingGame(int id)
    {
        TrendingGame? trendingGame = _repository.GetById(id);

        if (trendingGame is null)
        {
            throw new TrendingGameException();
        }

        _repository.Delete(trendingGame);
        _repository.Save();
    }


    //DQL
    public List<TrendingGame> GetAllTrendingGames()
    {
        List<TrendingGame> trendingGames = _repository.GetAll().ToList();
        return trendingGames;
    }

}
