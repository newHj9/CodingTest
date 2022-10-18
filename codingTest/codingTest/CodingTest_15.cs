using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace codingTest;

public class CodingTest_15
{
    public void EX86491()
    {
        // 최소직사각형 - 프로그래머스
        int[,] sizes = new int[,] { {10, 7}, {12, 3}, {8, 15}, {14, 7}, {5, 15}};
        int MaxIdx0 = 0;
        int MaxIdx1 = 0;
        bool maxCheck = false;
        
        // 너비와 길이의 최대값을 구한다.
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (MaxIdx0 < sizes[i, 0])
            {
                MaxIdx0 = sizes[i, 0];
            }

            if (MaxIdx1 < sizes[i, 1])
            {
                MaxIdx1 = sizes[i, 1];
            }
        }
        
        // 너비와 길이의 최대값 비교해 가장 큰 수를 가진 것이 너비인지 길이인지를 확인한다. 
        maxCheck = MaxIdx0 > MaxIdx1 ? false : true;
        
        // 너비가 크다면, sizes[i, 0]와 sizes[i, 1]를 비교해 sizes[i, 1]가 크다면 값을 바꾼다.
        // 길이는 반대로 적용
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            for (int j = 0; j < sizes.GetLength(1); j++)
            {
                if (!maxCheck)
                {
                    if (sizes[i, 0] < sizes[i, 1])
                    {
                        int temp = sizes[i, 1];
                        sizes[i, 1] = sizes[i, 0];
                        sizes[i, 0] = sizes[i, 1];
                    }
                }
                else
                {
                    if (sizes[i, 0] > sizes[i, 1])
                    {
                        int temp = sizes[i, 0];
                        sizes[i, 0] = sizes[i, 1];
                        sizes[i, 1] = sizes[i, 0];
                    }
                }
            }
        }

        // 너비와 길이의 최대값을 구한다.
        MaxIdx0 = 0;
        MaxIdx1 = 0;
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (MaxIdx0 < sizes[i, 0])
            {
                MaxIdx0 = sizes[i, 0];
            }

            if (MaxIdx1 < sizes[i, 1])
            {
                MaxIdx1 = sizes[i, 1];
            }
        }
        
        Console.WriteLine($"Max index 0 = {MaxIdx0}, Max index1 = {MaxIdx1}, answer = {MaxIdx0 * MaxIdx1}");
    }

    public void EX2869()
    {
        // 달팽이는 올라가고 싶다

        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        // 하루동안 올라갈 수 있는 길이
        int m = input[0] - input[1];
        
        // 정상에 올라가면 미끌어지지 않으니 밤에 미끌어지는 길이를 빼줌
        int top = input[2] - input[1];

        // top에 m를 나누어주면 며칠이 걸렸는지 나옴
        int day = top / m;
        
        // 대신, top % m가 나누어 떨어지지 않으면, + 1를 해줌. 정상에 올라가서 미끌어지지 않으므로
        if(top % m != 0)
            Console.WriteLine(day + 1);
        else
            Console.WriteLine(day);
    }

    public void EX1620()
    {
        // 나는야 포켓몬 마스터 이다솜
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = input[0];
        int M = input[1];

        Dictionary<int, string> Pokemon = new Dictionary<int, string>();
        string[] Q = new string[M];
        
        for (int i = 1; i <= N; i++)
        {
            Pokemon.Add(i, Console.ReadLine());
        }
        
        StringBuilder std = new StringBuilder();

        for (int i = 0; i < Q.Length; i++)
        {
            Q[i] = Console.ReadLine();
            
            int temp = 0;
            if(int.TryParse(Q[i], out temp))
            {
                std.Append(Pokemon[temp] + "\n");
            }
            else
            {
                std.Append(Pokemon.FirstOrDefault(x => x.Value == Q[i]).Key  + "\n");
            }
        }

        Console.WriteLine(std);
    }

    public void EX11047()
    {
        // 동전0
    }
}