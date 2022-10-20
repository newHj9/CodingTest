using System;

// [1] input
        int T = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < T; i++)
        {
            int N = int.Parse(Console.ReadLine());
            int[] P = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> Normal = new List<int>();
            List<int> Sale = new List<int>();

            // [2] Process
            
            // 4배수인 정상가 저장(확실 X) 
            for(int j = P.Length - 1; j >= 0; j--)
            {
                if (P[j] % 4 == 0)
                {
                    Normal.Add(P[j]);
                }
            }
            
            // 정상가랑 섞은 가격들 비교
            for (int j = 0; j < Normal.Count; j++)
            {
                for (int k = 0; k < P.Length - 1; k++)
                {
                    // 정상가의 할인가랑 맞으면 저장
                    if (Normal[j] * 0.75 == P[k])
                    {
                        Sale.Add(P[k]);
                        
                        // 정상가에 할인가가 있으면 그 값을 0으로 변경
                        for (int l = 0; l < Normal.Count; l++)
                        {
                            if (P[k] == Normal[l])
                            {
                                Normal[l] = 0;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            
            Sale.Sort();

            // [3] Output
            
            Console.Write("Case #" + (i + 1) +":");

            foreach (var s in Sale)
            {
                Console.Write(" " + s);
            }
            Console.WriteLine();
        }