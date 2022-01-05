using System;
using System.Collections.Generic;

#nullable disable

namespace GamesApp.Data
{
    public partial class Game
    {
        public Game()
        {
            Achievements = new HashSet<Achievement>();
        }

        public string Id { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<Achievement> Achievements { get; set; }
    }
}
