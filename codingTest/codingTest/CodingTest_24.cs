using System.ComponentModel.Design;
using System.Data;
using System.Numerics;

namespace codingTest;

public class CodingTest_24
{
    public void BJ1769()
    {
        // 3의 배수
        // input이 1자리일때 고려 안해서 계속 틀림 ㅠㅜ
        
        string input = Console.ReadLine();
        int cnt = 0;
        
        string result = func(input);
        
        Console.WriteLine(cnt);
        Console.WriteLine(result);
        
        string func(string str)
        {
            if (str.Length == 1)
            {
                string result = int.Parse(str) % 3 != 0 ? "NO" : "YES";
                
                return result;
            }
            else
            {
                cnt++;
                string sum = str.Select(c => c - '0').Sum().ToString();
                
                return func(sum.ToString());
            }
        }
    }

    public void BJ12033()
    {
        // 김인천씨의 식료품가게 (Small)
        // 모든 제품은 0.25 할인
        // 정상가는 4의 배수인 정수
        // 할인가는 정상 가격의 정확히 0.75, 모두 정수
        
        // 케이스 수 T
        // 상품수 N
        // 정상가와 할인가가 섞인 오름차순 가격표 P1...
        // 할인 가격에 해당하는 오름차순을 정렬하라
        
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
            
            // 정상가랑 섞인 가격들 비교
            // 20 16 12 12 12 
            // 9 9 12 12 12 15 16 20 <- 이 중에서 할인가를 찾기 위해
            for (int j = 0; j < Normal.Count; j++)
            {
                for (int k = 0; k < P.Length - 1; k++)
                {
                    // 정상가의 할인가랑 맞으면 저장
                    if (Normal[j] * 0.75 == P[k])
                    {
                        Sale.Add(P[k]);
                        
                        // 정상가에 할인가가 있으면 그 값을 0으로 변경
                        // 20 16 12 12 12 
                        // 15 12 <- 이때 확인하는 For문 
                        // Normal : 20 16 0 12 12 이 됨
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
    }

    public void BJ1969()
    {
        // DNA : 어떤 유전물질을 구성하는 분자
        // 4개의 뉴클레오티드 이루어짐 : Adenine, Thymine, Guanine, Cytosine
        // 각 문자의 앞글자를 따서 DNA 표현 가능
        // Hamming Distance란 길이가 같은 두 DNA가 있을 때, 뉴클로티드 문자가 다른 개수
        
        // N : DNA 수
        // M : DNA 문자열 길이
        // 1 출력 : Hamming Distance가 가장 작은 DNA
        // 2 출력 : Hamming Distance의 합
        
        /// 아래 풀이 완전 잘못됨 ㅠㅜ
        // 0 : TATGATAC     2 : 2+3+2+2 = 9
        // 1 : TAAGCTAC     2 : 2+3+2+3 = 10
        // 2 : AAAGATCC     2 : 3+3+3+3 = 12
        // 3 : TGAGATAC     2 : 2+2+3+3 = 9
        // 4 : TAAGATGT     2 : 2+3+3+3 = 11

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
            // 문자열의 각 인덱스 별로 가져와 저장
            // 0 : TATGATAC - [0]     Dic 1 : word(T, 1)
            // 1 : TAAGCTAC - [0]     Dic 1 : word(T, 2)
            // 2 : AAAGATCC - [0]     Dic 2 : word(A, 1)
            // ...
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
            
            // 사전순으로 나오게 하기 위해 내림차순을 함. Z ~ A로 검사하기때문에 값이 같으면 A가 나옴
            word = word.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            // value 중 가장 큰 값의 Key를 가져옴
            result += word.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;;
            
            cnt += sum - max;

            // foreach (var w in word)
            // {
            //     Console.WriteLine(w.Key + " " + w.Value);
            // }
        }
        
        Console.WriteLine(result);
        Console.WriteLine(cnt);
    }
}