long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
long N = input[0];
long M = input[1];

Console.WriteLine(Math.Abs(N - M));