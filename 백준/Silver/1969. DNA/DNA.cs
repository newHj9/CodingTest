using System;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = input[0];
        int M = input[1];
        string[] DNA = new string[N];

        for (int i = 0; i < N; i++)
        {
            DNA[i] = Console.ReadLine();
        }

        string result = "";
        int cnt = 0;
        
        for (int i = 0; i < M; i++)
        {
            Dictionary<char, int> word = new Dictionary<char, int>();
            for (int j = 0; j < N; j++)
            {
                string dna = DNA[j];
                
                if (!word.ContainsKey(dna[i]))
                {
                    word.Add(dna[i], 1);
                }
                else
                {
                    ++word[dna[i]];
                }
            }

            int sum = word.Values.Sum();
            int max = word.Values.Max();
            
            word = word.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            result += word.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;;
            
            cnt += sum - max;

            // foreach (var w in word)
            // {
            //     Console.WriteLine(w.Key + " " + w.Value);
            // }
        }
        
        Console.WriteLine(result);
        Console.WriteLine(cnt);