using System;
using System.Collections.Generic;
using System.Text;

class MyApp
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[][] input = new string[N][];
        Stack<string> stack = new Stack<string>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < N; i++)
        {
            input[i] = Console.ReadLine().Split().ToArray();
        }

        for (int i = 0; i < N; i++)
        {
            switch (input[i][0])
            {
                case "push" :
                    stack.Push(input[i][1]);
                    break;
                case "pop" :
                    if (stack.Count == 0)
                        sb.AppendLine((-1).ToString());
                    else
                        sb.AppendLine(stack.Pop());
                    break;
                case "size" :
                    sb.AppendLine((stack.Count).ToString());
                    break;
                case "empty" :
                    if(stack.Count == 0)
                        sb.AppendLine((1).ToString());
                    else
                        sb.AppendLine((0).ToString());
                    break;
                case "top" :
                    if(stack.Count == 0)
                        sb.AppendLine((-1).ToString());
                    else
                        sb.AppendLine(stack.Peek());
                    break;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}