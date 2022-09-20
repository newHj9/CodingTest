using System.Text;

namespace codingTest;

public class CodingTest_8
{
    public void Q10872()
    {
        // 팩토리얼
        int input = int.Parse(Console.ReadLine());
        int sum = 1;

        factorial(1);

        Console.WriteLine(sum);
        
        int factorial(int cnt)
        {
            if (cnt > input)
            {
                return 0;
            }
            sum *= cnt;
            cnt++;
            return factorial(cnt);
        }
        
    }

    public void Q10870()
    {
        // 피보나치 수 5
        int input = int.Parse(Console.ReadLine());
        int sum = 1;
        
        Console.WriteLine(fibonacci(0, 0));

        int fibonacci(int cnt, int num)
        {
            sum += num;

            //Console.WriteLine($"{cnt} {num} {sum}");
            
            if (cnt >= input - 1)
            {
                return input % 2 == 0 ? num : sum;
            }
            else
            {
                cnt += 2;
                return fibonacci(cnt, sum + num);
            }
        }
    }

    public void Q17478()
    {
        // 재귀함수가 뭔가요?
        int input = int.Parse(Console.ReadLine());
        
        Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
        
        string[] str = new string[8];

        str[0] = "____";
        str[1] = "재귀함수가 뭔가요?\"";
        str[2] = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.";
        str[3] = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.";
        str[4] = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"";
        str[5] = "\"재귀함수가 뭔가요?\"";
        str[6] = "\"재귀함수는 자기 자신을 호출하는 함수라네\"";
        str[7] = "라고 답변하였지.";


        Recursion(input, 0, str);

        // Console.WriteLine("\"재귀함수가 뭔가요?\"");
        // Console.WriteLine("\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
        // Console.WriteLine("마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
        // Console.WriteLine("그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");



        //Console.WriteLine("라고 답변하였지.");
    }

    public StringBuilder Recursion(int input, int num, string[] str)
    {
        StringBuilder sb = new StringBuilder();
        
        if (input > num)
        {
            for (int i = 0; i < num; i++)
            {
                sb.Append(str[0]);
            }
            
            Console.WriteLine(sb + str[1]);
            Console.WriteLine(sb + str[2]);
            Console.WriteLine(sb + str[3]);
            Console.WriteLine(sb + str[4]);
            
            input--;
            num++;
        }
        else
        {
            for (int i = num; i > 1; i--)
            {
                sb.Append(str[0]);
            }
            
            if (input == num)
            {
                Console.WriteLine(sb + str[5]);
                Console.WriteLine(sb + str[6]);
            }
            
            Console.WriteLine(sb + str[7]);
            
            num--;
        }

        if (input == 0 && num == 0)
        {
            //return ;
        }
        
        return Recursion(input, num, str);
    }

    public void Q2447()
    {
        // 별찍기-10
    }

    public void Q11792()
    {
        // 하노이 탑 이동 순서
    }
}