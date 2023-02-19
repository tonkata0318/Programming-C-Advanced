using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dic = new SortedDictionary<string, Dictionary<string, double>>();
            string command=Console.ReadLine();
            while (command!="Revision")
            {
                string[] cmdInfo= command.Split(", ");
                string shopName = cmdInfo[0];
                string product = cmdInfo[1];
                double price = double.Parse(cmdInfo[2]);
                if (dic.ContainsKey(shopName))
                {
                    dic[shopName].Add(product, price);
                }
                else
                {
                    dic[shopName]=new Dictionary<string, double>();
                    dic[shopName].Add(product, price);
                }
                command=Console.ReadLine() ;
            }
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
