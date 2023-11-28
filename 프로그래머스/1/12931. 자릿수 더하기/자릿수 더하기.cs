using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        foreach (char digit in n.ToString())
        {
            answer += (int)Char.GetNumericValue(digit);
        }
        
        return answer;
    }
}