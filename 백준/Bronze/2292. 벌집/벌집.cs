int input = int.Parse(Console.ReadLine());
        
int count = 1;
int sum = 1;

while(input > sum)
{
    sum += 6 * count;
    count++;
}

Console.WriteLine(count);