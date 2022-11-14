int N = int.Parse(Console.ReadLine());
int[] Num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (N <= 1)
{
    Console.WriteLine(Num[0] * Num[0]);
}
else
{
    Array.Sort(Num);
    Console.WriteLine(Num[0] * Num[Num.Length - 1]);
}