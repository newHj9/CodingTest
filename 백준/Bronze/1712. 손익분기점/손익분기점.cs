using System;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
long cnt = -1;

if (input[1] < input[2])
{
    long result = -1;

    result = input[2] - input[1];
    cnt = input[0] / result;

    Console.WriteLine(cnt + 1);
}
else if(input[1] >= input[2])
{
    Console.WriteLine(cnt);
}