int T = int.Parse(Console.ReadLine());
        
for (int i = 0; i < T; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int remainder = input[0] % 10;

    if (remainder == 0)
    {
        Console.WriteLine(10);
    }
    else if (remainder == 1 && remainder == 5 && remainder == 6)
    {
        Console.WriteLine(remainder);
    }
    else
    {
        List<int> val = new List<int>();
        int num = 1;
        for (int j = 0; j < input[1]; j++)
        {
            num = num * remainder % 10;
            if (!val.Contains(num))
                val.Add(num);
            else
                break;
        }

        Console.WriteLine(val[input[1] % val.Count == 0 ? val.Count - 1 : input[1] % val.Count - 1]);
    }
}