using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int second = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'S')
            {
                second += 7;
            }
            else if (input[i] == 'V')
            {
                second += 8;
            }
            else if (input[i] == 'Y' || input[i] == 'Z')
            {
                second += 9;
            }
            else
            {
                second += ((input[i] - 'A') / 3) + 2;
            }
        }
        
        Console.WriteLine(second + input.Length);
    }
}