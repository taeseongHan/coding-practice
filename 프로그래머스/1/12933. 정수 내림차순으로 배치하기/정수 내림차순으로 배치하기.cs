using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        string nAsString = n.ToString();
        char[] arr = nAsString.ToCharArray();
       
                
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                  
                }
                 
            }
        } 
            answer = long.Parse(string.Concat(arr));

        return answer;
        
            
        
    }
}