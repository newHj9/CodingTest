int input = int.Parse(Console.ReadLine());
int num = 99;

if (input <= num)
{
    Console.WriteLine(input);
}
else
{
    for (int i = 100; i <= input; i++)
    {
        int[] inputs = i.ToString().Select((c) => c - '0').ToArray();
        int count = 0;
        for (int j = 1; j < inputs.Length - 1; j++)
        {
            if (inputs[j - 1] - inputs[j] == inputs[j] - inputs[j + 1])
            {
                count++;
            }
            else
            {
                break;
            }
        }

        if (count == inputs.Length - 2)
        {
            num++;
        }
    }

    Console.WriteLine(num);
}