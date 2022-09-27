using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] arr = new char[s.Length];
        arr = s.ToCharArray();
         
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                if(arr[i] - '0' < arr[j] - '0')
                {
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        foreach(char a in arr)
        {
            answer += a.ToString();
        }
        
        return answer;
    }
}