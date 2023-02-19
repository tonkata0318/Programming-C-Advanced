using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public List<Player> players;
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }

        public Team(string name, int openPositions, char group)
        {
            players= new List<Player>();
            Name = name;
            OpenPositions = openPositions;
            Group = group;
        }
        public int Count { get { return players.Count; } }
        public string AddPlayer(Player player)
        {
            if (player.Name==null||player.Position==null)
            {
                return $"Invalid player's information.";
            }
            else if (OpenPositions<=0)
            {
                return $"There are no more open positions.";
            }
            else if (player.Rating<80)
            {
                return "Invalid player's rating.";
            }
            else
            {
                players.Add(player);
                OpenPositions--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
            }
        }
        public bool RemovePlayer(string name)
        {
            foreach (var player in players)
            {
                if (player.Name==name)
                {
                    players.Remove(player);
                    OpenPositions++;
                    return true;
                }
            }
            return false;
        }
        public int RemovePlayerByPosition(string position)
        {
            int count = 0;
            int indextoRemove;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Position == position)
                {
                    count++;
                    indextoRemove = i;
                    OpenPositions++;
                    players.RemoveAt(i);
                }
            } 
            
            return count;
        }
        public Player RetirePlayer(string name)
        {
            foreach (var player in players)
            {
                if (player.Name==name)
                {
                    player.Retired = true;
                    return player;
                }
            }
            return null;
        }
        public List<Player> AwardPlayers(int games)
        {
            List<Player> list = new List<Player>();
            foreach (var player in players)
            {
                if (player.Games>=games&&player.Retired==false)
                {
                    list.Add(player);
                }
            }
            return list;
        }
        public string Report()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (var player in players)
            {
                if (player.Retired==false)
                {
                    sb.AppendLine(player.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
