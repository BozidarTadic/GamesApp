using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp.Dtos
{
    public class AchievementDto
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime Created { get; set; }
        public DateTime Update { get; set; }
        public string GameId { get; set; }
    }
}
