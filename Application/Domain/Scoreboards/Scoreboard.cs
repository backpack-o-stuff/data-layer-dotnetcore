﻿using System.Collections.Generic;

namespace DL.Application.Domain.Scoreboards
{
    public class Scoreboard : IEntity
    {
        public Scoreboard()
        {
            ScoreboardEntries = new List<ScoreboardEntry>();
        }

        public int Id { get; set; }
        public List<ScoreboardEntry> ScoreboardEntries { get; set; }
    }
}