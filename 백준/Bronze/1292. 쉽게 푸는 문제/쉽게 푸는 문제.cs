int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = input[0];
int B = input[1];

int cnt = 0, sum = 0;
bool check = false;

for (int i = 1; i <= 1000; i++)
{
    for (int j = 1; j <= i; j++)
    {
        cnt++;
        if (cnt >= A && cnt <= B)
        {
            sum += i;
        }

        if (cnt == B)
        {
            Console.WriteLine(sum);
            check = true;
            break;
        }
    }
    if(check) break;
}