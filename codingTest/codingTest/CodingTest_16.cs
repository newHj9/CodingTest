namespace codingTest;

public class CodingTest_16
{
    public void PRO34748()
    {
        // K번째 수
        // 하나의 배열이 주어졌을때 배열의 i~j까지 중 k번째 수를 구하는 문제
        
        // [1] Input
        int[] array = new int[] { 1, 5, 2, 6, 3, 7, 4 };
        int[,] commands = new int[,] {{2, 5, 3}, {4, 4, 1}, {1, 7, 3}};
        
        int[] answer = new int[commands.GetLength(0)];

        // [2] Process
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int tempIdx = commands[i, 1] - commands[i, 0] + 1;
            int[] temp = new int[tempIdx];
            for (int j = commands[i, 1] - 1; j >= commands[i, 0] - 1; j--)
            {
                temp[--tempIdx] = array[j];
            }
            Array.Sort(temp);
            answer[i] = temp[commands[i, 2] - 1];
        }
        
        // [3] Output
        foreach (int a in answer)
        {
            Console.WriteLine(a);
        }
    }

    public void BJ1337()
    {
        // 올바른 배열 : 어떤 배열 속에 있는 원소 중 5개가 연속적인 것
        // 배열의 값이 연속되도록 추가해야하는 값의 개수

        // [1] Input
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // [2] Process
        //arr = arr.Distinct().ToArray();
        Array.Sort(arr);

        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            // arr[j] - arr[i]의 차는 무조건 1, 2, 3, 4 중에서 가능
            // 대신 1, 2, 3, 4의 차는 한번만 사용 가능
            // 그래서 한번 사용한 check는 true로 변경해서 막아둠
            // 아래의 if 조건을 만족하면 result 증가시킴
            bool[] check = new bool[] {true, false, false, false, false};
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = 1; k < check.Length; k++)
                {
                    if (check[k] == false && arr[j] - arr[i] == k)
                    {
                        check[k] = true;
                        result[i]++;
                        //Console.WriteLine(result[i]);
                    }
                }
            }
        }
        
        Array.Sort(result);
        
        // [3] OutPut
        Console.WriteLine(4 - result[arr.Length - 1]);
    }

    public void BJ15652()
    {
        // N과 M(4)
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        // int NM(int N, int i)
        // {
        //     if (N == i)
        //     {
        //         return 0;
        //     }
        //     
        //     for (int j = i; j <= N; j++)
        //     {
        //         Console.Write($"{j} ");
        //         return NM(N, j);
        //     }
        //     Console.WriteLine();
        // }
    }

    public void BJ11053()
    {
        // 가장 긴 증가하는 부분 수열
        
    }
}