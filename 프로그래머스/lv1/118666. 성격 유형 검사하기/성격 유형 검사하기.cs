using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        /*
        Dictionary<string, int> dic = new Dictionary<string, int>(); 
        dic.Add("R", 0);
        dic.Add("T", 0);
        dic.Add("C", 0);
        dic.Add("F", 0);
        dic.Add("J", 0);
        dic.Add("M", 0);
        dic.Add("A", 0);
        dic.Add("N", 0);
        */
        
        string[] dicIdx = new string[] {"R", "T", "C", "F", "J", "M", "A", "N"};
        int[] cnt = new int[dicIdx.Length];
        
        for(int i = 0; i < survey.Length; i++)
        {
            string str = survey[i];
            
            for(int j = 0; j < dicIdx.Length; j++)
            {
                if(str[0].ToString() == dicIdx[j])
                {
                    if(j % 2 == 0)
                    {
                        if(choices[i] > 3)
                        {
                            cnt[j + 1] += choices[i] - 4;
                        }
                        else 
                        {
                            cnt[j] += 4 - choices[i];
                        }
                    }
                    else
                    {
                        if(choices[i] > 3)
                        {
                            cnt[j - 1] += choices[i] - 4;
                        }
                        else 
                        {
                            cnt[j] += 4 - choices[i];
                        }
                    }
                }
            }
        }
        
        /*
        for(int i = 0; i < cnt.Length; i++)
        {
            Console.WriteLine($"{dicIdx[i]} {cnt[i]}");
        }
        */
        
        for(int i = 0; i < cnt.Length; i += 2)
        {
            if(cnt[i] >= cnt[i + 1])
            {
                answer += dicIdx[i];
            }
            else
            {
                answer += dicIdx[i + 1];
            }
        }
        
        return answer;
    }
}