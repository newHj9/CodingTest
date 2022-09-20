using System.ComponentModel;
using System.Numerics;

namespace codingTest;

public class CodingTest_7
{
    public void Q1193()
    {
        // 분수 찾기 - 브론즈 1
        // 1/1 -> 1/2 -> 2/1 -> 3.1 -> 2/2 -> ... 지그재그 순서로 차례대로 1번, 2번, 3번, 4번, 5번
        
        // //[1] input
        // int input = int.Parse(Console.ReadLine());
        //
        // //[2] process
        // int cnt = 0;
        // int remainder = input;
        //
        // for (int i = 1; i <= input; i++)
        // {
        //     remainder -= i;
        //     if (remainder <= 0)
        //     {
        //         cnt = i;
        //         break;
        //     }
        // }
        //
        // //[3] output
        //
        // if (input == 1)
        // {
        //     Console.WriteLine("1/1");
        // }
        // else
        // {
        //     if (cnt % 2 == 0)
        //     {
        //         int child = cnt + remainder; 
        //         int parent = (cnt + 1) - child;
        //         Console.WriteLine($"{child}/{parent}");
        //     }
        //     else
        //     {
        //         int parent = cnt + remainder; 
        //         int child = (cnt + 1) - parent;
        //         Console.WriteLine($"{child}/{parent}");
        //     }
        // }
        
        int num = int.Parse(Console.ReadLine());
        int idx = 0;
        int sum = 0;

        while (sum < num)
        {
            sum += ++idx;
        }
        
        Console.WriteLine(sum);
        Console.WriteLine(idx);
        
        sum -= idx;
        Console.WriteLine(sum);
        Console.WriteLine(num - sum - 1);

        int i = idx;
        int j = 1;

        for (int x = 0; x < num - sum - 1; x++)
        {
            i--;
            j++;
        }

        if (idx % 2 != 0)
            Console.WriteLine($"{i}/{j}");
        else
            Console.WriteLine($"{j}/{i}");
    }

    public void Q2775()
    {
        // 부녀회장이 될테야 - 브론즈 1
        // 아파트 거주 조건 : a층의 b호에 살려면 자신의 아래(a-1)층의 1호부터 b호까지 사람들의 수의 합만큼 사람들을 데려와 살야야함
        // 비어있는 집은 없고 모든 거주민들이 이 계약 조건을 지키고 왔다고 가정
        // 주어지는 양의 정수 k와 n에 대해 k층에 n호에는 몇 명이 살고 있는지 출력
        // 아파트에는 0층부터 있고 각층에는 1호부터 있으며, 0층의 i호에는 i명이 삶
        
        //[1] input
        // Test Case의 수 T가 주어짐. 첫번째 줄 정수 k, 두번째 줄에 정수 n
        int T = int.Parse(Console.ReadLine());
        int[] k = new int[T];
        int[] n = new int[T];

        for (int i = 0; i < T; i++)
        {
            k[i] = int.Parse(Console.ReadLine());
            n[i] = int.Parse(Console.ReadLine());
        }

        //[2] process
        int[] result = new int[T];
        
        for (int i = 0; i < T; i++)
        {
            result[i] = Apart(k[i], n[i]);
        }

        //[3] output
        // 각각의 Test case에 해당하는 집에 거주민 수 출력
        for (int i = 0; i < T; i++)
        {
            Console.WriteLine(result[i]);
        }
        
        
        int Apart(int k, int n)
        {
            int[,] arr = new int[k + 1, n + 1];
        
            for (int i = 1; i <= n; i++)
            {
                arr[0, i] = i;
            }

            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int sum = 0;
                    for (int l = 1; l <= j; l++)
                    {
                        sum += arr[i - 1, l];
                    }
                    arr[i, j] = sum;
                }
            }

            return arr[k, n];
        }
    }

    public void Q10757()
    {
        // 큰수 A + B - 브론즈 5

        BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
        Console.WriteLine(input[0] + input[1]);
    }

    public void Q2292()
    {
        // 벌집 - 브론즈 2
        // 중앙의 방 1부터 시작해서 이웃하는 방에 돌아가면서 1씩 증가하는 번호를 주소로 매김
        // 숫자 N이 주어졌을 때, 벌집의 중앙 1에서 N번 방까지 최소 개수의 방을 지나서 갈때 몇개의 방을 지나가는지
        
        // [1] input
        int input = int.Parse(Console.ReadLine());

        // [2] process
        int count = 1;
        int sum = 1;
        
        while(input > sum)
        {
            sum += 6 * count;
            count++;
        }

        // [3] output
        // 주어진 방까지 최소 개수의 방을 지나서 갈떄 몇 개의 방을 지나는지 
        Console.WriteLine(count);
    }

    public void Q2839()
    {
        // 설탕배달 - 실버 4
        // 봉지 - 3, 5 킬로그램
        // 가장 적은 개수의 봉지는?

        // [1] input - 설탕 킬로그램
        int input = int.Parse(Console.ReadLine());
        int cnt = 0;

        //[2] process

        while (input > 0)
        {
            if (input % 5 == 0)
            {
                input -= 5;
                cnt++;
            }
            else if (input % 3 == 0)
            {
                input -= 3;
                cnt++;
            }
            else if (input > 5)
            {
                input -= 5;
                cnt++;
            }
            else
            {
                cnt = -1;
                break;
            }
        }

        //[3] output - 봉지 수
        Console.WriteLine(cnt);
    }

    
    
}