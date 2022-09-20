using System.Runtime.InteropServices;

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
        CodingTest_5 CT5 = new CodingTest_5();
        CodingTest_6 CT6 = new CodingTest_6();
        CodingTest_7 CT7 = new CodingTest_7();
        CodingTest_8 CT8 = new CodingTest_8();
        CodingTest_9 CT9 = new CodingTest_9();
        CodingTest_10 CT10 = new CodingTest_10();
        CodingTest_11 CT11 = new CodingTest_11();
        CodingTest_12 CT12 = new CodingTest_12();
        CodingTest_13 CT13 = new CodingTest_13();
        CodingTest_14_20220920 CT14 = new CodingTest_14_20220920();

        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                CT14.EX1181();
                break;
            case 2:
                CT12.Q3053();
                break;
            case 3:
                CT12.Q2477();
                break;
            case 4:
                CT14.EX12915();
                break;
            case 5:
                CT7.Q2839();
                break;
        }
    }
}