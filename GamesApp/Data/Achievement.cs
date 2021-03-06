using System;
using System.Collections.Generic;

#nullable disable

namespace GamesApp.Data
{
    public partial class Achievement
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime Created { get; set; }
        public DateTime Update { get; set; }
        public long GameId { get; set; }

        public virtual Game Game { get; set; }
    }
}
