using GamesApp.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameService _gameService;
        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }
        public IActionResult CreateAchievement(string id)
        {
            var result = _gameService.GetAchievement(id);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok(result.Content);
                case System.Net.HttpStatusCode.InternalServerError:
                    return StatusCode(500, "Internal server error");
                default:
                    return BadRequest();
            }
        }
    }
}
