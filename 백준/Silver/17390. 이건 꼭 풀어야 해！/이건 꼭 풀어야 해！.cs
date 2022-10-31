using System;
using System.Text;

int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = input[0];
int Q = input[1];
int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] sum = new int[N + 1];

StringBuilder sb = new StringBuilder();

Array.Sort(A);

for (int i = 0; i < sum.Length - 1; i++)
{
    sum[i + 1] = A[i] + sum[i];
}

for (int i = 0; i < Q; i++)
{
    int[] LR = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    sb.AppendLine((sum[LR[1]] - sum[LR[0] - 1]).ToString());
}

Console.WriteLine(sb);