using System;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = input[0];
int K = input[1];
int[] Coin = new int[N];

for (int i = N - 1; i >= 0; i--)
{
    Coin[i] = int.Parse(Console.ReadLine());
}

int cnt = 0, idx = 0;
while (K > 0)
{
    if (K / Coin[idx] > 0)
    {
        cnt += K / Coin[idx];
        K = K % Coin[idx];
    }
    idx++;
}

Console.WriteLine(cnt);