using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roaster;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Guild(string name, int capacity)
        {
            roaster=new List<Player>();
            Name = name;
            Capacity = capacity;
        }
        public void AddPlayer(Player player)
        {
            if (roaster.Count<Capacity)
            {
                roaster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            bool isExist = false;
            for (int i = 0; i < roaster.Count; i++)
            {
                if (roaster[i].Name==name)
                {
                    roaster.RemoveAt(i);
                    isExist = true;
                }
            }
            return isExist;
        }
        public void PromotePlayer(string name)
        {
            for (int i = 0; i < roaster.Count; i++)
            {
                if (roaster[i].Name == name && roaster[i].Rank!="Member")
                {
                    roaster[i].Rank = "Member";
                    break;
                }
            }
        }
        public void DemotePlayer(string name)
        {
            for (int i = 0; i < roaster.Count; i++)
            {
                if (roaster[i].Name == name && roaster[i].Rank != "Trial")
                {
                    roaster[i].Rank = "Trial";
                    break;
                }
            }
        }
        public Player[] KickPlayersByClass(string @class)
        {
            int arrayLentgh = 0;
            foreach (var player in roaster)
            {
                if (player.Class==@class)
                {
                    arrayLentgh++;
                }
            }
            Player[] playerList = new Player[arrayLentgh];
            int index = 0;
            for (int i = 0; i < roaster.Count; i++)
            {
                if (roaster[i].Class==@class)
                {
                    playerList[index++] = roaster[i];
                    roaster.RemoveAt(i);
                }
            }
            return playerList;
        }
        public int Count { get { return roaster.Count; } }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roaster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
