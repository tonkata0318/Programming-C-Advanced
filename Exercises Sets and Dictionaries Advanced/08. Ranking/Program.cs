using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,string> dicForTests=new Dictionary<string,string>();
            SortedDictionary<string,SortedDictionary<string,int>> dic=new SortedDictionary<string, SortedDictionary<string, int>>();
            string inputForPass=Console.ReadLine();
            while (inputForPass!= "end of contests")
            {
                string[] spitInput=inputForPass.Split(":",StringSplitOptions.RemoveEmptyEntries);
                if (!dicForTests.ContainsKey(spitInput[0]))
                {
                    dicForTests.Add(spitInput[0], spitInput[1]);
                }
                inputForPass = Console.ReadLine();
            }
            string inputForStudents=Console.ReadLine();
            while (inputForStudents!= "end of submissions")
            {
                string[] cmdInfo=inputForStudents.Split("=>");
                string test = cmdInfo[0];
                string password = cmdInfo[1];
                string username = cmdInfo[2];
                int points = int.Parse(cmdInfo[3]);
                if (dicForTests.ContainsKey(test))
                {
                    if (dicForTests[test] ==password)
                    {
                        if (!dic.ContainsKey(username))
                        {
                            dic.Add(username, new SortedDictionary<string, int>());
                        }
                        if (dic[username].ContainsKey(test))
                        {
                            if (dic[username][test]<points)
                            {
                                dic[username][test] = points;
                            }
                        }
                        else
                        {
                            dic[username].Add(test, points);
                        }
                    }
                }
                inputForStudents = Console.ReadLine();
            }
            int highestPoints = 0;
            string name = "";
            foreach (var item in dic)
            {
                int curMax = 0;
                foreach (var item2 in item.Value)
                {
                    curMax += item2.Value;
                }
                if (curMax>highestPoints)
                {
                    highestPoints = curMax;
                    name = item.Key;
                }
                curMax = 0;
            }
            Console.WriteLine($"Best candidate is {name} with total {highestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item2 in item.Value.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value))
                {
                    Console.WriteLine($"#  {item2.Key} -> {item2.Value}");
                }
            }
        }
    }
}
