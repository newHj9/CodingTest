using System.Text;

int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());

int[,] snail = new int[N, N];
int X = N / 2, Y = N / 2; 
int dirY = 0, dirX = 0, cnt = 0;

snail[Y, X] = ++cnt;
for (int i = 0; i < N; i++)
{
    if (i % 2 == 0)
    {
        dirY = -1;
        dirX = 1;
    }
    else
    {
        dirY = 1;
        dirX = -1;
    }

    for (int j = 0; j <= i; j++)
    {
        Y += dirY;
        if (Y < 0) break;

        snail[Y, X] = ++cnt;
    }

    if (i != N - 1)
    {
        for (int j = 0; j <= i; j++)
        {
            X += dirX;
            snail[Y, X] = ++cnt;
        }
    }
}

StringBuilder snailSb = new StringBuilder();
StringBuilder result = new StringBuilder();
for (int i = 0; i < snail.GetLength(0); i++)
{
    for (int j = 0; j < snail.GetLength(1); j++)
    {
        snailSb.Append(snail[i, j] + " ");

        if (snail[i, j] == M)
            result.AppendLine((i + 1) + " " + (j + 1));
    }
    if(i != snail.GetLength(0) - 1)
        snailSb.Append("\n");
}

Console.WriteLine(snailSb);
Console.WriteLine(result);