using System;
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        string[] days = new string[7] {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        int[] monDays = new int[12] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        int sum = 0;
        
        for(int i = 0; i < a - 1; i++)
        {
            sum += monDays[i];
        }
        
        sum += b - 1;
        
        return answer = days[sum % 7];;
    }
}