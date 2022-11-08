int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = input[0];
int M = input[1];
char[][] Chess = new char[N][];

for (int i = 0; i < N; i++)
{
    Chess[i] = Console.ReadLine().ToCharArray();
}

List<int> result = new List<int>();
// 전체 NM
for (int i = 0; i <= N - 8; i++)
{
    for (int j = 0; j <= M - 8; j++)
    {
        int resultW = 0;
        // 8 x 8
        for (int k = i; k < i + 8; k++)
        {
            for (int l = j; l < j + 8; l++)
            {
                char color = (k + l) % 2 == 0 ? 'W' : 'B';

                if (color != Chess[k][l])
                    resultW++;
            }
        }
        result.Add(resultW);
        result.Add(64 - resultW);
    }
}

Console.WriteLine(result.Min());