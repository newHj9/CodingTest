using System;

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int A = input[0];
int B = input[1];
int C = input[2];

if (B >= C)
{
    Console.WriteLine(-1);
}
else
{
    int result = (A / (C - B)) + 1;
    Console.WriteLine(result);
}