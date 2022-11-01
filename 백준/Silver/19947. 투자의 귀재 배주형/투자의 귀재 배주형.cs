int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int H = input[0];
int Y = (int)input[1];
int[] profit = new int[11];

profit[0] = H;
for (int i = 1; i <= Y; i++)
{
    profit[i] = (int)(profit[i - 1] * 1.05);

    if (i >= 3)
        profit[i] = profit[i] < (int)(profit[i - 3] * 1.2) ? (int)(profit[i - 3] * 1.2) : profit[i];
    if (i >= 5)
        profit[i] = profit[i] < (int)(profit[i - 5] * 1.35) ? (int)(profit[i - 5] * 1.35) : profit[i];
}
Console.WriteLine(profit.Max());