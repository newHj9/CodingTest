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
        int count = 0;
        int sum = 1;
        
        for (int i = 1; i < input; i++)
        {
            sum = i;
            if (sum == input)
            {
                Console.WriteLine(sum);
                ++count;
                sum = 0;
            }
            else if(sum > input)
            {
                Console.WriteLine(sum);
                sum = 0;
            }
        }

        Console.WriteLine(count);
    }
}