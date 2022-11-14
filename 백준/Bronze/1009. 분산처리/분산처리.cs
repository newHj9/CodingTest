int T = int.Parse(Console.ReadLine());
        
for (int i = 0; i < T; i++)
{
    string[] input = Console.ReadLine().Split().ToArray();
    string oneNum = input[0];
    char ch = oneNum[oneNum.Length - 1];

    if (ch == '0')
    {
        Console.WriteLine(10);
    }
    else if (ch == '1' && ch == '5' && ch == '6')
    {
        Console.WriteLine(ch);
    }
    else
    {
        int twoNum = int.Parse(input[1]);

        List<int> val = new List<int>();
        int num = 1;
        for (int j = 0; j < twoNum; j++)
        {
            num *= ch - '0';
            string str = num.ToString();
            if (!val.Contains(str[str.Length - 1] - '0'))
                val.Add(str[str.Length - 1] - '0');
            else
                break;
        }

        Console.WriteLine(val[twoNum % val.Count == 0 ? val.Count - 1 : twoNum % val.Count - 1]);
    }
}