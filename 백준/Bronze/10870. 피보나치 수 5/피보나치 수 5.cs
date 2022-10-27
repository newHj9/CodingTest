using System;

int N = int.Parse(Console.ReadLine());

        int Fibonacci(int N)
        {
            if (N == 0)
            {
                return 0;
            }
            else if (N == 1)
            {
                return 1;
            }

            return Fibonacci(N - 1) + Fibonacci(N - 2);
        }
        
        Console.WriteLine(Fibonacci(N));