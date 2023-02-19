using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank  { get;set; }
        public string Description { get; set; }
        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
            Rank = "Trial";
            Description = "n/a";
        }
        public override string ToString()
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.AppendLine($"Player {Name}: {Class}");
            stringBuilder.AppendLine($"Rank: {Rank}");
            stringBuilder.AppendLine($"Description: {Description}");
            return stringBuilder.ToString().Trim();
        }
    }
}
