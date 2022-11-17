int N = int.Parse(Console.ReadLine());
int[] Milk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[,] dp = new int[N, 3];

if (Milk[0] == 0)
    dp[0, 0] = 1;

for (int i = 1; i < N; i++)
{
    int temp = Milk[i];
    dp[i, 0] = temp == 0 ? dp[i - 1, 2] + 1 : dp[i - 1, 0];
    dp[i, 1] = temp == 1 && dp[i, 2] < dp[i, 0] ? dp[i - 1, 0] + 1 : dp[i - 1, 1];
    dp[i, 2] = temp == 2 && dp[i, 0] < dp[i, 1] ? dp[i - 1, 1] + 1 : dp[i - 1, 2];
}

Console.WriteLine(dp.Cast<int>().ToArray().Max());