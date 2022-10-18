using System.Runtime.Intrinsics.X86;

namespace codingTest;

public class CodingTest_18
{
    public void PRO68645()
    {
        // 삼각 달팽이
        
        // [1] Input
        int n = int.Parse(Console.ReadLine());
        
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        int[] arr = new int[sum];
        
        // [2] Process
        // 1 - 위 -> 아래
        // 2 - 좌 -> 우
        // 3 - 아래 -> 위
        // 1 -> 2 -> 3 -> 1 -> 2... 반복

        // 1
        arr[0] = 1;
        int v = 0, idx = 0, num = sum - n;
        int cnt = 2, upCnt = 0;
        int check = 1;


        for (int i = 1; i <= num; i += v)
        {
            arr[i] = cnt++;
            v = arr[i];
            idx = i;
        }
        
        
        num += n;
        for (int i = idx + 1; i < num; i++)
        {
            arr[i] = arr[i - 1] + 1;
            idx = i;
            v = arr[i];
        }

        cnt = n;
        upCnt += 2;
        for (int i = idx - n; i >= upCnt; i -= cnt)
        {
            arr[i] = v + 1;
            v = arr[i];
            idx = i;
            --cnt;
        }
        num = idx + 1;
        

        foreach (var a in arr)
        {
            Console.WriteLine(a);
        }

        // [3] OutPut 

    }

    public void BJ2897()
    {
        // 몬스터 트럭
    }
}