using System;

int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];
            int N = input[2];

            int result = 0;
            
            if((N % H) != 0)
                result = ((N % H) * 100) + ((N / H) + 1);
            else
                result =  (H * 100) + (N / H);
            
            Console.WriteLine(result);
        }