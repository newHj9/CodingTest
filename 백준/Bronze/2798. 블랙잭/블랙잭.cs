using System;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = input[0];
        int M = input[1];
        List<int> cards = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> result = new List<int>();

        cards.Sort();
        cards.Reverse();

        for (int i = 0; i < N - 2; i++)
        {
            for (int j = i + 1; j < N - 1; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    int Max = cards[i] + cards[j] + cards[k];
                    if (cards[N / 2] < Max && Max <= M)
                    {
                        result.Add(Max);
                    }
                }
            }
        }

        Console.WriteLine(result.Max());