namespace codingTest;

public class CodingTest_10
{
    public void Q25305()
    {
        // 커트라인
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] score = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Array.Sort(score);

        Console.WriteLine(score[input[0] - input[1]]);
    }
    
    public void Q2750()
    {
        // 수 정렬하기

        int cnt = int.Parse(Console.ReadLine());
        int[] input = new int[cnt];

        for (int i = 0; i < cnt; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < input.Length - 1; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] > input[j])
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
        }

        foreach (var i in input)
        {
            Console.WriteLine(i);
        }
    }
    
    public void Q1427()
    {
        // 소트인사이트

        int[] input = Console.ReadLine().Select(c => c - '0').ToArray();
        
        Array.Sort(input);

        for (int i = input.Length-1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
    }
    
    public void Q15649()
    {
        // N과 M(1)

        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 1; i <= input[0]; i++)
        {
            Console.Write(i + " ");
            for (int j = 1; j < input[0]; j++)
            {
                if (i == j)
                {
                    continue;
                }
                else
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
    }
    
    
    public void Q15650()
    {
        // N과 M(2)
    }
}