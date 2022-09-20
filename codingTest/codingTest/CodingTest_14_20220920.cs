namespace codingTest;

public class CodingTest_14_20220920
{
    public void EX1181()
    {
        // 단어 정렬
        // 길이가 짧은 것부터
        // 길이가 같으면 사전 순으로

        int n = int.Parse(Console.ReadLine());

        List<string> str = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            str.Add(Console.ReadLine());
        }

        // str.Sort();
        //str = str.OrderBy(a => a.Length).ToList();
        str.Sort((a, b) =>
        {
            if (a.Length > b.Length)
                return 1;
            else if (a.Length < b.Length)
                return -1;
            else
                return String.Compare(a, b);
        });

        str = str.Distinct().ToList();
        // 왜 안되는지?? ㅜ
        // https://withseungryu.tistory.com/140
        /*
        for (int i = 0; i < str.Count - 1; i++)
        {
            for (int j = i + 1; j < str.Count; j++)
            {
                if (str[i] == str[j])
                {
                    str.RemoveAt(j);
                }
            }
        }
        */

        foreach (var a in str)
        {
            Console.WriteLine(a);
        }
    }
    
    public void EX4375()
    {
        // 1
        
    }
    
    public void EX1931()
    {
        // 회의실 배정
        
    }
    
    public void EX12915()
    {
        // 문자열 내 마음대로 정렬하기
        // 문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때,
        // 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬
        
        string[] answer = new string[] {"abce", "abcd", "cdx"};
        int n = 2;

        // 방법 1
        Array.Sort(answer);

        for (int i = 0; i < answer.Length - 1; i++)
        {
            for (int j = i + 1; j < answer.Length; j++)
            {
                string str1 = answer[i];
                string str2 = answer[j];

                if (str1[n] > str2[n])
                {
                    string temp = answer[i];
                    answer[i] = answer[j];
                    answer[j] = temp;
                }
                else if(str1[n] == str2[n])
                {
                    if(String.Compare(str1, str2) == 1)
                    {
                        string temp = answer[i];
                        answer[i] = answer[j];
                        answer[j] = temp;
                    }
                }
            }
        }
        
        // 방법 2
        // 내림차순 : Array.Sort(arr, (a, b) => (a > b) ? -1 : 1);
        // 기본인 오름차순은
        // a < b : -1 
        // a == b : 0
        // a > b : 1

        Array.Sort(answer, (a, b) =>
        {
            if (a[n] < b[n])
                return -1;
            else if (a[n] > b[n])
                return 1;
            else 
                return String.Compare(a, b);
        });

        foreach (var a in answer)
        {
            Console.WriteLine(a);
        }
    }
}