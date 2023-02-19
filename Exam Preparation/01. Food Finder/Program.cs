using System;
using System.Collections.Generic;

namespace _01._Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "pear";
            char e= 'a';
            if (word.Contains('a'))
            {

            }
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("pear", "");
            dic["pear"] += e;
            Console.WriteLine(dic["pear"]);
        }
    }
}
