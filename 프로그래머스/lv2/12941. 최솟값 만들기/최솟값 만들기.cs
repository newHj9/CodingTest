using System;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        
        Array.Sort(A);
        //Array.Sort(B, (x, y) => y.CompareTo(x));
        B = B.OrderByDescending(x => x).ToArray();
        /*
        Array.Sort(B, (a, b) => {
           if(a > b)
               return -1;
            else if(a < b)
                return 1;
            else
                return 0;
        });
        */
        for(int i = 0; i < A.Length; i++)
        {
            answer += A[i] * B[i];
        }
        
        return answer;
    }
}