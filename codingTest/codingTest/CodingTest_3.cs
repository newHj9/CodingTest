using System.Text;

namespace codingTest;

public class CodingTest_3
{
    public void Q1110()
    {
        int inputText = int.Parse(Console.ReadLine());
        int[] input = new[] { inputText / 10, inputText % 10 };

        int count = 1;

        for (int i = 0; i < count; i++)
        {
            int sum = (input[1] * 10) + ((input[0] + input[1]) % 10);
            
            if(sum != inputText)
            {
                input[0] = sum / 10;
                input[1] = sum % 10;
                
                count++;
            }
            else
            {
                break;
            }
        }
        
        Console.WriteLine(count);
    }

    public void Q10871()
    {
        int[] inputA = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] inputB = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < inputB.Length; i++)
        {
            if(inputB[i] < inputA[1])
                Console.Write($"{inputB[i]}" + " ");
        }
        
    }

    public void Q2439()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            for (int j = 1; j < input - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i + 1; k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }

    public void Q11022()
    {
        int count = int.Parse(Console.ReadLine());
        int[] output = new int[count * 2];
        
        for (int i = 0; i < count; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            output[i * 2] = input[0];
            output[i * 2 + 1] = input[1];
        }
        
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Case #{i + 1}: {output[i * 2]} + {output[i * 2 + 1]} = {output[i * 2] + output[i * 2 + 1]}");
        }
    }

    public void Q2742()
    {
        int input = int.Parse(Console.ReadLine());
        // 시간 초과되어 넣은 "StringBuilder", 왜 넣어야하는지?
        // 맨 위에 using System.Text; 넣음
        StringBuilder output = new StringBuilder();

        for (int i = input; i > 0; i--)
        {
            output.Append(i + "\n");
        }
        Console.WriteLine(output);
    }
}