using System.Runtime.CompilerServices;

namespace codingTest;

public class CodingTest_6
{
    public void Q11654()
    {
        // 아스키 코드
        
        string input = Console.ReadLine();

        Console.WriteLine(input[0] - '0' + 48); //0이 48이라
    }

    public void Q5622()
    {
        // 다이얼
        string input = Console.ReadLine();
        int time = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int num = input[i] - '0' + 48;
            
            if (num >= 65 && num < 68) //ABC
            {
                time += 3;
            } 
            else if (num >= 68 && num < 71) //DEF
            {
                time += 4;
            }
            else if (num >= 71 && num < 74) //GHI
            {
                time += 5;
            }
            else if (num >= 74 && num < 77) //JKL
            {
                time += 6;
            }
            else if (num >= 77 && num < 80) //MNO
            {
                time += 7;
            }
            else if (num >= 80 && num < 84) //PQRS
            {
                time += 8;
            }
            else if (num >= 84 && num < 87) //TUV
            {
                time += 9;
            }
            else //WXYZ
            {
                time += 10;
            }
        }
        
        Console.WriteLine(time);
    }

    public void Q2941()
    {
        // 크로아티아 알파벳
        string input = Console.ReadLine();
        string[] str = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

        string remainder = Croatia(0, input);
        
        Console.WriteLine(remainder.Length);

        string Croatia(int i, string remainder)
        {
            if (i < str.Length)
            {
                if (remainder.Contains(str[i]))
                {
                    remainder = remainder.Replace(str[i], "/");
                }
                i++;
                return Croatia(i, remainder);
            }
            else
            {
                return remainder;
            }
        }
    }

    public void Q1157()
    {
        // 단어 공부
        string input = Console.ReadLine();
        int[] arr = new int[32];

        for (int i = 0; i < input.Length; i++)
        {
            int num = input[i] - 'A';

            num = num >= 32 ? num - 32 : num;
            ++arr[num];
        }
        
        bool count = false;
        int max = 0;
        int A = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                A = i;
                count = true;
            }
            else if(max == arr[i])
            {
                count = false;
            }
        }
        
        if (count == true)
        {
            Console.WriteLine((char)(A + 65));
        }
        else
        {
            Console.WriteLine("?");  
        }
    }

    public void Q10809()
    {
        string input = Console.ReadLine();
        int[] arr = new int[26];
        
        Array.Fill(arr, -1);
        
        for (int i = 0; i < input.Length; i++)
        {
            int num = input[i] - 'a';

            if (arr[num] != -1)
            {
                continue;
            }
            else
            {
                arr[num] = i;
            }
        }

        for (int i = 0; i < 26; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
    
}