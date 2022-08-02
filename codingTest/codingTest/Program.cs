namespace codingTest;

class Program
{
    static void Main(string[] args)
    {
        CodingTest_1 CT1 = new CodingTest_1();
        CodingTest_2 CT2 = new CodingTest_2();
        CodingTest_3 CT3 = new CodingTest_3();

        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                CT3.Q1110();
                break;
            case 2:
                CT3.Q10871();
                break;
            case 3:
                CT3.Q2439();
                break;
            case 4:
                CT3.Q11022();
                break;
            case 5:
                CT3.Q2742();
                break;
        }
    }
}