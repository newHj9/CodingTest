int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = input[0];
int M = input[1];
int[] Card = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int Max = 0;

Array.Sort(Card);

for (int i = N - 1; i >= 1; i--)
{
    for (int j = i - 1; j > 0; j--)
    {
        for (int k = j - 1; k >= 0; k--)
        {
            int sum = Card[k] + Card[j] + Card[i];

            if (sum <= M && sum > Max)
            {
                Max = sum;
            }
        }
    }
}

Console.WriteLine(Max);