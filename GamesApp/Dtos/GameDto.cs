using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesApp.Dtos
{
    public class GameDto
    {
        public long Id { get; set; }
        [Required]
        public string DisplayName { get; set; }

    }
}
