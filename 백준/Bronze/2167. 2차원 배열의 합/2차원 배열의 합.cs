int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[][] arr = new int[NM[0]][];

for (int i = 0; i < NM[0]; i++)
{
    arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int K = int.Parse(Console.ReadLine());

for (int i = 0; i < K; i++)
{
    int[] ijxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int result = 0;
    for (int j = ijxy[0] - 1; j < ijxy[2]; j++)
    {
        for (int k = ijxy[1] - 1; k < ijxy[3]; k++)
        {
            // Console.WriteLine(j + " " + k + " : " + arr[j][k]);
            result += arr[j][k];
        }
    }
    Console.WriteLine(result);
}