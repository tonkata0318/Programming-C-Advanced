using System.Xml.Linq;

namespace _08._Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ThreeUple threeUple= new ThreeUple();
            string[] nameAndTown = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (nameAndTown.Length==4)
            {
                threeUple.NameAddresAndtown = new Tuple<string, string, string, string>(nameAndTown[0], nameAndTown[1], nameAndTown[2], nameAndTown[3]);
            }
            else
            {
                threeUple.NameAddresAndtown = new Tuple<string, string, string, string>(nameAndTown[0], nameAndTown[1], nameAndTown[2], nameAndTown[3] + " " + nameAndTown[4]);
            }
            string[] namesAndLitres = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (namesAndLitres[2]=="drunk")
            {
                threeUple.NameLitresAndDrunk = new Tuple<string, int, string>(namesAndLitres[0], int.Parse(namesAndLitres[1]), "True");
            }
            else
            {
                threeUple.NameLitresAndDrunk = new Tuple<string, int, string>(namesAndLitres[0], int.Parse(namesAndLitres[1]), "False");
            }
            string[] nameAccountAndBank = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            threeUple.NameAccountBalanceAndBank = new Tuple<string, double, string>(nameAccountAndBank[0], double.Parse(nameAccountAndBank[1]), nameAccountAndBank[2]);
            Console.WriteLine($"{threeUple.NameAddresAndtown.Item1} {threeUple.NameAddresAndtown.Item2} -> {threeUple.NameAddresAndtown.Item3} -> {threeUple.NameAddresAndtown.Item4}");
            Console.WriteLine($"{threeUple.NameLitresAndDrunk.Item1} -> {threeUple.NameLitresAndDrunk.Item2} -> {threeUple.NameLitresAndDrunk.Item3}");
            Console.WriteLine($"{threeUple.NameAccountBalanceAndBank.Item1} -> {threeUple.NameAccountBalanceAndBank.Item2} -> {threeUple.NameAccountBalanceAndBank.Item3}");
        }
    }
}