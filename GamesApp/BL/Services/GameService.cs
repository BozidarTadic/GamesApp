using GamesApp.BL.Interfaces;
using GamesApp.Common;
using GamesApp.Data;
using GamesApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp.BL.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;
        public GameService (ApplicationDbContext context)
        {
            _context = context;
        }
        public Response<NoValue> CreateAchievement(AchievementDto achievementDto)
        {
            Response<NoValue> response = new Response<NoValue>();

            Achievement achievement = new Achievement { 
                Id= achievementDto.Id,
                DisplayName = achievementDto.DisplayName,
                Description = achievementDto.Description,
                DisplayOrder = achievementDto.DisplayOrder,
                Created = achievementDto.Created,
                Update = achievementDto.Update,
                GameId = achievementDto.GameId,
                Icon = achievementDto.Icon
                
            };

            try
            {
                _context.Achievements.Add(achievement);
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }

        public Response<NoValue> DeleteAchievement(string id)
        {
            Response<NoValue> response = new Response<NoValue>();

            try
            {
                Achievement achievement = _context.Achievements.Where(a => a.Id == id).FirstOrDefault();
                if (achievement == null)
                {
                    response.StatusCode = System.Net.HttpStatusCode.NotFound;
                    return response;
                }

                _context.Achievements.Remove(achievement);
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }

        public Response<AchievementDto> GetAchievement(string id)
        {
            Response<AchievementDto> response = new Response<AchievementDto>();
            try
            {
                response.Content = _context.Achievements.Where(a => a.Id == id).Select(a => new AchievementDto
                {
                    Id = a.Id,
                    DisplayName = a.DisplayName,
                    Description = a.Description,
                    DisplayOrder = a.DisplayOrder,
                    Created = a.Created,
                    Update = a.Update,
                    Icon = a.Icon,
                    GameId = a.GameId
                }).FirstOrDefault();

                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }

        public Response<List<AchievementDto>> GetAllGameAchievements(string gameId)
        {
            Response<List<AchievementDto>> response = new Response<List<AchievementDto>>();

            return response;
        }

        public Response<NoValue> UpdateAchievement(AchievementDto achievement)
        {
            throw new NotImplementedException();
        }
    }
}
