using System.Diagnostics.SymbolStore;
List<string> names=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
string command=Console.ReadLine();
while (command!= "Party!")
{
    string[] cmdInfo = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    string commandType = cmdInfo[0];
    if (commandType=="Remove")
    {
        string criteria = cmdInfo[1];
        if (criteria== "StartsWith")
        {
            string charactertoLookFor = cmdInfo[2];
            for (int i = 0; i < names.Count; i++)
            {
                int lentghtoCompare = charactertoLookFor.Length;
                string stringtoCompare = "";
                for (int j = 0; j < lentghtoCompare; j++)
                {
                    stringtoCompare += names[i][j];
                }
                Func<string, string, bool> startWith = GetCheckForStartWith(stringtoCompare, charactertoLookFor);
                if (startWith(stringtoCompare,charactertoLookFor))
                {
                    names.Remove(names[i]);
                    i--;
                }
            }
        }
        else if (criteria== "Length")
        {
            int lentghtoCompare = int.Parse(cmdInfo[2]);
            for (int i = 0; i < names.Count; i++)
            {
                Func<int,int,bool> hasSameLentgh = GetTheLentgh(names[i].Length,lentghtoCompare);
                if (hasSameLentgh(names[i].Length, lentghtoCompare))
                {
                    names.Remove(names[i]);
                    i--;
                }
            }
        }
        else if (criteria== "EndsWith")
        {
            string charactertoLookFor= cmdInfo[2];
            for (int i = 0; i < names.Count; i++)
            {
                int lentghtoCompare = charactertoLookFor.Length;
                string stringtoCompare = "";
                for (int j = names[i].Length-lentghtoCompare; j < names[i].Length; j++)
                {
                    stringtoCompare += names[i][j];
                }
                Func<string, string, bool> endWith = GetCheckForEndWith(stringtoCompare, charactertoLookFor);
                if (endWith(stringtoCompare, charactertoLookFor))
                {
                    names.Remove(names[i]);
                    i--;
                }
            }
        }
    }
    else if (commandType=="Double")
    {
        string criteria = cmdInfo[1];
        if (criteria == "StartsWith")
        {
            string charactertoLookFor = cmdInfo[2];
            for (int i = 0; i < names.Count; i++)
            {
                int lentghtoCompare = charactertoLookFor.Length;
                string stringtoCompare = "";
                for (int j = 0; j < lentghtoCompare; j++)
                {
                    stringtoCompare += names[i][j];
                }
                Func<string, string, bool> startWith = GetCheckForStartWith(stringtoCompare, charactertoLookFor);
                if (startWith(stringtoCompare, charactertoLookFor))
                {
                    int occurances = 0;
                    for (int t = 0; t < names.Count; t++)
                    {
                        if (names[t] == names[i])
                        {
                            occurances++;
                        }
                    }
                    for (int k = 0; k < occurances; k++)
                    {
                        names.Add(names[i]);
                    }
                    break;
                }
            }
        }
        else if (criteria == "Length")
        {
            int lentghtoCompare = int.Parse(cmdInfo[2]);
            for (int i = 0; i < names.Count; i++)
            {
                Func<int, int, bool> hasSameLentgh = GetTheLentgh(names[i].Length, lentghtoCompare);
                if (hasSameLentgh(names[i].Length, lentghtoCompare))
                {
                    int occurances = 0;
                    for (int t = 0; t < names.Count; t++)
                    {
                        if (names[t] == names[i])
                        {
                            occurances++;
                        }
                    }
                    for (int k = 0; k < occurances; k++)
                    {
                        names.Add(names[i]);
                    }
                    break;
                }
            }
        }
        else if (criteria == "EndsWith")
        {
            string charactertoLookFor = cmdInfo[2];
            for (int i = 0; i < names.Count; i++)
            {
                int lentghtoCompare = charactertoLookFor.Length;
                string stringtoCompare = "";
                for (int j = names[i].Length - lentghtoCompare; j < names[i].Length; j++)
                {
                    stringtoCompare += names[i][j];
                }
                Func<string, string, bool> endWith = GetCheckForEndWith(stringtoCompare, charactertoLookFor);
                if (endWith(stringtoCompare, charactertoLookFor))
                {
                    int occurances = 0;
                    for (int t = 0; t < names.Count; t++)
                    {
                        if (names[t] == names[i])
                        {
                            occurances++;
                        }
                    }
                    for (int k = 0; k < occurances; k++)
                    {
                        names.Add(names[i]);
                    }
                    break;
                }
            }
        }
    }
    command = Console.ReadLine();
}
//names = names.OrderBy(x=>x).ToList();
if (names.Count>0)
{
    Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}
Func<string,string,bool> GetCheckForEndWith(string a,string b)
{
    if (a==b)
    {
        return (n, p) => true;
    }
    else
    {
        return (n, p) => false;
    }
}
Func<string, string, bool> GetCheckForStartWith(string a, string b)
{
    if (a == b)
    {
        return (n, p) => true;
    }
    else
    {
        return (n, p) => false;
    }
}
Func<int,int,bool> GetTheLentgh(int a,int b)
{
    if (a == b)
    {
        return (n, p) => true;
    }
    else
    {
        return (n, p) => false;
    }
}