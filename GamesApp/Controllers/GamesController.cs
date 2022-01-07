using GamesApp.BL.Interfaces;
using GamesApp.Dtos;
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
        [HttpPost]
        [Route("CreateAchievement")]
        public IActionResult CreateAchievement(AchievementDto achievementDto)
        {
            var result = _gameService.CreateAchievement(achievementDto);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok();
                case System.Net.HttpStatusCode.InternalServerError:
                    return StatusCode(500, "Internal server error");
                default:
                    return BadRequest();
            }
        }
        [HttpGet]
        [Route("GetAchievement")]
        public IActionResult GetAchievement(string id)
        {
            var result = _gameService.GetAchievement(id);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok();
                case System.Net.HttpStatusCode.NotFound:
                    return StatusCode(404, "Not Found");
                default:
                    return BadRequest();
            }
        }
        [HttpGet]
        [Route("GetAllGameAchievements")]
        public IActionResult GetAllGameAchievements(string gameId)
        {
            var result = _gameService.GetAllGameAchievements(gameId);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok();
                case System.Net.HttpStatusCode.NotFound:
                    return StatusCode(404, "Not Found");
                default:
                    return BadRequest();
            }
        }
        [HttpPut]
        [Route("UpdateAchievements")]
        public IActionResult UpdateAchievements(AchievementDto achievementsDto)
        {
            var result = _gameService.UpdateAchievement(achievementsDto);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok();
                case System.Net.HttpStatusCode.InternalServerError:
                    return StatusCode(500, "Internal server error");
                default:
                    return BadRequest();
            }
        }
        [HttpDelete]
        [Route("DeleteAchievements")]
        public IActionResult DeleteAchievements(string id)
        {
            var result = _gameService.DeleteAchievement(id);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok();
                case System.Net.HttpStatusCode.InternalServerError:
                    return StatusCode(500, "Internal server error");
                default:
                    return BadRequest();
            }
        }
    }
}
