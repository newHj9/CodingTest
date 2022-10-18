using System.Collections.Immutable;

namespace codingTest;
using System.Linq;

public class CodingTest_23
{
    public void BJ2204()
    {
        List<string> input = new List<string>();
        int cnt = 0;
        string check = "";
        
        while (check != "0")
        {
            input.Add(Console.ReadLine());
            check = input[cnt];
            cnt++;
        }
        
        int idx = 0;
        
        while (true)
        {
            // 왜 한번 더 돌지???
            // if (idx > input.Count)
            // {
            //     break;
            // }
            
            if (input[idx] == "0")
            {
                break;
            }
            
            int N = int.Parse(input[idx]);
            
            Dictionary<string, int> words = new Dictionary<string, int>();
            for (int i = idx + 1; i <= N + idx; i++)
            {
                words.Add(input[i].ToLower(), i);
            }

            List<string> wordKey = words.Keys.ToList();
            wordKey = wordKey.OrderBy(x => x).ToList();
            
            Console.WriteLine(input[words[wordKey[0]]]);
            Console.WriteLine(wordKey.Count);
            // 3
            // 4
            // 0
            
            idx += N + 1;
        }
    }

    public void BJ19947()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        int[] money = new int[3];
        int cnt = input[1];

    }
}