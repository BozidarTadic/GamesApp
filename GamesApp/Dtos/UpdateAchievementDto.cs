using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp.Dtos
{
    public class UpdateAchievementDto
    {
        public long Id { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        
        [Required]
        public long GameId { get; set; }
    }
}
