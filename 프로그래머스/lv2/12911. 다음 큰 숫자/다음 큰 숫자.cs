using System;
using System.Collections.Generic;
using System.Linq;

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        
        string binary = Convert.ToString(n, 2);
        int cnt = binary.Count(x => x == '1');
        
        for(int i = n + 1; i < 1000000; i++)
        {
            string str = Convert.ToString(i, 2);
            int c = str.Count(x => x == '1');
            if(cnt == c)
            {
                answer = i;
                break;
            }
        }
        
        return answer;
    }
}

/*
string binary = Convert.ToString(n, 2);
        Console.WriteLine(binary);
        
        List<char> ch = new List<char>();
        ch.Add(binary[0]);
        
        int cnt = binary.Count(x => x == '1');
        int len = binary.Length - 3;
        
        if(binary[1] == '1')
        {
            ch.Add('0');
            ch.Add('1');
        }
        else if(binary[1] == '0')
        {
            ch.Add('1');
            ch.Add('0');
        }
        else
        {
            ch.Add('0');
        }
        
        int dif = cnt - 2;
        
        if(dif != 0)
        {
            if(len < dif)
            {
                for(int i = 3; i < dif + 3; i++)
                {
                    ch.Add('1');
                }
            }
            else
            {
                for(int i = 3; i < binary.Length; i++)
                {
                    if(i < binary.Length - dif)
                    {
                        ch.Add('0');
                    }
                    else
                    {
                        ch.Add('1');
                    }
                }
            }
        }
        
        foreach(var c in ch)
        {
            Console.Write(c);
        }
*/