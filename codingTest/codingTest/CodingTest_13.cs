namespace codingTest;

public class CodingTest_13
{
    public void Q2609()
    {
        // 최대공약수와 최소공배수
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int num1 = input[0] > input[1] ? input[0] : input[1];
        int num2 = input[1] > input[0] ? input[1] : input[0];

        int result = 1;
        
        Func(num1, num2);

        int Func(int num1, int num2, int temp = 2)
        {
            while (num1 > temp)
            {
                int prime = temp == 2 ? 2 : Prime(temp);

                if (prime == 0)
                {
                    temp++;
                }
                else
                {
                    if (num2 % prime == 0 && num1 % prime == 0)
                    {
                        num1 /= prime;
                        num2 /= prime;

                        result *= prime;

                        break;
                    }
                }
            }
            
            return Func(num1, num2, result);
        }

        Console.WriteLine(result);
        Console.WriteLine(result * num1 * num2);
    }
    
    public int Prime(int prime)
    {
        int check = 0;
        for (int i = 2; i < prime; i++)
        {
            if (prime % i == 0)
            {
                check++;
            }
        }

        if (check == 0)
        {
            return prime;
        }
        else
        {
            return 0;
        }
    }

    public void Q9375()
    {
        // 패션왕 신해빈
    }

    public void Q2981()
    {
        // 검문
    }

    public void Q12977()
    {
        // 소수 만들기

        int num = 11;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine("소수 아님");
            }
        }
    }
}