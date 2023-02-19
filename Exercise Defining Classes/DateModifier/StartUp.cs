namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate=Console.ReadLine();
            string secondDate=Console.ReadLine();
            Date_Modifier dateModifier= new Date_Modifier();
            Console.WriteLine(dateModifier.DiffInDays(firstDate,secondDate));
        }
    }
}