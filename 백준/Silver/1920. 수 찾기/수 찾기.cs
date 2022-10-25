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
            sb.AppendLine(Search(A, B[i]));
        }
        
        Console.WriteLine(sb.ToString());
        
        string Search(int[] A, int numB)
        {
            int i = A[A.Length / 2] <= numB ? A.Length / 2 : 0;
            int upper = A[A.Length / 2] <= numB ? A.Length : A.Length / 2;

            for (i = i; i < upper; i++)
            {
                if (A[i] == numB)
                {
                    return "1";
                }
            }
            
            return "0";
        }