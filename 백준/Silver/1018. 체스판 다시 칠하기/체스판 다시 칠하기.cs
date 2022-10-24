using System;
using System.Collections.Generic;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = input[0];
        int M = input[1];

        char[][] chess = new char[N][];
        List<int> check = new List<int>();
        bool firstWord;

        for (int i = 0; i < N; i++)
        {
            chess[i] = Console.ReadLine().ToCharArray();
        }

        for (int i = 0; i <= N - 8; i++)
        {
            for (int j = 0; j <= M - 8; j++)
            {
                firstWord = chess[i][j] == 'W' ? true : false;
                int cnt1 = 0;
                int cnt2 = 0;
                for (int k = 0 + i; k < 8 + i; k++)
                {
                    for (int l = 0 + j; l < 8 + j; l++)
                    {
                        if (k % 2 == 0)
                        {
                            if (l % 2 == 0)
                            {
                                if (chess[k][l] == 'B')
                                    cnt1++;
                            }
                            else
                            {
                                if (chess[k][l] == 'W')
                                    cnt1++;
                            }
                        }
                        else if(k % 2 != 0)
                        {
                            if (l % 2 != 0)
                            {
                                if (chess[k][l] == 'B')
                                    cnt1++;
                            }
                            else
                            {
                                if (chess[k][l] == 'W')
                                    cnt1++;
                            }
                        }
                        
                        if (k % 2 == 0)
                        {
                            if (l % 2 == 0)
                            {
                                if (chess[k][l] == 'W')
                                    cnt2++;
                            }
                            else
                            {
                                if (chess[k][l] == 'B')
                                    cnt2++;
                            }
                        }
                        else if(k % 2 != 0)
                        {
                            if (l % 2 != 0)
                            {
                                if (chess[k][l] == 'W')
                                    cnt2++;
                            }
                            else
                            {
                                if (chess[k][l] == 'B')
                                    cnt2++;
                            }
                        }
                    }
                }
                check.Add(cnt1);
                check.Add(cnt2);
            }
        }

        Console.WriteLine(check.Min());