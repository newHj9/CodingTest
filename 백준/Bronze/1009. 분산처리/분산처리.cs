int T = int.Parse(Console.ReadLine());
        
for (int i = 0; i < T; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    string strNum = input[0].ToString();
    char ch = strNum[strNum.Length - 1];

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
        List<int> val = new List<int>();
        int num = 1;
        for (int j = 0; j < input[1]; j++)
        {
            num *= ch - '0';
            string str = num.ToString();
            if (!val.Contains(str[str.Length - 1] - '0'))
            {
                val.Add(str[str.Length - 1] - '0');
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(val[input[1] % val.Count == 0 ? val.Count - 1 : input[1] % val.Count - 1]);
    }
}