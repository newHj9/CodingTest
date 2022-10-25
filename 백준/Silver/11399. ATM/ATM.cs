using System;

int N = int.Parse(Console.ReadLine());
        int[] P = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Array.Sort(P);
        
        Console.WriteLine(time(N));
        
        int time(int idx)
        {
            if (idx == 0)
                return 0;

            int sum = 0;
            for (int i = 0; i < idx; i++)
            {
                sum += P[i];
            }
            //Console.WriteLine(sum);
            return sum + time(idx - 1);
        }