using System.Net;
using System.Security.Cryptography;

int n = int.Parse(Console.ReadLine());
string racingNumber=Console.ReadLine();
char[,] matrix=new char[n,n];
for (int i = 0; i < n; i++)
{
	string[] colElements = Console.ReadLine().Split(" ").ToArray();
	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = char.Parse(colElements[j]);
	}
}
string direction = string.Empty;
int carrow = 0;
int carcol = 0;
bool finishedRace = false;
int points = 0;
while ((direction=Console.ReadLine())!="End")
{
	if (direction=="left")
	{
		carcol = carcol - 1;
    }
	else if (direction=="right")
	{
		carcol = carcol + 1;
    }
	else if(direction=="down")
	{
		carrow= carrow + 1;
    }
	else if (direction=="up")
	{
		carrow=carrow - 1;
    }
    if (matrix[carrow, carcol] == '.')
    {
        points += 10;
    }
    else if (matrix[carrow, carcol] == 'T')
    {
        matrix[carrow, carcol] = '.';
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 'T')
                {
                    carrow = i;
                    carcol = j;
                    matrix[i, j] = '.';
                    points += 30;
                }
            }
        }
    }
    else if (matrix[carrow, carcol] == 'F')
    {
        Console.WriteLine($"Racing car {racingNumber} finished the stage!");
        points += 10;
        finishedRace = true;
        break;
    }
}
if (finishedRace==false)
{
    Console.WriteLine($"Racing car {racingNumber} DNF.");
}
Console.WriteLine($"Distance covered {points} km.");
matrix[carrow, carcol] = 'C';
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}");
    }
    Console.WriteLine();
}