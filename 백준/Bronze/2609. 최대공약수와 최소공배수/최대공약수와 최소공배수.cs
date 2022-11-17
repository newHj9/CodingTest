int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
Console.WriteLine(gcd(input[0], input[1]));
Console.WriteLine(lcm(input[0], input[1]));

int gcd(int a, int b)
{
    if (b == 0)
        return a;
    return gcd(b, a % b);
}

int lcm(int a, int b)
{
    return (a * b) / gcd(a, b);
}