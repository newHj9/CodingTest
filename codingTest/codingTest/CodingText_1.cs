// See https://aka.ms/new-console-template for more information
using System;

class CodingTest_1
{
    static void Main(string[] args)
    {
        //[1] Hello World
        // Console.WriteLine("Hello World!");
        
        //[2] 개
        // Console.WriteLine("|\\_/|");
        // Console.WriteLine("|q p|   /}");
        // Console.WriteLine("( 0 )\"\"\"\\");
        // Console.WriteLine("|\"^\"`    |");
        // Console.WriteLine("||_/=\\\\__|");
        
        //[3] 사칙연산
        // string[] input = Console.ReadLine().Split();
        // int a = Convert.ToInt32(input[0]);
        // int b = int.Parse(input[1]);
        //
        // Console.WriteLine(a + b);
        // Console.WriteLine(a - b);
        // Console.WriteLine(a * b);
        // Console.WriteLine(a / b);
        // Console.WriteLine(a % b);
        
        //[4] 1998년생인 내가 태국에서는 2541년생?!
        // string input = Console.ReadLine();
        // int buddhismYear = int.Parse(input);
        // int buddhismYear = int.Parse(Console.ReadLine());
        // int AD = buddhismYear - 543;
        // Console.WriteLine(AD);
        
        //[5] 곱셈
        string inputA = Console.ReadLine();
        string inputB = Console.ReadLine();
        
        int a = int.Parse(inputA);
        int[] b = new int[inputB.Length];
        int i = 0;
        
        foreach (var c in inputB)
        {
            b[i] = int.Parse(c.ToString());
            i++;
        }
        
        Console.WriteLine(a * b[2]);
        Console.WriteLine(a * b[1]);
        Console.WriteLine(a * b[0]);
        Console.WriteLine((a * b[2]) + (a * b[1] * 10) + (a * b[0] * 100));
    }
}