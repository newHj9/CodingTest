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
        
        // CodingTest_1 CT1 = new CodingTest_1();
        // CodingTest_2 CT2 = new CodingTest_2();
        // CodingTest_3 CT3 = new CodingTest_3();
        // CodingTest_4 CT4 = new CodingTest_4();
        // CodingTest_5 CT5 = new CodingTest_5();
        // CodingTest_6 CT6 = new CodingTest_6();
        // CodingTest_7 CT7 = new CodingTest_7();
        // CodingTest_8 CT8 = new CodingTest_8();
        // CodingTest_9 CT9 = new CodingTest_9();
        // CodingTest_10 CT10 = new CodingTest_10();
        // CodingTest_11 CT11 = new CodingTest_11();
        // CodingTest_12 CT12 = new CodingTest_12();
        // CodingTest_13 CT13 = new CodingTest_13();
        CodingTest_14_20220920 CT14 = new CodingTest_14_20220920();
        CodingTest_15 CT15 = new CodingTest_15();
        CodingTest_16 CT16 = new CodingTest_16();
        CodingTest_17 CT17 = new CodingTest_17();
        CodingTest_18 CT18 = new CodingTest_18();
        CodingTest_19 CT19 = new CodingTest_19();
        CodingTest_20 CT20 = new CodingTest_20();
        CodingTest_21 CT21 = new CodingTest_21();
        CodingTest_22 CT22 = new CodingTest_22();
        CodingTest_23 CT23 = new CodingTest_23();
        CodingTest_24 CT24 = new CodingTest_24();

        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                CT24.BJ1969();
                break;
            case 2:
                CT20.BJ25501();
                break;
            case 3:
                CT20.BJ24060();
                break;
            case 4:
                CT14.EX12915();
                break;
        }
    }
}