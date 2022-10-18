using System.Text;

namespace codingTest;

public class CodingTest_19
{
    public void BJ11654()
    {
        // 아스키코드
        string input = Console.ReadLine();
        
        Console.WriteLine((int)input[0]);
    }

    public void BJ11720()
    {
        // 숫자의 합
        int N = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < N; i++)
        {
            sum += input[i] - '0';
        }
        
        Console.WriteLine(sum);
    }

    public void BJ10809()
    {
        // 알파벳 찾기
        //int[] alpha = new int[26];
        int[] alpha = Enumerable.Repeat(-1, 26).ToArray();
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if(alpha[input[i] - 'a'] == -1)
                alpha[input[i] - 'a'] = i;
        }

        foreach (var a in alpha)
        {
            Console.Write(a + " ");
        }

    }

    public void BJ2675()
    {
        // 문자열 반복
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
    }

    public void BJ1157()
    {
        // 단어 공부
        string input = Console.ReadLine();
        input = input.ToUpper();

        int[] count = Enumerable.Repeat(0, 26).ToArray();
        
        for (int i = 0; i < input.Length; i++)
        {
            ++count[input[i] - 'A'];
        }

        int max = 0, num = 'A';
        char maxC = ' ';
        bool same = false;

        for (int i = 0; i < count.Length; i++)
        {
            if (max < count[i])
            {
                max = count[i];
                maxC = (char)(i + num);
                same = false;
            }
            else if (max == count[i])
            {
                same = true;
            }
        }

        if (same == true)
        {
            maxC = '?';
        }

        /*
        for (int i = 0; i < count.Length; i++)
        {
            if (max == count[i])
            {
                maxC = '?';
                break;
            }
        }
        */
        
        Console.WriteLine(maxC);
    }

    public void BJ1152()
    {
        // 단어의 개수
        string[] input = Console.ReadLine().Split(" ").ToArray();
        int length = input.Length;
        
        if(input[0] == "")
        //if(String.IsNullOrEmpty(input[0]))
            length -= 1;
        if (String.IsNullOrEmpty(input[input.Length - 1]))
            length -= 1;
        
        Console.WriteLine(length);
    }

    public void BJ2908()
    {
        // 상수
        string[] input = Console.ReadLine().Split().ToArray();
        int[] num = new int[input.Length];
        int n = 1;
        
        for (int i = 0; i < input.Length; i++)
        {
            string str = input[i];
            for (int j = 0; j < str.Length; j++)
            {
                num[i] += (str[j] - '0') * n;
                n *= 10;
            }
            n = 1;
        }

        int max = 0;

        foreach (var c in num)
        {
            if (max < c)
                max = c;
        }

        Console.WriteLine(max);
    }

    public void BJ5622()
    {
        // 다이얼
        string input = Console.ReadLine();
        int second = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'S')
            {
                second += 7;
                Console.WriteLine(7);
            }
            else if (input[i] == 'V')
            {
                second += 8;
                Console.WriteLine(8);
            }
            else if (input[i] == 'Y' || input[i] == 'Z')
            {
                second += 9;
                Console.WriteLine(9);
            }
            else
            {
                second += ((input[i] - 'A') / 3) + 2;
                Console.WriteLine(((input[i] - 'A') / 3) + 2);
            }
        }
        
        Console.WriteLine(second + input.Length);
    }

    public void BJ2941()
    {
        string[] croatia = new[] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

        string input = Console.ReadLine();

        for (int i = 0; i < croatia.Length; i++)
        {
            if (input.Contains(croatia[i]))
            {
                input = input.Replace(croatia[i], "!");
            }
        }

        Console.WriteLine(input.Length);
    }

    public void BJ1316()
    {
        // 그룹 단어 체커
        int N = int.Parse(Console.ReadLine());
        string[] S = new string[N];

        for (int i = 0; i < N; i++)
        {
            S[i] = Console.ReadLine();
        }

        int cnt = S.Length;
        bool isSame = false;

        for (int i = 0; i < S.Length; i++)
        {
            string temp = S[i];
            cnt += checkWord(temp);
        }

        Console.WriteLine(cnt);

    }

    static int checkWord(string temp)
    {
        bool[] check = new bool[26];
        for (int i = 0; i < temp.Length; i++)
        {
            if (check[temp[i] - 'a'] == false)
            {
                check[temp[i] - 'a'] = true;
            }
            else
            {
                if (temp[i - 1] != temp[i])
                    return -1;
            }
        }
        
        return 0;
    }

}