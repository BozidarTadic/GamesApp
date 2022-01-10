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
        public Response<NoValue> CreateAchievement(UpdateAchievementDto achievementDto)
        {
            Response<NoValue> response = new Response<NoValue>();

            Achievement achievement = new Achievement { 
                Id=achievementDto.Id,
                DisplayName = achievementDto.DisplayName,
                Description = achievementDto.Description,
                DisplayOrder = achievementDto.DisplayOrder,
                Created = DateTime.UtcNow,
                Update = DateTime.UtcNow,
                GameId = achievementDto.GameId,
                Icon = achievementDto.Icon
                
            };

            try
            {
                _context.Achievements.Add(achievement);
                _context.SaveChanges();
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                response.ErrorMessage = Message.InternalServerError;
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
                _context.SaveChanges();
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                response.ErrorMessage = Message.InternalServerError;
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

                response.StatusCode = System.Net.HttpStatusCode.NotFound;
            }

            return response;
        }

        public Response<List<AchievementDto>> GetAllGameAchievements(string gameId)
        {
            Response<List<AchievementDto>> response = new Response<List<AchievementDto>>();

            try
            {
                response.Content = _context.Achievements.Where(a => a.GameId == gameId).
                    OrderBy(a => a.DisplayOrder).
                    Select(a => new AchievementDto {
                        Id = a.Id,
                        DisplayName = a.DisplayName,
                        Description = a.Description,
                        DisplayOrder = a.DisplayOrder,
                        Created = a.Created,
                        Update = a.Update,
                        GameId = a.GameId,
                        Icon = a.Icon
                    }).ToList();
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                response.StatusCode = System.Net.HttpStatusCode.NotFound;
            }

            return response;
        }

        public Response<NoValue> UpdateAchievement(UpdateAchievementDto achievementDto)
        {
            Response<NoValue> response = new Response<NoValue>();

            Achievement achievement = _context.Achievements.Where(a => a.Id == achievementDto.Id).FirstOrDefault();

            if (achievement == null)
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }

            achievement.DisplayName = achievementDto.DisplayName;
            achievement.Description = achievementDto.Description;
            achievement.DisplayOrder = achievementDto.DisplayOrder;
            achievement.Update = System.DateTime.Now;
            achievement.GameId = achievementDto.GameId;
            achievement.Icon = achievementDto.Icon;

            try
            {

                _context.Achievements.Update(achievement);
                _context.SaveChanges();
                response.StatusCode = System.Net.HttpStatusCode.OK;

            }
            catch (Exception)
            {

                response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                response.ErrorMessage = Message.InternalServerError;
            }

            return response;
        }
    }
}
