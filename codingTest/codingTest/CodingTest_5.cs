using System.Security.Cryptography.X509Certificates;

namespace codingTest;

public class CodingTest_5
{
    public void Q4673()
    {
        int[] arr = new int[10000];

        for (int i = 1; i < arr.Length; i++)
        {
            d(i, arr);
        }

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    static int d(int n, int[] arr)
    {
        if (n > 10000)
        {
            return 0;
        }
        else
        {
            string num = n.ToString();
            int sum = 0;

            if (num.Length == 1)
            {
                sum = n;
            }
            else
            {
                for (int i = 0; i < num.Length; i++)
                {
                    sum += num[i] - '0';
                }
            }

            n += sum;

            if (n < 10000)
            {
                arr[n]++;
            }

            return n;
        }
    }

    public void Q1065()
    {
        int input = int.Parse(Console.ReadLine());
        int num = 99;

        if (input <= num)
        {
            Console.WriteLine(input);
        }
        else
        {
            for (int i = 100; i <= input; i++)
            {
                int[] inputs = i.ToString().Select((c) => c - '0').ToArray();
                int count = 0;
                for (int j = 1; j < inputs.Length - 1; j++)
                {
                    if (inputs[j - 1] - inputs[j] == inputs[j] - inputs[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count == inputs.Length - 2)
                {
                    num++;
                }
            }
        
            Console.WriteLine(num);
        }
    }
}