using System;
using System.Collections.Generic;
using System.Text;

int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int M = int.Parse(Console.ReadLine());
        int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Dictionary<int, int> card = new Dictionary<int, int>();

        for (int i = 0; i < N; i++)
        {
            if (!card.ContainsKey(A[i]))
                card.Add(A[i], 1);
            else
                ++card[A[i]];
        }
        
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < M; i++)
        {
            if (!card.ContainsKey(B[i]))
                sb.Append("0 ");
            else
                sb.Append(card[B[i]] + " ");
        }
        
        Console.WriteLine(sb.ToString());