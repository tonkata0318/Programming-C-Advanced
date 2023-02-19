using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commingGuest=Console.ReadLine();
            HashSet<string> setForVip=new HashSet<string>();
            HashSet<string> normalSet=new HashSet<string>();
            while (commingGuest!="PARTY")
            {
                string firstBukva = commingGuest[0].ToString();
                bool canParse=CanPArse(firstBukva);
                if (canParse)
                {
                    setForVip.Add(commingGuest);
                }
                else
                {
                    normalSet.Add(commingGuest);
                }
                commingGuest = Console.ReadLine();
            }
            string command=Console.ReadLine() ;
            while (command != "END")
            {
                if (setForVip.Contains(command))
                {
                    setForVip.Remove(command);
                }
                if (normalSet.Contains(command)) ;
                {
                    normalSet.Remove(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(setForVip.Count+normalSet.Count);
            foreach (var item in setForVip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in normalSet)
            {
                Console.WriteLine(item);
            }
        }
        static bool CanPArse(string firstBukva)
        {
            int number = 0;
            bool succes = int.TryParse(firstBukva, out number);
            if (succes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
