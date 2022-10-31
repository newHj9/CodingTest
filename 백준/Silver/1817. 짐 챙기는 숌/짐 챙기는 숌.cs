using System;

int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int N = input[0];
        int M = input[1];

        if (N == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int[] books = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            List<int> result = Enumerable.Repeat(0, N).ToList();
            int idx = 0;

            for (int i = 0; i < books.Length; i++)
            {
                if (result[idx] + books[i] <= M)
                {
                    result[idx] += books[i];
                }
                else if(result[idx] + books[i] > M)
                {
                    idx++;
                    result[idx] += books[i];
                    //Console.WriteLine("i : "+ i + " idx : " + idx);
                }
            }

            int cnt = result.Where(item => item != 0).ToList().Count;
            Console.WriteLine(cnt);
        }