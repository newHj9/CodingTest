using System.Xml.XPath;

namespace codingTest;

public class CodingTest_4
{
    //[1] 숫자의 개수
    public void Q2577()
    {
        int inputA = int.Parse(Console.ReadLine());
        int inputB = int.Parse(Console.ReadLine());
        int inputC = int.Parse(Console.ReadLine());

        int result = inputA * inputB * inputC;
        char[] resultChar = result.ToString().ToCharArray();
        int[] resultArr = Array.ConvertAll(resultChar, c => (int)Char.GetNumericValue(c));;

        int[] count = new int[10];

        for (int i = 0; i < count.Length; i++)
        {
            for (int j = 0; j < resultArr.Length; j++)
            {
                if (i == resultArr[j])
                {
                    ++count[i];
                }
            }
        }
        
        foreach (var num in count)
        {
            Console.WriteLine(num);
        }
    }

    //[2] 나머지
    public void Q3052()
    {
        int[] input = new int[10];
        int[] count = new int[42];
        
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        foreach (var a in input)
        {
            for (int i = 0; i < count.Length; i++)
            {
                if (i == a % 42)
                {
                    ++count[i];
                }
            }
        }

        int countResult = 0;
        foreach (var num in count)
        {
            if (num != 0)
            {
                ++countResult;
            }
        }
        
        Console.WriteLine(countResult);
    }
    
    //[3] 평균
    public void Q1546()
    {
        double count = Convert.ToDouble(Console.ReadLine());
        double[] score = Console.ReadLine().Split().Select(Convert.ToDouble).ToArray();
        Array.Sort(score);

        double sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += score[i] / score[score.Length - 1] * 100;
        }

        double avg = sum / count;
        
        Console.WriteLine(avg);
    }
    
    //[4] OX퀴즈
    public void Q8958()
    {
        int count = int.Parse(Console.ReadLine());
        string[] input = new string[count];
        
        for (int i = 0; i < count; i++)
        {
            input[i] = Console.ReadLine();
        }

        foreach (var i in input)
        {
            int countNum = 0;
            int num = 1;
            for (int j = 0; j < i.Length; j++)
            {
                if (i[j] == 'O')
                {
                    countNum += num++;
                }
                else if(i[j] == 'X')
                {
                    num = 1;
                }
            }
            Console.WriteLine(countNum);
        }
    }
    
    //[5] 최소, 최대
    public void Q10818()
    {
        int count = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int max = input[0];
        int min = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (max < input[i])
            {
                max = input[i];
            }
            
            if (min > input[i])
            {
                min = input[i];
            }
        }
        
        Console.WriteLine($"{min} {max}");
        
        //Array.Sort(input);
        
        //Console.WriteLine($"{input[0]} {input[count - 1]}");
    }
}