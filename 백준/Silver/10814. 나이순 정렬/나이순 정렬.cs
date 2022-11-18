using System.Text;

class Program
{
    public class Member
    {
        public int index;
        public int age;
        public string name;
        public bool check;

        public Member(int index, int age, string name)
        {
            this.index = index;
            this.age = age;
            this.name = name;
        }
    }
    
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Member[] members = new Member[N];
        List<int> age = new List<int>();
        List<Member> online = new List<Member>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            //members[i] = new Member(int.Parse(input[0]), input[1]);
            online.Add(new Member(i, int.Parse(input[0]), input[1]));
            age.Add(int.Parse(input[0]));   
        }
        
        // list.OrderBy.ThenBy
        
        online = online.OrderBy(x => x.age).ThenBy(x => x.index).ToList();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            sb.AppendLine(online[i].age + " " + online[i].name);
        }
        
        Console.WriteLine(sb);
    }
}