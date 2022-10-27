using System;
using System.Text;

int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int M = int.Parse(Console.ReadLine());
        int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();

        StringBuilder sb = new StringBuilder();
        
        Array.Sort(A);

        for (int i = 0; i < M; i++)
        {
            int num = B[i], start = 0, end = N - 1, mid = 0;
            bool check = false;
            while (start <= end)
            {
                mid = (start + end) / 2;
                
                if (A[mid] < num)
                {
                    start = mid + 1;
                }
                else if (A[mid] > num)
                {
                    end = mid - 1;
                }
                else if (A[mid] == num)
                {
                    sb.AppendLine("1");
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                sb.AppendLine("0");
            }
        }
        
        Console.WriteLine(sb.ToString());