namespace codingTest;

class Program
{
    static void Main(string[] args)
    {
        // int a = 8 >> 1;
        // int b = a >> 2;
        // int c = 0xF0 | 0x0F;
        //
        // Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0'));
        // Console.WriteLine(Convert.ToString(b, 2).PadLeft(8, '0'));
        // Console.WriteLine(c);
        // Console.WriteLine(Convert.ToString(0xF0, 2).PadLeft(8, '0'));
        // Console.WriteLine(Convert.ToString(0x0F, 2).PadLeft(8, '0'));
        // Console.WriteLine(0xF0);
        // Console.WriteLine(0x0F);

        CodingTest_1 CT1 = new CodingTest_1();
        CodingTest_2 CT2 = new CodingTest_2();
        CodingTest_3 CT3 = new CodingTest_3();
        CodingTest_4 CT4 = new CodingTest_4();

        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                CT4.Q2577();
                break;
            case 2:
                CT4.Q3052();
                break;
            case 3:
                CT4.Q1546();
                break;
            case 4:
                CT4.Q8958();
                break;
            case 5:
                CT4.Q10818();
                break;
        }
    }
}