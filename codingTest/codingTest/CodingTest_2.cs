namespace System;

class CodingTest_2
{
    public void codingTest2()
    {
        //[1] 9498
        // int input = int.Parse(Console.ReadLine());
        //
        // if (input >= 0 && input <= 100)
        // {
        //     if (input >= 90 && input <= 100)
        //     {
        //         Console.WriteLine("A");
        //     }
        //     else if (input >= 80 && input < 90)
        //     {
        //         Console.WriteLine("B");
        //     }
        //     else if (input >= 70 && input < 80)
        //     {
        //         Console.WriteLine("C");
        //     }
        //     else if (input >= 60 && input < 70)
        //     {
        //         Console.WriteLine("D");
        //     }
        //     else
        //     {
        //         Console.WriteLine("F");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("0 ~ 100의 점수를 다시 입력하세요.");
        //     input = int.Parse(Console.ReadLine());
        // }
        
        //[2] 2753
        // int year = int.Parse(Console.ReadLine());
        //
        // if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        // {
        //     Console.WriteLine("1");
        // }
        // else
        // {
        //     Console.WriteLine("0");
        // }

        //[3] 2884
        // string[] time = Console.ReadLine().Split(" ");
        //
        // int H = int.Parse(time[0]);
        // int M = int.Parse(time[1]) - 45;
        //
        // if (M >= 0 && M <= 59)
        // {
        //     Console.WriteLine("{0} {1}", H, M);
        // }
        // else if (M < 0)
        // {
        //     --H;
        //     if (H < 0)
        //     {
        //         Console.WriteLine("{0} {1}", 24 + H, 60 + M);
        //     }
        //     else
        //     {
        //         Console.WriteLine("{0} {1}", H, 60 + M);
        //     }
        // }
        
        //[4] 2525
        // string[] time = Console.ReadLine().Split(" ");
        // int cookingTime = int.Parse(Console.ReadLine());
        // int H = int.Parse(time[0]);
        // int M = int.Parse(time[1]) + cookingTime;
        //
        // if (M > 59)
        // {
        //     int i = M / 60;
        //     for (int j = 0; j < i; j++) { M -= 60; }
        //     H += i;
        //     
        //     if (H > 23)
        //     {
        //         Console.WriteLine("{0} {1}", H - 24, M);
        //     }
        //     else
        //     {
        //         Console.WriteLine("{0} {1}", H, M);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("{0} {1}", H, M);
        // }
        
        //[5] 2480
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int num = 0;
        int value = 0;

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

        if (input[0] == input[1])
        {
            int temp = input[0];
            input[0] = input[2];
            input[2] = temp;
        }

        for (int i = 0; i < input.Length - 1; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    num++;
                    value = input[i];
                }
                else
                {
                    if (input[i] > input[j])
                    {
                        value = input[i];
                    }
                    else if (input[i] < input[j])
                    {
                        value = input[j];
                    }
                }
            }
        }

        switch (num)
        {
            case 0:
                Console.WriteLine("{0}", value * 100);
                break;
            case 1:
                Console.WriteLine("{0}", 1000 + value * 100);
                break;
            case 3:
                Console.WriteLine("{0}", 10000 + value * 1000);
                break;
        }

    }
}