using System;
using System.Text;

int T = int.Parse(Console.ReadLine());
        string[][] S = new string[T][];
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < S.GetLength(0); i++)
        {
            S[i] = Console.ReadLine().Split(' ').ToArray();
        }

        for (int i = 0; i < S.GetLength(0); i++)
        {
            string str = S[i][1];
            for (int j = 0; j < str.Length; j++)
            {
                for (int k = 0; k < int.Parse(S[i][0]); k++)
                {
                    sb.Append(str[j]);
                }
            }
            Console.WriteLine(sb);
            sb.Clear();
        }