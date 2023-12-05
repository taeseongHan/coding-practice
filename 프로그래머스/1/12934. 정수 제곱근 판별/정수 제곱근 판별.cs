using System;

public class Solution {
    public long solution(long n) {
        
        double sqrtResult = Math.Sqrt(n);
        
        if (sqrtResult % 1 == 0) 
        {
            int x = (int)sqrtResult;
            return (long)Math.Pow(x + 1, 2); 
        }
        else
        {
            return -1; 
        }
    }
}