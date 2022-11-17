int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    Console.WriteLine(lcm(input[1], input[0]));
}

int gcb(int a, int b)
{
    if (b == 0)
        return a;

    return gcb(b, a % b);
}

int lcm(int a, int b)
{
    return (a * b) / gcb(a, b);
}