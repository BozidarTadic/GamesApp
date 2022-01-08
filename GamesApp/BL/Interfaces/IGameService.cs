using GamesApp.Common;
using GamesApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp.BL.Interfaces
{
    public interface IGameService
    {
        public Response<AchievementDto> GetAchievement(string id);
        public Response<List<AchievementDto>> GetAllGameAchievements(string gameId);
        public Response<NoValue> CreateAchievement(UpdateAchievementDto achievementDto);
        public Response<NoValue> UpdateAchievement(UpdateAchievementDto achievementDto);
        public Response<NoValue> DeleteAchievement(string id);
    }
}
