using System;
using System.Text;

int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int M = int.Parse(Console.ReadLine());
        int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Array.Sort(A);

        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < B.Length; i++)
        {
            sb.AppendLine(Search(A, B[i]).ToString());
        }
        
        Console.WriteLine(sb.ToString());
        
        int Search(int[] A, int numB)
        {
            int i = 0;
            int upper = 0;
            if (A[A.Length / 2] <= numB)
            {
                i = A.Length / 2;
                upper = A.Length;
            }
            else
            {
                i = 0;
                upper = A.Length / 2;
            }
            for (i = i; i < upper; i++)
            {
                if (A[i] == numB)
                {
                    return 1;
                }
            }
            
            return 0;
        }