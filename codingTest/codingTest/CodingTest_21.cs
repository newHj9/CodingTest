namespace codingTest;

public class CodingTest_21
{
    public void BJ4344()
    {
        int C = int.Parse(Console.ReadLine());
        int[][] input = new int[C][];
        float[] ave = new float[C];
        int[] stu = new int[C];
        float[] result = new float[C];

        for (int i = 0; i < C; i++)
        {
            input[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for (int i = 0; i < input.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 1; j < input[i].GetLength(0); j++)
            {
                sum += input[i][j];
            }
            ave[i] = (float)sum / input[i][0];
            Console.WriteLine(ave[i]);

            for (int j = 1; j < input[i].GetLength(0); j++)
            {
                if (ave[i] < input[i][j])
                    stu[i]++;
            }
            result[i] = stu[i] / (float)input[i][0];
        }

        foreach (var r in result)
        {
            Console.WriteLine("{0:#0.000%}", r);
        }
    }

    public void BJ2562()
    {
        //using System;

        int[] input = new int[9];
        int max = 0, maxIdx = 0;

        for(int i = 0; i < 9; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
            if(max < input[i])
            {
                max = input[i];
                maxIdx = i;
            }
        }

        Console.WriteLine(max);
        Console.WriteLine(maxIdx + 1);
    }

    public void BJ1712()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        long cnt = -1;

        if (input[1] < input[2])
        {
            long result = -1;

            result = input[2] - input[1];
            cnt = input[0] / result;

            Console.WriteLine(cnt + 1);
        }
        else if(input[1] >= input[2])
        {
            Console.WriteLine(cnt);
        }
    }

    public void BJ10250()
    {
        // ACM 호텔

        int T = int.Parse(Console.ReadLine());
        int[][] input = new int[T][];
        int[] floor = new int[T];
        
        for (int i = 0; i < T; i++)
        {
            input[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        
        for (int i = 0; i < T; i++)
        {
            int H = input[i][0];
            int W = input[i][1];
            int N = input[i][2];

            if (N % H != 0)
                floor[i] = ((N % H) * 100) + ((N / H) + 1);
            else
                floor[i] = (H * 100) + (N / H);
        }

        foreach (var f in floor)
        {
            Console.WriteLine(f);
        }
    }
}