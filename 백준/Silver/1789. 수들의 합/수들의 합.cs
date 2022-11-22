long S = long.Parse(Console.ReadLine());
long num = 0, sum = 0;

while (sum <= S)
{
    num++;
    sum += num;
}

Console.WriteLine(--num);