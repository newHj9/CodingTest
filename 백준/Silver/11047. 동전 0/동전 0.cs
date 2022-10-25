using System;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = input[0];
        int K = input[1];

        int[] coin = new int[N];
        for (int i = N - 1; i >= 0; i--)
        {
            coin[i] = int.Parse(Console.ReadLine());
        }

        int idx = 0;
        int money = K;
        int cnt = 0;

        while (money > 0)
        {
            if (money / coin[idx] > 0)
            {
                cnt += money / coin[idx];
                money = money % coin[idx];
            }
            idx++;
        }
        Console.WriteLine(cnt);