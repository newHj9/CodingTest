int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int x = input[0];
int y = input[1];
int w = input[2];
int h = input[3];
List<int> result = new List<int>();

result.Add(w - x);
result.Add(h - y);
result.Add(x);
result.Add(y);

Console.WriteLine(result.Min());