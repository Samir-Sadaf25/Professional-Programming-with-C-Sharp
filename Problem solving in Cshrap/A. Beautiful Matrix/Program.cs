int row = 0 ;
int col = 0;
int[,] arr = new int[5, 5];
for (int i = 0; i < 5;i++)
{
    string[] line = Console.ReadLine().Split(' ');
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = int.Parse(line[j]);
        if (arr[i, j] == 1)
        {
            row = i;
            col = j;
            break;
        }

    }
}
int moves = Math.Abs(row - 2) + Math.Abs(col - 2);
Console.WriteLine(moves);