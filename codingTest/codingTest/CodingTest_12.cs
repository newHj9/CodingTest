namespace codingTest;

public class CodingTest_12
{
    public void CaesarCipher()
    {
        // 프로그래머스 - 시저 암호
        string s = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string answer = "";

        for (int i = 0; i < s.Length; i++)
        {
            if ((int)s[i] >= (int)'A' && (int)s[i] <= (int)'Z')
            {
                int ascii = (int)s[i] + n;

                if (ascii > (int)'Z')
                {
                    ascii = (int)'A' + (ascii - (int)'Z') - 1;
                }

                answer += (char)ascii;
            }
            else if((int)s[i] >= (int)'a' && (int)s[i] <= (int)'z')
            {
                int ascii = (int)s[i] + n;

                if (ascii > (int)'z')
                {
                    ascii = (int)'a' + (ascii - (int)'z') - 1;
                }

                answer += (char)ascii;
            }
            else if (s[i] == ' ')
            {
                answer += ' ';
            }
            
        }

        Console.WriteLine(answer);
    }

    public void Q3053()
    {
        // 택시 기하학
        int input = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Math.PI * input * input);
        Console.WriteLine(2 * input * input);
        
        //Console.WriteLine(MathF.PI); // 3.1415927 - 왜 틀렸다고 나오는지?
        //Console.WriteLine(Math.PI); // 3.141592653589793

    }

    public void Q2477()
    {
        // 참외밭
        int num = int.Parse(Console.ReadLine());
        int[][] input = new int[6][];
        int[] arr1 = new int[3];
        int[] arr2 = new int[3];

        int cnt1 = 0, cnt2 = 0;

        for (int i = 0; i < 6; i++)
        {
            input[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i][0] == 1 || input[i][0] == 2)
            {
                arr1[cnt1] = input[i][1];
                cnt1++;
            }
            else if (input[i][0] == 3 || input[i][0] == 4)
            {
                arr2[cnt2] = input[i][1];
                cnt2++;
            }
        }

        int MaxWidth = arr1.Max();
        int MaxHeight = arr2.Max();

        int blankW = 0, blankH = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == MaxWidth)
            {
                int index = i + 1;
                index = index >= arr1.Length ? index - arr1.Length : index;
                
                blankW = arr1[index];
            }
        }
        
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i] == MaxHeight)
            {
                int index = i + 2;
                index = index >= arr2.Length ? index - arr2.Length : index;
                
                blankH = arr2[index];
            }
        }
        
        Console.WriteLine(((MaxWidth * MaxHeight) - (blankW * blankH)) * num);

        // arr[0] = input[0][1] * input[1][1];
        // arr[1] = input[2][1] * input[3][1];
        // arr[2] = input[4][1] * input[5][1];
        //
        // foreach (var c in arr)
        // {
        //     Console.WriteLine(c);
        // }
        //
        // Array.Sort(arr);
        //
        // Console.WriteLine((arr[2] - arr[1] + arr[0]) * num);

        // for (int i = 0; i < input.Length; i++)
        // {
        //     arr[input[i][0]] = input[i][1];
        //     
        //     Console.WriteLine($"{input[i][0]}: {arr[input[i][0]]}");
        // }
        //
        //
        // int MaxWidth = 0, MaxHeight = 0, MinWidth = 0, MinHeight = 0;
        //
        //
        // MaxWidth = arr[1] > arr[2] ? arr[1] : arr[2];
        // MinWidth = arr[1] < arr[2] ? arr[1] : arr[2];

        // MaxHeight = arr[3] > arr[4] ? arr[3] : arr[4];
        // MinHeight = arr[3] < arr[4] ? arr[3] : arr[4];
        //
        // Console.WriteLine($"{MaxWidth} {MinWidth} {MaxHeight} {MinHeight}");
        // Console.WriteLine();
        // Console.WriteLine(((MaxWidth * MaxHeight) - (MinWidth * MinHeight)) * num);

    }
}