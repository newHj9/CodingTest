using System.Net.Sockets;

namespace codingTest;

public class CodingTest_17
{
    public void BJ9372()
    {
        // 상근이의 여행
        // 가장 적은 종류의 비행기를 타고 모든 국가를 여행할 수 있도록
        // 한 국가 -> 다른 국가 이동 (다른 국가 거쳐도 됨. 방문한 국가도 오케이)
        
        // [1] Input
        // 1. 테스트 케이스 T
        // 2. 국가의 수 N / 비행기의 종류 M
        
        
        // [2] Process
        
        // [3] Output
        // 모든 국가를 여행하기 위해 타야 하는 비행기 종류의 최소 개수
    }

    public void BJ20004()
    {
        // 베스킨라빈스 31
        // 1 ~ 31까지의 수를 순차적으로 한번에 1개 이상, 3개 이하 연달아 부를 수 있음
        // 마지막 31을 부른 사람이 지는 게임
        
        // [1] Input
        int A = int.Parse(Console.ReadLine());
        
        // 한 게임에서 "민우 -> 시온"으로 넘어가는 걸 한번을 쳤을 떄, 최대 개수가 31
        // 한번에 부를 수 있는 최대 개수가 A
        // 각 List[] = {0 ~ A};가 들어감
        List<int[]> BR = new List<int[]>();

        for (int i = 0; i <= 31; i++)
        {
            int[] arr = Enumerable.Range(0, A).ToArray();
            BR.Add(arr);
        }
        
        int[,] cnt = new int[10, 10];
        
        // [2] Process
        // 민우 차례인지 시온 차례인지 확인하기위해
        int game(int num, bool check, int cnt)
        {
            if (num > 31)
            {
                if (!check)
                    return 1;
                else
                    return 0;
            }
            
            int[] arr = BR[num];
            for (int i = 1; i < arr.Length; i++)
            {
                if (check)
                    check = false;
                else
                    check = true;
                
                cnt += game(num + arr[i], check, cnt);
            }
                
            return cnt;
        }

        // [3] Output
        for (int i = 1; i <= A; i++)
        {
            Console.WriteLine(game(1, false, 0));
        }

    }

    public void PRO12914()
    {
        // 멀리뛰기
        // 효진이는 무조건 1칸 또는 2칸 뛸 수 있음

        // [1] input
        int n = 3;
        int[] hyojin = new int[] {1, 2};

        // [2] Process

        int result(int sum, int i, int n)
        {
            if (sum >= n)
            {
                return 1;
            }
                

            sum += hyojin[i];

            return result(sum, i, n--);
        }
        

        // [3] Output 

    }

    public void PRO42586()
    {
        // 기능개발
        
    }

    public void PRO92334()
    {
        int k = 2;
        string[] id_list = new string[] {"muzi", "frodo", "apeach", "neo"};
        string[] report = new string[] {"muzi frodo","apeach frodo","frodo neo","muzi neo","apeach muzi"};

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        Dictionary<string, int> cnt = new Dictionary<string, int>();

        for(int i = 0; i < report.Length; i++)
        {
            string[] str = report[i].Split(" ").ToArray();

            if (!dic.ContainsKey(str[0]))
            {
                dic.Add(str[0], new List<string>());
                dic[str[0]].Add(str[1]);
                //Console.WriteLine(str[0]);
            }
            else if (dic[str[0]].Contains(str[1]))
            {
                continue;
            }
            else
            {
                dic[str[0]].Add(str[1]);
            }

            if (!cnt.ContainsKey(str[1]))
            {
                cnt.Add(str[1], 1);
            }
            else
            {
                ++cnt[str[1]];
            }
        }

        foreach (KeyValuePair<string, List<string>> item in dic)
        {
            foreach (var i in item.Value)
            {
                Console.WriteLine("[{0}:{1}]", item.Key, i);
            }
        }

        foreach (var c in cnt)
        {
            Console.WriteLine("[{0}:{1}]", c.Key, c.Value);
        }
        
        int[] answer = new int[id_list.Length];
        Dictionary<string, int> id = new Dictionary<string, int>();

        foreach (var i in id_list)
        {
            id.Add(i, 0);
        }

        foreach (KeyValuePair<string, List<string>> item in dic)
        {
            foreach (var i in item.Value)
            {
                if (cnt[i] >= k)
                {
                    ++id[item.Key];
                }
            }
        }
        
        foreach (var i in id.Values)
        {
            Console.WriteLine(i);
        }
    }
}
        

