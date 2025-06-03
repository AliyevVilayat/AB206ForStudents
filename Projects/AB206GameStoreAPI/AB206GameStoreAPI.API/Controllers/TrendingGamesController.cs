using AB206GameStoreAPI.BL.Service.Interfaces;
using AB206GameStoreAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AB206GameStoreAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrendingGamesController : ControllerBase
{
    private readonly ITrendingGameService _trendingGameService;

    public TrendingGamesController(ITrendingGameService trendingGameService)
    {
        _trendingGameService = trendingGameService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        List<TrendingGame> trendingGames = _trendingGameService.GetAllTrendingGames();
        return Ok(trendingGames);
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Create(TrendingGame trendingGame)
    {
        _trendingGameService.CreateTrendingGame(trendingGame);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(int id, TrendingGame trendingGame)
    {
        _trendingGameService.UpdateTrendingGame(id, trendingGame);
        return Ok();
    }


    [HttpDelete]
    public IActionResult Delete(int id)
    {
        _trendingGameService.DeleteTrendingGame(id);
        return Ok();
    }


}
