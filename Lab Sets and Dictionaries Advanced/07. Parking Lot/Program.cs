using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string command=Console.ReadLine();
            while (command!="END")
            {
                string[] cmdInfo = command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string direction = cmdInfo[0];
                string carNumber = cmdInfo[1];
                if (direction=="IN")
                {
                    set.Add(carNumber);
                }
                else if (direction=="OUT")
                {
                    set.Remove(carNumber);
                }
                command= Console.ReadLine();
            }
            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {

                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
