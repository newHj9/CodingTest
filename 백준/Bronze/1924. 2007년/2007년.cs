int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int M = input[0];
int D = input[1];

string[] resultDay = new[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
int days = 0;

for (int i = 1; i < M; i++)
{
    switch (i)
    {
        case 1 : case 3 : case 5 : case 7 : case 8 : case 10 :
            days += 31;
            break;
        case 2 :
            days += 28;
            break;
        case 4 : case 6 : case 9 : case 11 :
            days += 30;
            break;
    }
}

days += D;
Console.WriteLine(resultDay[days % 7]);