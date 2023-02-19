int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int n = dimensions[0];
int m = dimensions[1];
char[][] playground = new char[n][];
int bRow = 0;
int bCol = 0;
for (int i = 0; i < playground.Length; i++)
{
    char[] colElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    playground[i] = new char[m];
    for (int j = 0; j < m; j++)
    {
        playground[i][j] = colElements[j];
        if (playground[i][j] == 'B')
        {
            bRow = i;
            bCol = j;
            playground[i][j] = '-';
        }
    }
}
string command = string.Empty;
int playersonField = 3;
int touchedPlayers = 0;
int movesMade = 0;
while ((command=Console.ReadLine())!="Finish")
{
    if (command=="up")
    {
        bRow--;
        if (bRow < 0 || playground[bRow][bCol]=='O')
        {
            bRow++;
            continue;
        }
        else
        {
            movesMade++;
        }
    }
    else if (command=="down")
    {
        bRow++;
        if (bRow >= n || playground[bRow][bCol] == 'O')
        {
            bRow--;
            continue;
        }
        else
        {
            movesMade++;
        }
    }
    else if (command=="left")
    {
        bCol--;
        if (bCol < 0 || playground[bRow][bCol] == 'O')
        {
            bCol++;
            continue;
        }
        else
        {
            movesMade++;
        }
    }
    else if (command=="right")
    {
        bCol++;
        if (bCol>=playground[bRow].Length || playground[bRow][bCol] == 'O')
        {
            bCol--;
            continue;
        }
        else
        {
            movesMade++;
        }
    }
    if (playground[bRow][bCol]=='P')
    {
        playersonField--;
        touchedPlayers++;
        if (touchedPlayers==3)
        {
            break;
        }
    }
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedPlayers} Moves made: {movesMade}");

