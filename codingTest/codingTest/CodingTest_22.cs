using System.Text;

namespace codingTest;

public class CodingTest_22
{
    
    public void BJ4673()
    {
        // 셀프 넘버
        bool[] result = new bool[10000];
        /*
        for (int i = 0; i < result.Length; i++)
        {
            int hansu = 0;
            if (i < 10)
            {
                hansu = i * 2;
            }
            else
            {
                string num = i.ToString();
                for (int j = 0; j < num.Length; j++)
                {
                    hansu += num[j] - '0';
                }
                hansu += i;
            }

            if (hansu > result.Length - 1)
            {
                continue;
            }
            result[hansu] = true;
        }
        */

        for (int i = 0; i < result.Length; i++)
        {
            result[SelfNum(i)] = true;
        }
        
        for (int i = 1; i < result.Length; i++)
        {
            if(!result[i])
                Console.WriteLine(i);
        }
    }

    static int SelfNum(int idx)
    {
        int hansu = idx;
        int num = idx;

        while (num > 0)
        {
            hansu += num % 10;
            num /= 10;
        }

        if (hansu > 10000 - 1)
        {
            return 0;
        }
        else
        {
            return hansu;
        }
    }

    public void BJ1065()
    {
        // 한수
        int input = int.Parse(Console.ReadLine());
        int cnt = 99;

        if (input > 99)
        {
            for (int i = 100; i <= input; i++)
            {
                string num = i.ToString();
                int[] diff = new int[num.Length - 1];
                for (int j = 0; j < diff.Length; j++)
                {
                    diff[j] = (num[j] - '0') - (num[j + 1] - '0');
                }

                for (int j = 0; j < diff.Length - 1; j++)
                {
                    if (diff[j] != diff[j + 1])
                    {
                        break;
                    }

                    cnt++;
                }
            }
        }
        else
        {
            cnt = input;
        }
        
        Console.WriteLine(cnt);
    }

    public void BJ2751()
    {
        // 수정렬하기 2
        StringBuilder sb = new StringBuilder();
        
        int N = int.Parse(Console.ReadLine());
        List<int> input = new List<int>();
        

        for (int i = 0; i < N; i++)
        {
            input.Add(int.Parse(Console.ReadLine()));
        }

        input.Sort();

        foreach (var i in input)
        {
            sb.AppendLine(i.ToString());
        }
        
        Console.WriteLine(sb);
    }
    
}